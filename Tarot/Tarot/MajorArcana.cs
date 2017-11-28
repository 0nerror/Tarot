using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    // Major Arcana extends Cards
    class MajorArcana : Cards
    {
        public int i;
        // the Major Arcana Description
        string MajArcDesc = "The Major Arcana Chart's the soul's journey through life - The big archetypal themes of life to help you evolve. The larger lessons in life. ";
        // override to set the Arcana to Major
        public override string Arcana
        {
            get { return "Major Arcana"; }
            set { }
        }

        // Constructor to display the information after assignment.
        public MajorArcana(int i)
        {
            // use the passed int i to detemrine which of the 22 options to display 
            int caseSwitch = i;
            
            switch (caseSwitch)
            {
                case 0:
                    FaceName = "Fool";
                    // Meaning = ""; 
                    // Past = ""; 
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 1:
                    FaceName = "Magician";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 2:
                    FaceName = "Priestess";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 3:
                    FaceName = "Empress";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 4:
                    FaceName = "Emperor";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 5:
                    FaceName = "Priest";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 6:
                    FaceName = "Lovers";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 7:
                    FaceName = "Chariot";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 8:
                    FaceName = "Hermit";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 9:
                    FaceName = "Wheel";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 10:
                    FaceName = "Strength";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 11:
                    FaceName = "Justice";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 12:
                    FaceName = "Hanged Man";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 13:
                    FaceName = "Death";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 14:
                    FaceName = "Temperance";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 15:
                    FaceName = "Devil";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 16:
                    FaceName = "Tower";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 17:
                    FaceName = "Star";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 18:
                    FaceName = "Moon";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 19:
                    FaceName = "Sun";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 20:
                    FaceName = "Judgement";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                case 21:
                    FaceName = "World";
                    // Past = "";
                    // Present = "";
                    // Future = "";
                    // Decision = "";
                    // Timing = "";
                    break;
                default:
                    break;
            }

            Console.WriteLine("Arcana: {0}", Arcana);
            Console.WriteLine("Arcana Desc: \n {0}", MajArcDesc);
            Console.WriteLine("Card: The {0}", FaceName);
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
   


