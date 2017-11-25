using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarot
{
    class DisplayCard
    {
        public void AllCards()
        {
            // a method to loop int values 0-77 and call the Show Card method
            for (int i = 0; i < 78; i++)
            {
                ShowCard(i);
            }

        }

        public void ShowCardPicked()
        {

            Console.WriteLine("Please enter a number between 0 and 77");
            int i = Convert.ToInt32(Console.ReadLine()); 
            ShowCard(i);

        }

        public void ShowRandomCard()
        {
            Random rnd = new Random();
            //Method to show a random card
            int drawAny = rnd.Next(77); // create a random number between 0 and 77 
            int i = drawAny;
            if (drawAny < 22)
            {
                ShowRandomMajor();
            }
            else
            {
                ShowRandomMinor();
            }

        }

        public void ShowRandomMajor()
        {
            Random rnd = new Random();
            // Method to show a radom card from the Major Arcana
            int drawMajor = rnd.Next(21); // create a random number between 0 and 21
            int i = drawMajor;
            ShowCard(i);
        }

        public void ShowRandomMinor()
        {
            Random rnd = new Random();
            //Method to show a random card from the Minor Arcana
            int drawMinor = rnd.Next(22, 77); // create a random number between 22 and 77
            int i = drawMinor;
            ShowCard(i);
        }

        public void ShowCard(int i)
        {
            // method to display the cards information 
            
            if (i < 21)
            {
                // call the display method for Major Arcana
                MajorArcana flip = new MajorArcana(i);
            }
            else if  (i >=22 && i < 36)
            {
                // call cups method to display card info
                Cups flip = new Cups(i);
            }
            else if (i >= 36 && i < 50)
            {
                // call swords display method
                Swords flip = new Swords(i);
            }
            else if (i >= 50 && i < 64)
            {
                // call wands display method
                Wands flip = new Wands(i);
            }
            else if (i >= 64 && i <78)
            {
                // call pentacle display method
                Pentacles flip = new Pentacles(i);
            }
            else
            {
                Console.WriteLine("Your card selection is not in the Tarot Deck. Please make a selection between 0 and 77");
            }
        }
    }
}
