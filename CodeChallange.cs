using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Number :");
            
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t");

            Console.WriteLine("\t{0}{0}{0} \n", n);
            Console.WriteLine("\t{0}{0} \n", n);
            Console.WriteLine("\t{0}{0}\n", n);
            Console.WriteLine("\t{0}{0}\n", n);
            Console.WriteLine("\t{0}{0}{0}\n", n);


            Console.ReadKey();


        }
    }
}
