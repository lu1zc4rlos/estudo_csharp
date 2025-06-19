namespace Exercicio_de_fixacao_listas_ {
    public class Funcionarios {
        public int Id { get; set; }
        private string Name { get; set; }
        public double Salario { get; set; }

        public Funcionarios(int id, string name, double salario) {
            Id = id;
            Name = name;
            Salario = salario;
        }
        public Funcionarios() {
        }
        public override string ToString() {
            return $"Id: {Id}, Nome: {Name}, Salario: {Salario.ToString("F2")}";
        }
    }
}
  

