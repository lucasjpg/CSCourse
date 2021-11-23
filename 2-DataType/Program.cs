/*
Para criar um projeto .NET:
dotnet new console

# Convenções
Camel Case: lastName (Parâmetros de métodos, variáveis dentro de métodos)
Pascal Case: LastName (namespaces, classes, properties and metodos)
Padrão: _lastName (Atributos "internos" da classe)

Conversão implícita: De float para double (4 Bytes < 8 Bytes)
Conversão explícita: De double para float (8 Bytes > 4 Bytes)
Para conversão explícita necessário "incluir o casting", exemplo:
double a; float b; a = 0.0; b = (float)a;
double a; int b; a = 0.0; b = (int)a;

Para possibilitar o uso de ReadLine ou ReadKey no VSCode:
Necessário alterar a linha "console": "internalConsole" em launch.json para "integratedTerminal".
Para interagir com o programa, basta acessar a aba TERMINAL no seu VSCode.

O escopo de uma variável é a região do programa onde ela é válida (pode ser referenciada).
Funções em classes recebem o nome de "métodos". (Modularização, delegação e reaproveitamento).
*/

using System;
using System.Globalization;

namespace Parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world, here's the C# basics\n");

            Console.WriteLine("C# built-in data types (tipos valor):");
            sbyte a = 0;
            byte b = 0;
            int c = 0;
            float d = 5.894364f;
            double e = 0.0;
            decimal f = 0.0000000000m;
            char g = 'A';
            bool h = true;
            string i = "Lucas"; // Immutable, a new string is created when need changes.
            object j = 0;

            Console.WriteLine("{0} - {1}", a, a.GetType());
            Console.WriteLine("{0} - {1}", byte.MinValue, b.GetType());
            Console.WriteLine("{0} - {1}", int.MaxValue, c.GetType());
            Console.WriteLine("{0} - {1}", d.ToString("F3"), d.GetType());
            Console.WriteLine("{0} - {1}", e.ToString("F1", CultureInfo.InvariantCulture), e.GetType());
            Console.WriteLine("{0} - {1:F10}", f, f.GetType());
            Console.WriteLine($"{g} - {g.GetType()}");
            Console.WriteLine(h.GetType());
            Console.WriteLine(i.GetType());
            Console.WriteLine(j.GetType());

            Console.WriteLine("\nArithmetic overflow sbyte(-128 to 127) example:");
            a = 127;
            Console.WriteLine(a + " + 1 = {0}", ++a);

            Console.WriteLine("\nCasting example:");
            int k = 5; int l = 2;
            double res = (double) k / l;
            Console.WriteLine($"{k} / {l} = {res}");

            // ReadLine works only with string, array or not.
            Console.WriteLine("\nScanning from keyboard, enter a phrase:");
            string[] phrase = Console.ReadLine().Split(' ');          
            for (int cont = 0; cont < phrase.Length; cont++) {
                Console.Write($"{phrase[cont]} ");
            }
            // For read other data type, use Parse:
            Console.WriteLine("\nScanning from keyboard, enter a number (with comma):");
            double dbl = double.Parse(Console.ReadLine());
            Console.WriteLine(dbl);

            // For read using invariant culture:
            Console.WriteLine("\nScanning from keyboard, enter other number (with dot):");
            double dbl2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(dbl2);

            // Using functions
            int m = Maior(5, 3, 6);
            Console.WriteLine("\nThe largest number is: " + m);

            Console.Write("\nBye ");
            Console.Write("World!\n");
        }
        static int Maior(int A, int B, int C) 
        {
            int maior;
            if (A > B && A > 3)
                maior = A;
            else if (B > C)
                maior = B;
            else
                maior = C;
            return maior;
        }
    }
}