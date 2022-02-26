using System;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datafimPagamento = new DateTime(2022, 2, 18);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(120);//datafimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);
            Console.ReadLine();
        }
    }
}
