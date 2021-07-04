using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApiV.Model
{
    public class Car
    {
        public int CarId { get; set; }
        public string Make { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public decimal Mileage { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
       
        public byte[] ImagePicture { get; set; }
    }
}
