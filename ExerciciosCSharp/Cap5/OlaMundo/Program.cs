using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.Cap5.OlaMundo
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            //Declaramos uma variavel do tipo string (texto)
            String Digitado = new String("");
            //Solicitamos que o usuario digite alguma coisa e
            //armazene na variavel criada
            Digitado = Console.ReadLine();
            //Mostramos o que foi digitado             
            Console.WriteLine(Digitado);
        }
    }
}