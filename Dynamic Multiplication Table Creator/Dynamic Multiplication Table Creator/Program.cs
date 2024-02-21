using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Multiplication_Table_Creator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r");
            Console.WriteLine("Where will the table start from?");
            int S_table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table start from : " + S_table);
            Console.WriteLine("==========================");
            Console.WriteLine("\r");

            Console.WriteLine("Where will the table end?");
            int E_table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table Ends at : " + E_table);
            Console.WriteLine("==========================");
            Console.WriteLine("\r");

            Console.WriteLine("Where will the limit start from?");
            int S_limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Limit start from : " + S_limit);
            Console.WriteLine("==========================");
            Console.WriteLine("\r");

            Console.WriteLine("Where will the limit end?");
            int E_limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Limit ends at : " + E_limit);
            Console.WriteLine("==========================");
            Console.WriteLine("\r");

            for (int i = S_table; i <= E_table; i++)
            {
                for (int j = S_limit; j <= E_limit; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                }
                Console.WriteLine("==========================");
                Console.WriteLine("\r");
            }
            Console.ReadKey();
        }
    }
}
