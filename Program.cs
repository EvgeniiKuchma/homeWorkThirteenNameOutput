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
            int maxRangeString = 1;

            char simbol;

            string name;

            Console.Write("Enter the desired character: ");
            simbol = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the desired name: ");
            name = Console.ReadLine();

            for (int i = 0; i <= name.Length + maxRangeString; i++)
            {
                Console.Write(simbol);

                if (i == name.Length + maxRangeString)
                {
                    Console.WriteLine($"\n{simbol}{name}{simbol}");

                    for (int j = 0; j <= name.Length + maxRangeString; j++)
                    {
                        Console.Write(simbol);
                    }
                }
            }

            Console.WriteLine('\n');
        }
    }
}
