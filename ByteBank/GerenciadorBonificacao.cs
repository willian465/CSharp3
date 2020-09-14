using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        public double _totalBonificacao;

        /// <summary>
        /// Registra o total de gastos da empresa com Bonificações
        /// </summary>
        /// <param name="funcionario"></param>
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();

        }
        /// <summary>
        /// Retorna o total de bonificações concedidos pela ByteBank
        /// </summary>
        /// <returns></returns>
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
