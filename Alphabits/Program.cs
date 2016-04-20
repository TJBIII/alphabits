using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
    class Program
    {
        static void Main(string[] args)
        {
            Alpha alpha = new Alpha();

            var complete = false;

            while (!complete)
            {
                Console.WriteLine("Enter the next letter in the alphabet \n");
                var s = Console.ReadKey().KeyChar;
                Console.Clear();
                //Console.WriteLine(s);
                //Console.ReadKey();
                alpha.addChar(s);
               
               
                if (alpha.listLength() - 1== 26)
                {
                    complete = true;
                }
            }

            Console.Clear();
            Console.Write("CONGRATS! YOU DID IT!!!");
            Console.ReadKey();

        }
    }
}
