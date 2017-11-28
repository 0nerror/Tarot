using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    class Menu
    {
        public void MenuOptions()
        {
            Console.WriteLine("1. Any Card at Random."); // call ShowRandomCard
            Console.WriteLine("2. A Random Major Arcana card."); // call ShowRandomMajor
            Console.WriteLine("3. A Random Minor Arcana Card."); // Call ShowRaondomMinor
            Console.WriteLine("4. A specific card from the Tarot.");// CallShowCardPicked 
            Console.WriteLine("5. Display the information for all 78 cards in order."); // Call AllCards
            Console.WriteLine("6. Exit the program");
            // get the input from the user and convert to int
            int caseSwitch = Convert.ToInt32(Console.ReadLine()); ;
            // call the correct method based on the user's selection
            if (caseSwitch != 6)
            {
                DisplayCard card = new DisplayCard();

                switch (caseSwitch)
                {
                    case 1:
                        card.ShowRandomCard();
                        break;
                    case 2:
                        card.ShowRandomMajor();
                        break;
                    case 3:
                        card.ShowRandomMinor();
                        break;
                    case 4:
                        card.ShowCardPicked();
                        break;
                    case 5:
                        card.AllCards();
                        break;
                    //case 6:
                    //  Console.WriteLine("Press enter to exit.");
                    //Console.ReadLine();
                    // break;
                    default:
                        Console.WriteLine("Please make a selection from the Menu");
                        break;
                }
}
            else
            {
                Console.WriteLine("Have a great day!");
            }
          

        }
    }
}
