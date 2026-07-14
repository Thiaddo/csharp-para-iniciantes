using static System.Console;
using System;
using System.Linq;
using System.Globalization;
using System.Data;

namespace livrocsharp
{
  class FuncoesDatas
    {
        [Obsolete]
        static void Main(string[] args)
        {
            int dia = 12;
            int mes = 05;
            int ano = 2021;

            DateTime dtAniversario = new DateTime(ano, mes, dia);
            DateTime dtFesta = new DateTime(2021, 08, 25);

            WriteLine("------ Funções de Datas ------");
            WriteLine($"Aniversário: {dtAniversario}");
            WriteLine($"Aniversário: {dtAniversario:dd/MM/yyyy}");
            WriteLine($"Aniversário: {dtAniversario:dddd dd/MMMM/yyyy}");

            DateTime hoje = DateTime.Today;
            WriteLine("TODAY - retorna a data atual");
            WriteLine($"TODAY: {hoje:dd/MM/yyyy}");

            DateTime DataHora = DateTime.Now;
            WriteLine($"Data e Hora: {DataHora:dd/MM/yyyy hh:mm:ss}");

            WriteLine($"DAY / MONTH / YEAR - capturar o dia mês e ano separadamente");
            WriteLine($"Dia: {DataHora.Day}");
            WriteLine($"Mês: {DataHora.Month}");
            WriteLine($"Ano: {DataHora.Year}");

            DateTime dtPedido = DateTime.Today;
            // adiciona 35 dias
            DateTime dtVencto = dtPedido.AddDays(35);

            // adicionar 2 meses
            DateTime dtPagto = dtVencto.AddMonths(2);
            WriteLine($"Pedido feito em {dtPedido:dd/MMM/yyyy} vence em {dtVencto:dd/MMM/yyyy}");

            WriteLine($"Formatação completa: {dtVencto.ToLongDateString}");
            WriteLine($"Formatação curta: {dtVencto.ToShortTimeString}");
        }
    }
}