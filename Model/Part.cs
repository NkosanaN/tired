using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApiV.Model
{
    public class Part
    {
        public int PartId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Manufacture { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }

    }
}
