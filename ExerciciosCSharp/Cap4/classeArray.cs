using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.Cap4
{
    public class classeArray
    {
        static void Main()
        {
            // Declarando uma array e já atribuindo valores
            int[] segundoArray = new int[] { 1, 3, 5, 7, 9 };
            Console.Write("Valor do array na posição 0 -> {0}  ", segundoArray[2]);
        }
    }

    public class ExemploList
    {
        static void Main()
        {
            List<string> nomesFuncionarios = new List<string>();
            nomesFuncionarios.Add("Maria");
            nomesFuncionarios.Add("João");
            nomesFuncionarios.Add("André");
            nomesFuncionarios.Add("Flávia");
            Console.WriteLine();
            //foreach (string pessoa in nomesFuncionarios)
            //{
            //    Console.WriteLine(pessoa);
            //}

            //Removendo Maria da lista
            nomesFuncionarios.RemoveAt(0);
            Console.WriteLine(nomesFuncionarios[0]);
        }
    }
}