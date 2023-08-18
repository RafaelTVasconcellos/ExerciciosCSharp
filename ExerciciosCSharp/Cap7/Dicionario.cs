using System;
using System.Collections.Generic;
using System.Linq;
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
            WriteLine(sexo["F"]);

            var cidades = new Dictionary<string, string>
            {
                ["MG"] = "Minas Gerais",
                ["SC"] = "Santa Catarina",
                ["SP"] = "São Paulo",
                ["RS"] = "Rio Grande do Sul"
            };
            WriteLine($"---  dicionário com {cidades.Count()} Cidades ---");
            WriteLine(cidades["MG"]);

            //string Cid = ReadLine();
            //WriteLine(cidades[Cid]);

            //WriteLine(cidades["mg"]); // gera erro
            //WriteLine(cidades[0]); // erro compilação
            foreach (var cidade in cidades)
            {
                WriteLine($"sigla: {cidade.Key} - {cidade.Value}");
            }


            WriteLine("---dicionário Países-- -");
            var paises = new Dictionary<int, string>
            {
                [100] = "Brasil",
                [2] = "Australia",
                [60] = "Nova Zelandia"
            };
            foreach (var pais in paises)
            {
                WriteLine($"{pais.Key} - {pais.Value}");
            }


            var texto = new string[]
            {
                                // índice do início    índice do final
                "Meu",          // 0                         ^9
                "codigo",       // 1                         ^8
                "rodou",        // 2                         ^7
                "sem",          // 3                         ^6
                "erros",        // 4                         ^5
                "para",         // 5                         ^4
                "ler",          // 6                         ^3
                "cadastro",     // 7                         ^2
                "clientes"      // 8                         ^1
            };
            WriteLine("---Índices do dicionário---");
            WriteLine($"A última palavra é {texto[^1]}");
            WriteLine($"A primeira palavra é: {texto[^9]}");

            WriteLine($"A primeira palavra é: {texto[0]}");
            WriteLine($"A segunda palavra é: {texto[1]}");
            WriteLine($"A sexta palavra é: {texto[7]}");


            WriteLine("--- Parte do Texto ---");
            var pedacoTexto = texto[1..4];
            foreach (var p in pedacoTexto)
            {
                WriteLine(p);
            }

            WriteLine("---intervalo da coleção---");
            Range intervalo = 1..6;
            foreach (var p in texto[intervalo])
            {
                WriteLine(p);
            }


            WriteLine("--- primeiras 4 ---");
            var Primeiras4 = texto[..4]; // primeiras 4 palavras
            foreach (var p in Primeiras4)
            {
                WriteLine(p);
            }

            WriteLine("--- últimas 4 ---");
            var Ultimas4 = texto[5..]; // 4 últimas pelo índice 5
            foreach (var p in Ultimas4)
            {
                WriteLine(p);
            }
            ReadLine();

            WriteLine("--- Todas ---");
            var todas = texto[..];   // todas as palavras
            foreach (var p in todas)
            {
                WriteLine(p);
            }
            ReadLine();
        }
    }
}
