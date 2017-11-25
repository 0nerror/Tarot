using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    // base class for the cards
    abstract class Cards
    {
        abstract public string FaceName  { get; set; }
        abstract public string Arcana  { get; set; }

        abstract public string Past { get; set; }
        abstract public string Present  { get; set; }
        abstract public string Future  { get; set; }
        // This will result in simply yes or no, if I make it boolean, can I translate true and false to a yes or no answer? 
        abstract public string Decision  { get; set; } // this is a field to obtain a decription for pulling a yes or no answer from the cards
        // Timing may not apply to all 78 cards, this needs to be empty or return a value of none
        abstract public string Timing  { get; set; }



    }
}
