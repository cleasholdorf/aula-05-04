using System;

namespace AULA_05_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //47 9 9167 2505
            string numero = Console.ReadLine();
            string telefone = '(' + numero.Substring(0, 2) +
            ')' + numero.Substring(2, 1)+ " " + numero.Substring(3, 4) + "-" +
            numero.Substring(7, 4);
            Console.WriteLine(telefone);
        }
    }
}
