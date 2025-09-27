using Npgsql;

namespace Controle_estoque {
    public partial class Adicionar : Form {
        public Adicionar() {
            InitializeComponent();
        }
        private static string _ConexaoComBanco = "Host=localhost;Username=postgres;Password=120920;Database=estoque";
        public static NpgsqlConnection Abrir() {
            var Conexao = new NpgsqlConnection(_ConexaoComBanco);
            Conexao.Open();
            return Conexao;

        }

        private void button1_Click(object sender, EventArgs e) {

            Produto produto = new Produto(txtNome.Text, Convert.ToInt32(txtQuantidade.Text));

            if (!int.TryParse(txtQuantidade.Text, out int quantidade)) {
                MessageBox.Show("Por favor, insira uma quantidade válida (número inteiro).", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(produto.nome)) {
                MessageBox.Show("O campo 'Nome' é obrigatório e não pode estar vazio.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {

                using var conexao = Abrir();
                var selectCmd = new NpgsqlCommand("SELECT quantidade FROM produto WHERE nome = @nome", conexao);
                selectCmd.Parameters.AddWithValue("nome", produto.nome);
                var resultado = selectCmd.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value) {
                    MessageBox.Show("Produto não encontrado no estoque.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int quantidadeAtual = Convert.ToInt32(resultado);

                int novaQuantidade = quantidadeAtual + int.Parse(txtQuantidade.Text);

                var updateCmd = new NpgsqlCommand("UPDATE produto SET quantidade = @novaQuantidade WHERE nome = @nome", conexao);
                updateCmd.Parameters.AddWithValue("novaQuantidade", novaQuantidade);
                updateCmd.Parameters.AddWithValue("nome", produto.nome);

                updateCmd.ExecuteNonQuery();

                MessageBox.Show($"Estoque de '{produto.nome}' atualizado com sucesso! Nova quantidade: {novaQuantidade}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                txtQuantidade.Clear();
            }
            catch (NpgsqlException ex) {
                MessageBox.Show($"Ocorreu um erro ao conectar ou salvar no banco de dados: {ex.Message}", "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro Geral", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            using (Form1 form1 = new Form1()) {
                form1.ShowDialog();
            }
            this.Show();
        }
    }
}
