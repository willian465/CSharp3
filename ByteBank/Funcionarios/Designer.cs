using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string nome, string cpf)
            : base(nome, cpf, 3000) { }


        /// <summary>
        /// Aumenta o salário do Designer
        /// </summary>
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        /// <summary>
        /// Retorna a bonificação do Designer
        /// </summary>
        /// <returns></returns>
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

    }
}
