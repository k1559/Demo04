using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Vahvistin
    {
        private readonly int maxVolume = 100;
        private readonly int minVolume = 0;
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= maxVolume)
                {
                    Console.WriteLine("Musiikki on liian kovalla! Asetetaan musiikki maksimiin 100");
                    volume = maxVolume;
                }
                else if (value <= minVolume)
                {
                    Console.WriteLine("Musiikki on liian hiljaisella! Asetetaan musiikki minimiin 0");
                    volume = minVolume;
                }
                else volume = value;


            }
        }
    }
}
