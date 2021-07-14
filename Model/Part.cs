using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieApiV.Model
{
    public class Part
    {
        [Display(Name = "Part Code")]
        public string PartCode { get; set; }
        [Display(Name = "Part Name")]
        public string PartName { get; set; }
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Display(Name = "Manufacture")]
        public string Manufacture { get; set; }
        [Display(Name = "Year")]
        [DataType(DataType.Date)]
        public DateTime Year { get; set; }
        [Display(Name = "Model")]
        public string Model { get; set; }

        public byte[] ImagePicture { get; set; }

        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

    }
}
