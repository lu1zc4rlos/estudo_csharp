namespace Controle_estoque {
    public class Produto {
    
        public int id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade) {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }
        public Produto(string nome, int quantidade) {
            this.nome = nome;
            this.quantidade = quantidade;
        }
    }
}
