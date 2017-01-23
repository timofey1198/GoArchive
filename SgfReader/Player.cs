using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SgfReader
{
    class Player
    {
        public Player(string name, string rating, string color)
        {
            Name = name;
            Rating = rating;
            Color = color;
        }

        public string Name { get; set; }
        public string Rating { get; set; } // [1;30]k, [1;9]d, [1;9]p
        public string Color { get; set; }
    }
}
