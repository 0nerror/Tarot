using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    class Wands : MinorArcana
    {
        public int i;
        string Element = "Fire";
        string Zodiac =  "Leo, Aries, Sagittarius" ;
        string Associated = "Career";

        // Determine which card we pulled
        public Wands(int i)
        {
            int caseSwitch = i;

            switch (caseSwitch)
            {
                case 50:
                    FaceName = "One of Wands";
                    break;
                case 51:
                    FaceName = "Two of Wands";
                    break;
                case 52:
                    FaceName = "Three of Wands";
                    break;
                case 53:
                    FaceName = "Four of Wands";
                    break;
                case 54:
                    FaceName = "Five of Wands";
                    break;
                case 55:
                    FaceName = "Six of Wands";
                    break;
                case 56:
                    FaceName = "Seven of Wands";
                    break;
                case 57:
                    FaceName = "Eight of Wands";
                    break;
                case 58:
                    FaceName = "Nine of Wands";
                    break;
                case 59:
                    FaceName = "Ten of Wands";
                    break;
                case 60:
                    FaceName = "Page of Wands";
                    break;
                case 61:
                    FaceName = "Knave of Wands";
                    break;
                case 62:
                    FaceName = "Queen of Wands";
                    break;
                case 63:
                    FaceName = "King of Wands";
                    break;
                default:
                    break;
            }
            // Call the method to display the card information to the console
            DisplayCard card = new DisplayCard(Arcana, ArcDesc, FaceName, Element, Zodiac, Associated, Meaning, Past, Present, Future, Decision, Timing);
        }
    }
}
