using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieApiV.Model
{
    public class Car
    {
        [Display(Name = "Car Code")]
        public string CarCode { get; set; }
        [Display(Name = "Manufacture Code")]
        public string ManufactureCode { get; set; }
        [Display(Name = "Model Code")]
        public string ModelCode { get; set; }
        [Display(Name = "Cartegory ")]
        public string CatCode { get; set; }
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Display(Name = "Mileage")]
        public decimal Mileage { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date Acquired")]
        public DateTime DateAcquired { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Registration Year")]
        public DateTime ReqistationYear { get; set; }
        [Display(Name = "Description")]
        public string CarDescription { get; set; }
        [Display(Name = "Color")]
        public string Color { get; set; }
        [Display(Name = "Picture")]
        public byte[] ImagePicture { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

    }
}
