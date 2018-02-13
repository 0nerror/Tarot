using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    // base class for the cards
    abstract public class Cards
    {
        abstract public string Arcana  { get; set; }
        public string FaceName { get; set; }
        public string Past { get; set; }
        public string Present { get; set; }
        public string Future { get; set; }
        public string Decision { get; set; }
        public string Timing { get; set; }
        public string Meaning { get; set; }
    }
}
