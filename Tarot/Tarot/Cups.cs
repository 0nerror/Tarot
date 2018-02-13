using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    class Cups : MinorArcana
    {
        public int i;
        string Element = "Water";
        string Zodiac =  "Pisces, Cancer, Scorpio" ; 
        string Associated = "Emotions";

        // Determine which card we pulled
        public Cups(int i)
        {
            int caseSwitch = i;

            switch (caseSwitch)
            {
                case 22:
                    FaceName = "One of Cups";
                    break;
                case 23:
                    FaceName = "Two of Cups";
                    break;
                case 24:
                    FaceName = "Three of Cups";
                    break;
                case 25:
                    FaceName = "Four of Cups";
                    break;
                case 26:
                    FaceName = "Five of Cups";
                    break;
                case 27:
                    FaceName = "Six of Cups";
                    break;
                case 28:
                    FaceName = "Seven of Cups";
                    break;
                case 29:
                    FaceName = "Eight of Cups";
                    break;
                case 30:
                    FaceName = "Nine of Cups";
                    break;
                case 31:
                    FaceName = "Ten of Cups";
                    break;
                case 32:
                    FaceName = "Page of Cups";
                    break;
                case 33:
                    FaceName = "Knave of Cups";
                    break;
                case 34:
                    FaceName = "Queen of Cups";
                    break;
                case 35:
                    FaceName = "King of Cups";
                    break;
                default:
                    break;
            }
            // Call the method to display the card information to the console
            DisplayCard card = new DisplayCard(Arcana, ArcDesc, FaceName, Element, Zodiac, Associated, Meaning, Past, Present, Future, Decision, Timing);

        }
    }

    
}
