using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieApiV.Model
{
    public class Cart
    {
        [Display(Name = "Item Code")]
        public string ItemCode { get; set; }
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Mileage")]
        public decimal Price { get; set; }
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        public byte[] ImagePicture { get; set; }
    }

    public class CheckOut
    {
        [Display(Name = "Item Code")]
        public string ItemCode  { get; set; }
        [Display(Name = "Payment Type")]
        public string PaymentType { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Pay Date")]
        public string PayDate{ get; set; }
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Customer")]
        public string Customer { get; set; }
        [Display(Name = "Paid")]
        public string Paid { get; set; }


    }

    public class Payments
    {
        [Display(Name = "Customer Payment Code")]
        public string CustomerPaymentCode { get; set; }
        [Display(Name = "Car Sold Code")]
        public string CarSoldCode { get; set; }
        [Display(Name = "Customer Code")]
        public string CustomerCode { get; set; }
        [Display(Name = "Payment Status Code")]
        public string PaymentStatusCode { get; set; }
        [Display(Name = "Payment Date Due"), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]

        public DateTime PaymentDateDue { get; set; }
        [Display(Name = "Payment Amount")]
        public decimal PaymentAmount { get; set; }

    }
}


