using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(8484, 46548);

            new ContaCorrente(123456, 1651651);

            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
