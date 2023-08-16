using System;
using System.Collections.Generic;
using static System.Console;

namespace Cap7
{
    class Dicionario
    {
        static void Main(string[] ags)
        {
            WriteLine("--- Uso de Dicionários ---");
            var sexo = new Dictionary<string, string>();
            sexo.Add("M", "Masculino");
            sexo.Add("F", "Feminino");
        }
    }
}
