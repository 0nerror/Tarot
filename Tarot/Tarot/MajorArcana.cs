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
        string ArcDesc = "The Major Arcana Chart's the soul's journey through life; the big archetypal \n themes of life to help you evolve. The larger lessons in life. ";
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
                     Meaning = ""; 
                     Past = ""; 
                     Present = "";
                     Future = "";
                     Decision = "";
                     Timing = "";
                    break;
                case 1:
                    FaceName = "Magician";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 2:
                    FaceName = "Priestess";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 3:
                    FaceName = "Empress";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 4:
                    FaceName = "Emperor";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 5:
                    FaceName = "Priest";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 6:
                    FaceName = "Lovers";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 7:
                    FaceName = "Chariot";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 8:
                    FaceName = "Hermit";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 9:
                    FaceName = "Wheel";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 10:
                    FaceName = "Strength";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 11:
                    FaceName = "Justice";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 12:
                    FaceName = "Hanged Man";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 13:
                    FaceName = "Death";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 14:
                    FaceName = "Temperance";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 15:
                    FaceName = "Devil";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 16:
                    FaceName = "Tower";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 17:
                    FaceName = "Star";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 18:
                    FaceName = "Moon";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 19:
                    FaceName = "Sun";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 20:
                    FaceName = "Judgement";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                case 21:
                    FaceName = "World";
                    Meaning = "";
                    Past = "";
                    Present = "";
                    Future = "";
                    Decision = "";
                    Timing = "";
                    break;
                default:
                    break;
            }

            DisplayCard card = new DisplayCard(Arcana, ArcDesc, FaceName, Meaning, Past, Present, Future, Decision, Timing); 


/*
            Console.WriteLine("Arcana: {0}", Arcana);
            Console.WriteLine("Arcana Desc: \n {0}", ArcDesc);
            Console.WriteLine("");
            Console.WriteLine("Card: The {0}", FaceName);
            Console.WriteLine("General Meaning: \n {0}", Meaning);
            Console.WriteLine("Past: {0}", Past);
            Console.WriteLine("Present: {0}", Present);
            Console.WriteLine("Future: {0}", Future);
            Console.WriteLine("Decision: {0}", Decision);
            Console.WriteLine("Timing: {0}", Timing);
            Console.WriteLine("");
*/
        }

    }
}
   


