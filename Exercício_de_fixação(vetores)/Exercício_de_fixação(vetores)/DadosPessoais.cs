namespace Exercício_de_fixação_vetores_ {
    public class DadosPessoais {
        private string Nome { get; set; }
        private string Email { get; set; }
        private int Quarto { get; set; }

        public DadosPessoais(string nome, string email, int quarto) {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }
        public override string ToString() {
            return $"{Quarto}: {Nome}, {Email}";
        }
    }
}



