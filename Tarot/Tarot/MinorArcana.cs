using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    // Minor Arcana extends Cards 
    public class MinorArcana : Cards
    {
        public override string Arcana
        {
            get { return "Minor Arcana"; }
            set { }
        }

        public string ArcDesc = "Minor Arcana talks about events, issues and people in our daily lives.";
    }
}
