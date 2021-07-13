using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieApiV.Model
{
    public class Bookings
    {
        public int CustomerId { get; set; }
        [Display(Name = "Car Name")]
        public string TestingCarName { get; set; }
        [Display(Name = "Customer Name")]

        public string CustName { get; set; }

        [Display(Name = "Reserve Date")]
        public DateTime Revdate { get; set; }
        [Display(Name = "Status")]
        public bool hasCome { get; set; }
    }
}
