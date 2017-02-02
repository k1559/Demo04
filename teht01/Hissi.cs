using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Hissi
    {
        private readonly int maxKerros = 5;
        private readonly int minimiKerros = 1;
        private int kerros;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                if (value <= maxKerros & value >= minimiKerros) kerros = value;
                else
                {
                    Console.WriteLine("Kerroksia on vain viisi!");


                }
            }
        }
    }
}
