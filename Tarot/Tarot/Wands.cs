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
        string FaceName;
        string Element = "Fire";
        string[] Zodiac = { "Leo", "Aries", "Sagittarius" };
        string Associated = "Career";


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

            Console.WriteLine("Card: {0}", FaceName);
            Console.WriteLine("Arcana: {0}", Arcana);
            Console.WriteLine("Arcana Desc: {0}", MinorArcDesc);
            Console.WriteLine("Element: {0}", Element);
            Console.WriteLine("Zodiac: {0}", Zodiac);
            Console.WriteLine("Associated with: {0}", Associated);
            Console.WriteLine("Past: {0}", Past);
            Console.WriteLine("Present: {0}", Present);
            Console.WriteLine("Future: {0}", Future);
            Console.WriteLine("Decision: {0}", Decision);
            Console.WriteLine("Timing: {0}", Timing);
            Console.WriteLine("");
        }
    }
}
