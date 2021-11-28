/*
    # Cria uma solution (serve como um container para um ou mais projetos)
    dotnet new sln
    # Cria um novo projeto
    dotnet new console
    # Cria um novo projeto de bibliteca no local
    dotnet new classlib --force
    # Cria um novo projeto de biblioteca em local especificado
    dotnet new classlib -o NomeBiblioteca
    # Adiciona o projeto de biblioteca na solução
    dotnet sln add NomeBiblioteca/NomeBiblioteca.csproj

    Classes possuem atributos (dados e campos) e métodos (funções e operações)
    Classes provêem recursos (Construtores, sobrecarga, encapsulamento, herança e polimorfismo)
    A classe representada neste arquivo será uma entidade.
*/

using System;
using System.Globalization;

namespace _3_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo();
            Triangulo t2 = new Triangulo();

            Console.WriteLine("Informe as dimensões A, B e C do triangulo 1: ");
            t1.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            t1.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            t1.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe as dimensões A, B e C do triangulo 2: ");
            t2.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            t2.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            t2.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaT1 = t1.Area();
            double areaT2 = t2.Area();

            Console.WriteLine(areaT1);
            Console.WriteLine(areaT2);

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do Produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: " + p);
        }
    }
}