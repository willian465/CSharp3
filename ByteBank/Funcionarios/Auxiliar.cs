using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string nome, string cpf) : base(nome, cpf, 2000) { }


        /// <summary>
        /// Método que aumenta o salário do Auxiliar
        /// </summary>
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        /// <summary>
        /// Método que retorna a bonificação do Auxiliar
        /// </summary>
        /// <returns></returns>
        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
