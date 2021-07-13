using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApiV.Model
{
    public class Car
    {
        public string CarCode { get; set; }
        public string ManufactureCode { get; set; }
        public string ModelCode { get; set; }
        public string CatCode { get; set; }
        public decimal Price { get; set; }
        public decimal Mileage { get; set; }
        public DateTime DateAcquired { get; set; }
        public DateTime ReqistationYear { get; set; }
        public string CarDescription { get; set; }
        public string Color { get; set; }
        public byte[] ImagePicture { get; set; }

        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

    }
}
