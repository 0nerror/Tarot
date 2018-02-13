using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    class DisplayCard
    {
        // all of the possible variables for either type of card
        private string arcana;
        private string arcDesc;
        private string faceName;
        private string element;
        private string zodiac;
        private string associated;
        private string meaning;
        private string past;
        private string present;
        private string future;
        private string decision;
        private string timing;

        // displays the Major card
        public DisplayCard(string arcana, string arcDesc, string faceName, string meaning, string past, string present, string future, string decision, string timing)
        {
            this.arcana = arcana;
            this.arcDesc = arcDesc;
            this.faceName = faceName;
            this.meaning = meaning;
            this.past = past;
            this.present = present;
            this.future = future;
            this.decision = decision;
            this.timing = timing;

            Console.WriteLine("Arcana: {0}", arcana);
            Console.WriteLine("Arcana Desc:  \n {0}", arcDesc);
            Console.WriteLine("Card: {0}", faceName);
            Console.WriteLine("");
            Console.WriteLine("General Meaning: \n {0}", meaning);
            Console.WriteLine("Past: \n {0}", past);
            Console.WriteLine("Present: \n {0}", present);
            Console.WriteLine("Future: \n {0}", future);
            Console.WriteLine("Decision: \n {0}", decision);
            Console.WriteLine("Timing: \n {0}", timing);
            Console.WriteLine("");

        }
        // Displays the minor card
        public DisplayCard(string arcana, string arcDesc, string faceName, string element, string zodiac, string associated, string meaning, string past, string present, string future, string decision, string timing)
        {
            this.arcana = arcana;
            this.arcDesc = arcDesc;
            this.faceName = faceName;
            this.element = element;
            this.zodiac = zodiac;
            this.associated = associated;
            this.meaning = meaning;
            this.past = past;
            this.present = present;
            this.future = future;
            this.decision = decision;
            this.timing = timing;

            Console.WriteLine("Arcana: {0}", arcana);
            Console.WriteLine("Arcana Desc:  \n {0}", arcDesc);
            Console.WriteLine("Card: {0}", faceName);
            Console.WriteLine("");
            Console.WriteLine("Element: {0}", element);
            Console.WriteLine("Zodiac: {0}", zodiac);
            Console.WriteLine("Associated with: {0}", associated);
            Console.WriteLine("");
            Console.WriteLine("General Meaning: \n {0}", meaning);
            Console.WriteLine("Past: \n {0}", past);
            Console.WriteLine("Present: \n {0}", present);
            Console.WriteLine("Future: \n {0}", future);
            Console.WriteLine("Decision: \n {0}", decision);
            Console.WriteLine("Timing: \n {0}", timing);
            Console.WriteLine("");
        }

    }
}
