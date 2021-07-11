using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApiV.Model
{
    public class Cart
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class CheckOut
    {
        public string CarSoldCode { get; set; }
        public string CarCode { get; set; }
        public string CustomerCode { get; set; }
        public decimal AgreedPrice { get; set; }
        public DateTime DateSold { get; set; }
        public decimal MonthlyPaymentAmount { get; set; }
        public DateTime MonthlyPaymentDate { get; set; }
        public string Details { get; set; }

    }

    public class Payments
    {
        public string CustomerPaymentCode { get; set; }
        public string CarSoldCode { get; set; }
        public string CustomerCode { get; set; }
        public string PaymentStatusCode { get; set; }
        public DateTime PaymentDateDue { get; set; }
       
        public decimal PaymentAmount { get; set; }

    }
}


