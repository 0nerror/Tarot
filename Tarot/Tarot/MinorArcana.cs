using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarot
{
    // Minor Arcana extends Cards 
    class MinorArcana : Cards
    {
        //enum for the names of the cards in the Minor Arcana
        public enum Faces
        {
            One = 1,
            Two =2,
            Three =3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven= 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Page = 11,
            Knave = 12,
            Queen = 13,
            King = 14
        }

        public override string FaceName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Arcana
        {
            get { return "Minor Arcana"; }
            set { }
        }
        public override string Past { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Present { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Future { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Decision { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Timing { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string MinorArcDesc = "The Minor Arcana talks about events, issues and people in our daily lives.";
    }
}
