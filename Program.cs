using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkThirteenNameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char simbol;

            string name;

            Console.Write("Enter the desired character: ");
            simbol = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the desired name: ");
            name = Console.ReadLine();

            string nameSimbol = $"{simbol}{name}{simbol}";
            string simbolOutput = string.Empty;

            for (int i = 0; i < nameSimbol.Length; i++)
            {
                simbolOutput += simbol;
            }
            
            Console.WriteLine(simbolOutput);
            Console.WriteLine(nameSimbol);
            Console.WriteLine(simbolOutput);
            Console.WriteLine('\n');
        }
    }
}
