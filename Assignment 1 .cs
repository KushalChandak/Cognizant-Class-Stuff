using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electricity
{
    class electo
    {

        int range;

        public int perrange
        {
            get
            {
                return range;
            }

            set
            {
                range = value;
            }
        }
    }

    class Elect{

        Elect(int range) {

            Console.WriteLine("Enter Unit");
            

        }




    }
    class program
    {
        int ch;
        static void Main(string[] args)
        {
            int ch;
            Console.WriteLine("BILLING UNIT ");
            electo ec = new electricity.electo();
            do
            {
                

                Console.Write("enter the total units consume \n");
                ec.perrange = Convert.ToInt32(Console.ReadLine());



                switch (ec.perrange)
                {
                    case int n when (ec.perrange <= 500):
                        Console.WriteLine("domestic consumption" + (0.75 * ec.perrange));
                        Console.WriteLine("commercial consumption" + (0.75 * 0.20 * ec.perrange));
                        break;

                    case int n when (ec.perrange >= 501) && (ec.perrange <= 1000):
                        Console.WriteLine("domestic consumption" + (2.35 * ec.perrange));
                        Console.WriteLine("commercial consumption" + (2.35 * 0.20 * ec.perrange));
                        break;

                    case int n when (ec.perrange >= 1001) && (ec.perrange <= 1500):
                        Console.WriteLine("domestic consumption" + (3.05 * ec.perrange));
                        Console.WriteLine("commercial consumption" + (3.05 * 0.20 * ec.perrange));
                        break;

                    case int n when (ec.perrange >= 1501) && (ec.perrange <= 2000):
                        Console.WriteLine("domestic consumption" + (4.00 * ec.perrange));
                        Console.WriteLine("commercial consumption" + (4.00 * 0.20 * ec.perrange));
                        break;


                    case int n when (ec.perrange >= 2001):
                        Console.WriteLine("domestic consumption" + (5.15 * ec.perrange));
                        Console.WriteLine("commercial consumption" + (5.15 * 0.20 * ec.perrange));
                        break;

                    default:
                        break;

                }

                Console.WriteLine("do you want to continue true/false");
                ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
            } while (ch == 1);
            Console.ReadKey();
        }
    }
}

