using Npgsql;

namespace Controle_estoque {
    public partial class Cadastro : Form {
        public Cadastro() {
            InitializeComponent();
        }

        private static string _ConexaoComBanco = "Host=localhost;Username=postgres;Password=120920;Database=estoque";
        public static NpgsqlConnection Abrir() {
            var Conexao = new NpgsqlConnection(_ConexaoComBanco);
            Conexao.Open();
            return Conexao;

        }

        private void button1_Click(object sender, EventArgs e) {
            if (!decimal.TryParse(txtPreco.Text, out decimal preco)) {
                MessageBox.Show("Por favor, insira um valor de preço válido.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int quantidade)) {
                MessageBox.Show("Por favor, insira uma quantidade válida (número inteiro).", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Produto produto = new Produto(txtNome.Text, Convert.ToDouble(txtPreco.Text), Convert.ToInt32(txtQuantidade.Text));

            try {
                using var conexao = Abrir();
                using var comando = new NpgsqlCommand("INSERT INTO produto (nome, preco, quantidade) VALUES (@nome, @preco, @quantidade)", conexao);

                comando.Parameters.AddWithValue("nome", produto.nome);
                comando.Parameters.AddWithValue("preco", produto.preco);
                comando.Parameters.AddWithValue("quantidade", produto.quantidade);

                comando.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                txtPreco.Clear();
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

