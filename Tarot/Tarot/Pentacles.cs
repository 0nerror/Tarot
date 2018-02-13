using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    class Pentacles : MinorArcana
    {
        public int i;
        string Element = "Earth";
        string Zodiac =  "Taurus, Capricorn, Virgo" ;
        string Associated = "Finance and material items";

        // Determine which card we pulled
        public Pentacles(int i)
        {
            int caseSwitch = i;

            switch (caseSwitch)
            {
                case 64:
                    FaceName = "One of Pentacles";
                    break;
                case 65:
                    FaceName = "Two of Pentacles";
                    break;
                case 66:
                    FaceName = "Three of Pentacles";
                    break;
                case 67:
                    FaceName = "Four of Pentacles";
                    break;
                case 68:
                    FaceName = "Five of Pentacles";
                    break;
                case 69:
                    FaceName = "Six of Pentacles";
                    break;
                case 70:
                    FaceName = "Seven of Pentacles";
                    break;
                case 71:
                    FaceName = "Eight of Pentacles";
                    break;
                case 72:
                    FaceName = "Nine of Pentacles";
                    break;
                case 73:
                    FaceName = "Ten of Pentacles";
                    break;
                case 74:
                    FaceName = "Page of Pentacles";
                    break;
                case 75:
                    FaceName = "Knave of Pentacles";
                    break;
                case 76:
                    FaceName = "Queen of Pentacles";
                    break;
                case 77:
                    FaceName = "King of Pentacles";
                    break;
                default:
                    break;
            }
            // Call the method to display the card information to the console
            DisplayCard card = new DisplayCard(Arcana, ArcDesc, FaceName, Element, Zodiac, Associated, Meaning, Past, Present, Future, Decision, Timing);

        }
    }
}
