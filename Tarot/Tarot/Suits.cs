using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    class Suits : MinorArcana
    {
        //enum to assign the name of the suit
        public enum SuitNames
        {
            Wands,
            Cups,
            Swords,
            Pentacles
        }

        public enum PlayCardNames
        {
            Clubs,
            Hearts,
            Spades,
            Diamonds
        }

        string Element { get; set; }
        string[] Zodiac { get; set; }
        string Association { get; set; }

        // need to assign the variables based on the suit

    }
}
