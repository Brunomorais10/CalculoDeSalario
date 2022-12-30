using System;
using System.Globalization;

namespace Programa1Calculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dados p1 = new Dados();
            Dados p2 = new Dados();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (p1.Salario + p2.Salario) / 2;
            Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
