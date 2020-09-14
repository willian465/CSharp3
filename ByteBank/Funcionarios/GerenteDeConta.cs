using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string nome, string cpf)
            : base(nome, cpf, 4000) { }

        /// <summary>
        /// Método para aumentar o salário do Gerente de Conta
        /// </summary>
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        /// <summary>
        /// Método que retorna a bonificação do Gerente de conta
        /// </summary>
        /// <returns></returns>
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }

}
