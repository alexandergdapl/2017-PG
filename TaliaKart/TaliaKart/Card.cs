using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaliaKart
{
    class Card
    {
        public int Value;
        public string Color;

        public Card(int value,string color)
        {
            Value = value;
            Color = color;
        }
        public string Description()
        {
            return Value.ToString() + " " + Color;
        }


        
        

    }
}
