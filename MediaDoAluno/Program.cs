using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaDoAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média do aluno: ");
            double media = double.Parse(Console.ReadLine());

            Console.WriteLine("Porcentagem de peresença do aluno: ");
            double porc = double.Parse(Console.ReadLine());

            if (media >= 7 && porc >= 75) 
            {
                Console.WriteLine("Aprovado");
            }
            else if (media < 7 && media >= 4 && porc >= 75)
            {
                Console.WriteLine("Recuperação ");
            }

            else if (media >= 7 && porc <= 75)
            {
                Console.WriteLine("Recuperação");
            }
            else if (media < 7 && media >= 4 && porc <= 75)
            {
                Console.WriteLine("Retido");
            }
            else
            {
                Console.WriteLine("Retido");
            }
            Console.ReadKey();


































































































        }
    }
}
