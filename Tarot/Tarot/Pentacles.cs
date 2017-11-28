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
        string[] Zodiac = { "Taurus", "Capricorn", "Virgo" };
        string Associated = "Finance and material items";

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

            Console.WriteLine("Card: {0}", FaceName);
            Console.WriteLine("Arcana: {0}", Arcana);
            Console.WriteLine("Arcana Desc: \n {0}", MinorArcDesc);
            Console.WriteLine("Element: {0}", Element);
            Console.WriteLine("Zodiac: {0}", Zodiac);
            Console.WriteLine("Associated with: {0}", Associated);
            Console.WriteLine("General Meaning: \n {0}", Meaning);
            Console.WriteLine("Past: {0}", Past);
            Console.WriteLine("Present: {0}", Present);
            Console.WriteLine("Future: {0}", Future);
            Console.WriteLine("Decision: {0}", Decision);
            Console.WriteLine("Timing: {0}", Timing);
            Console.WriteLine("");

        }
    }
}
