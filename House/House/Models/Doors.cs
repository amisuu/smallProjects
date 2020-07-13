using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace House.Models
{
    public class Doors
    {
        Random rand = new Random();
        public int Size { get; set; }
        public Doors(int size)
        {
            Size = size;
        }

        public string Color 
        {
            get { return Color; }
            set { Color = ($"RGB Color: {rand.Next(256)}, {rand.Next(256)}, {rand.Next(256)}"); }
        }
    }
}
