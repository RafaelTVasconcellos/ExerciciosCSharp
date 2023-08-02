using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExerciciosCSharp.Cap3
{
    class funcoesDatas
    {
        static void Main(string[] args)
        {
            // Aula 04
            int dia = 12;
            int mes = 05;
            int ano = 2021;
            DateTime dtAniversario = new DateTime(ano, mes, dia);
            DateTime dtFesta = new DateTime(2021, 08, 25);
            WriteLine("------Funções de Datas------ -");
            WriteLine($"Aniversário: {dtAniversario}");
            WriteLine($"Aniversário: {dtAniversario: dd/MM/yyyy}");
            WriteLine($"Aniversário: {dtAniversario: dddd/MMM/yyyy}");
            WriteLine($"Aniversário: {dtAniversario: dddddd/MMMM/yyyy}");


            // uso de Datas em Objetos
            var pedido = new Pedido
            {
                PedidoID = 1,
                DtPedido = DateTime.Today,
                DtPagto = DateTime.Today.AddDays(45),
                Valor = 1500
            };
            WriteLine($"Pedido: { pedido.PedidoID} - " +
                $"{ pedido.DtPedido:dd / MMM / yyyy} - " +
                $"vencto:{pedido.DtVencimento():dd / MMM /yyyy} - " +
                $"dias atraso: { pedido.DiasAtraso().TotalDays} - " +
                $"valor: { pedido.Valor:n2} - " +
                $"multa: { pedido.Multa:n2}");

            //Uso do Datetime.Today e Datetime.Now
            DateTime hoje = DateTime.Today;
            WriteLine("TODAY - retorna a data atual");
            WriteLine($"TODAY: { hoje: dd / MM / yyyy}");

            // Aula 05
            DateTime DataHora = DateTime.Now;
            WriteLine("NOW - retorna a data e a hora atual");
            WriteLine($"Data  e  Hora:  {DataHora: dd / MM /yyyy hh: mm: ss}");

            WriteLine("DAY / MONTH / YEAR - capturar o dia, mês e ano separadamente");
            WriteLine($"Dia: { DataHora.Day}");
            WriteLine($"Mês: { DataHora.Month}");
            WriteLine($"Ano: { DataHora.Year}");


            DateTime dtPedido = DateTime.Today;
            // Adiciona 35 dias
            DateTime dtVencto = dtPedido.AddDays(35);
            // Adicionar 2 meses
            DateTime dtPagto = dtVencto.AddMonths(2);
            WriteLine($"Pedido  feito  em  {dtPedido: dd/MMM/yyyy} vence em { dtVencto: dd/MMM/yyyy}");
            WriteLine($"Formatação  completa:  {dtVencto.ToLongDateString()}");
            WriteLine($"Formatação  curta:  {dtVencto.ToShortDateString()}");
            // Dia da semana
            WriteLine($"Dia da semana: { dtVencto.DayOfWeek}");
            WriteLine($"Dia do semana em português: {dtVencto.ToString("dddd", new CultureInfo("pt-BR"))}");
            WriteLine($"Número  do dia da  semana:  {(int)dtVencto.DayOfWeek}");
            // Dia do ano
            WriteLine($"Dia do ano: { dtVencto.DayOfYear}");

            // Subtrai 2 datas
            var qtdeDias = dtPagto.Subtract(dtPedido);
            WriteLine($"Entre  o  pedido  e  o  pagamento  foram {qtdeDias:dd} dias");



            //Conversões de Datas
            WriteLine("Conversão de Texto para Date");
            string dataTexto = "15/07/2021";
            DateTime dataTextoConvertida;
            // tentativa (TryParse) de conversão de dataTexto
            // caso dê certo a saída OUT será em dataTextoConvertida
            if (DateTime.TryParse(dataTexto, out dataTextoConvertida))
                WriteLine("Data com conversão aceita");
            else
                WriteLine("Erro na conversão da data");

            string dataTextoErrada = "15 / 02 / 2021";
            DateTime dataTextoErradaConvertida;
            if (DateTime.TryParse(dataTextoErrada, out dataTextoErradaConvertida))
                WriteLine("Data com conversão aceita");
            else
                WriteLine("Erro na conversão da data");
        }
    }

    public class Pedido
    {
        public int PedidoID { get; set; }
        public DateTime DtPedido { get; set; }
        public DateTime DtVencimento() => DtPedido.AddDays(30);
        public DateTime DtPagto { get; set; }
        public TimeSpan DiasAtraso() => DtPagto.Subtract(DtVencimento());
        public decimal Valor { get; set; }
        public decimal Multa => Valor * 0.10M;
    }
}