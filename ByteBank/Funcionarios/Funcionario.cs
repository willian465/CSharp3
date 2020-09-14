namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalFuncionarios { get; private set; }

        /// <summary>
        /// Construtor da Classe
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="salario"></param>
        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            TotalFuncionarios++;
        }

        /// <summary>
        /// Método para amentar o salário do Funcionário
        /// </summary>
        public virtual void AumentarSalario()
        {   //Salario = Salario + (Salario * 0.1);
            //Salario = Salario * 1.1;
            Salario *= 1.1;
        }

        /// <summary>
        /// Método que retorna a bonificação dos Funcionarios
        /// </summary>
        /// <returns></returns>
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
