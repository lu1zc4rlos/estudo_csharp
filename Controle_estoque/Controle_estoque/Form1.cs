using Npgsql;
using System.Data;

namespace Controle_estoque
{
    public partial class Form1 : Form {

        private static string _ConexaoComBanco = "Host=localhost;Username=postgres;Password=120920;Database=estoque";
        public static NpgsqlConnection Abrir() {
            var Conexao = new NpgsqlConnection(_ConexaoComBanco);
            Conexao.Open();
            return Conexao;

        }
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Hide();
            using (Cadastro cadastro = new Cadastro()) {
                cadastro.ShowDialog();
            }
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            using (Adicionar adicionar = new Adicionar()) {
                adicionar.ShowDialog();
            }
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Hide();
            using (Retirar retirar = new Retirar()) {
                retirar.ShowDialog();
            }
            this.Show();
        }

       
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {
        }
        private void Form1_Load(object sender, EventArgs e) {
            CarregarDadosNoGrid();
        }

        private void CarregarDadosNoGrid() {
            dataGridView1.DataSource = null;

            using var conexao = Abrir();

            try {

                string sql = "SELECT id_produto, nome, preco, quantidade FROM produto ORDER BY nome";

                using var adaptador = new NpgsqlDataAdapter(sql, _ConexaoComBanco);

                var tabelaDeDados = new DataTable();

                adaptador.Fill(tabelaDeDados);


                dataGridView1.DataSource = tabelaDeDados;
            }
            catch (Exception ex) {
                MessageBox.Show($"Ocorreu um erro ao carregar os produtos: {ex.Message}",
                                "Erro de Banco de Dados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
           
        }
    }
}
