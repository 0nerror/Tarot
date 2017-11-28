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
        string FaceName;
        string Element = "Water";
        string[] Zodiac = { "Pisces", "Cancer", "Scorpio" }; 
        string Associated = "Emotions";


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
