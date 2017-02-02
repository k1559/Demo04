using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();
            hissi.Kerros = 1;
            do
            {
                Console.WriteLine("Olet nyt kerroksessa: " + hissi.Kerros);
                Console.WriteLine("Mihin kerrokseen haluat?");
                hissi.Kerros = int.Parse(Console.ReadLine());
            } while (hissi.Kerros!=0);
        
        }
    }
}
