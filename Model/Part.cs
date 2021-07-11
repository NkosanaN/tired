using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApiV.Model
{
    public class Part
    {
        public string PartCode { get; set; }
        public string PartName { get; set; }
        public decimal Price { get; set; }
        public string Manufacture { get; set; }
        public DateTime Year { get; set; }
        public string Model { get; set; }

    }
}
