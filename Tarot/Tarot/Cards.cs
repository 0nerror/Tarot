using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    // base class for the cards
    class Cards
    {
        string FaceName { get; set; }
        string Arcana { get; set; }

        string Past { get; set; }
        string Present { get; set; }
        string Future { get; set; }
        string Decision { get; set; } // this is a field to obtain a decription for pulling a yes or no answer from the cards
        string Timing { get; set; }



    }
}
