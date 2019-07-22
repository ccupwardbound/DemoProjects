using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeObjects
{
    class ItemInfo
    {
        public string Name { get; set; }
        public Dimension Dimension { get; set; }
        public ItemColor Color { get; set; }
    }

    class Dimension
    {
        public float Height { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
    }

    class ItemColor
    {
        public int Red { get; set; }
        public int Blue { get; set; }
        public int Green { get; set; }
    }
}
