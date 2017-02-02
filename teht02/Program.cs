using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
           
                Vahvistin vahvistin = new Vahvistin();
            vahvistin.Volume = 0;
            do { 
                Console.WriteLine("Anna vahvistimelle voimakkuus 0-100");
                vahvistin.Volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Äänenvoimakkuus on asetettu kohtaan: " + vahvistin.Volume);
            } while(vahvistin.Volume != 0);
        }
        
    }
}
