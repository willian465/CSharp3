using System.Globalization;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {

        public Diretor(string nome, string cpf)
            : base(nome, cpf, 5000) { }

        /// <summary>
        /// Aumenta o salário do Diretor
        /// </summary>
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        /// <summary>
        /// Retorna a bonificação do Diretor 
        /// </summary>
        /// <returns></returns>
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
