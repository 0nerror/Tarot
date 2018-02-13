using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    class Swords : MinorArcana
    {
        public int i;
        string Element = "Air";
        string Zodiac = "Gemini, Libra, Aquarius" ;
        string Associated = "Intellectual Activity";

        // Determine which card we pulled
        public Swords(int i)
        {
            int caseSwitch = i;

            switch (caseSwitch)
            {
                case 36:
                    FaceName = "One of Swords";
                    break;
                case 37:
                    FaceName = "Two of Swords";
                    break;
                case 38:
                    FaceName = "Three of Swords";
                    break;
                case 39:
                    FaceName = "Four of Swords";
                    break;
                case 40:
                    FaceName = "Five of Swords";
                    break;
                case 41:
                    FaceName = "Six of Swords";
                    break;
                case 42:
                    FaceName = "Seven of Swords";
                    break;
                case 43:
                    FaceName = "Eight of Swords";
                    break;
                case 44:
                    FaceName = "Nine of Swords";
                    break;
                case 45:
                    FaceName = "Ten of Swords";
                    break;
                case 46:
                    FaceName = "Page of Swords";
                    break;
                case 47:
                    FaceName = "Knave of Swords";
                    break;
                case 48:
                    FaceName = "Queen of Swords";
                    break;
                case 49:
                    FaceName = "King of Swords";
                    break;
                default:
                    break;

            }
            // Call the method to display the card information to the console
            DisplayCard card = new DisplayCard(Arcana, ArcDesc, FaceName, Element, Zodiac, Associated, Meaning, Past, Present, Future, Decision, Timing);

        }
    }
}
