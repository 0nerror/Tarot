using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Tarot Cards and their meanings");
            // need to add some code to have the program do something

            // This is duplicated in Menu, I want to call the method to display this rather than leave it here.

            Console.WriteLine("1. Any Card at Random."); // call ShowRandomCard
            Console.WriteLine("2. A Random Major Arcana card."); // call ShowRandomMajor
            Console.WriteLine("3. A Random Minor Arcana Card."); // Call ShowRaondomMinor
            Console.WriteLine("4. A specific card from the Tarot.");// CallShowCardPicked 
            Console.WriteLine("5. Display the information for all 78 cards in order."); // Call AllCards
            Console.WriteLine("6. Exit the program");


            // Need to add validation if the selection is somthing other than 1-6
            //Console.ReadLine();
            int caseSwitch = Convert.ToInt32(Console.ReadLine()); ;
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
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Have a Great day!");

            }

            /*/ need to add a loop to call the menu again in the event the user wants to select another card
            Console.WriteLine("Would you like to select again? Enter Y for yes or N for no");
            string answer = Console.ReadLine();
            answer.ToLower();
            if ()
            {
                // Call the menu again
            }
            else
            {
                Console.WriteLine("Have a Great day!");
            }

            */


            Console.ReadLine();


        }

    }
}
