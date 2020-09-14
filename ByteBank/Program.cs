using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer carlos = new Designer("Carlos", "123.152.366-00");

            Diretor roberta = new Diretor("Roberta de Cássia Guimarãess", "123.635.986-63");

            Auxiliar Igor = new Auxiliar("Pedro Luiz de OLiveira", "123.563.695-63");

            GerenteDeConta Camila = new GerenteDeConta("Camila Gomes Pinto", "163.189.178-63");

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(Igor);
            gerenciador.Registrar(Camila);

            Console.WriteLine("Total de bonificações do mês: " + gerenciador.GetTotalBonificacao());
        }
    }
}
