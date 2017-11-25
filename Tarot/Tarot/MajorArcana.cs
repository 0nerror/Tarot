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
        // Enum for the names of the Cards in the Major Arcana of the Tarot
        public enum Faces
        {
            Fool,
            Magician,
            Priestess,
            Empress,
            Emperor,
            Priest,
            Lovers,
            Chariot,
            Hermit,
            Wheel,
            Strength,
            Justice,
            HangedMan,
            Death,
            Temperance,
            Devil,
            Tower,
            Star,
            Moon,
            Sun,
            Judgement,
            World
        }
        // override to set the Arcana to Major
        public override string Arcana
        {
            get { return "Major Arcana"; }
            set { }
        }

        public override string Decision { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string FaceName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Future { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Past { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Present { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Timing { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Display()
        {
            // to pull just the Major Arcana Description
            string MajArcDesc = "The Major Arcana Chart's the soul's journey through life - The big archetypal themes of life to help you evolve. The larger lessons in life. ";
            Console.WriteLine(MajArcDesc);
        }





    }
}
