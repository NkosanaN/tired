using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieApiV.Model
{
    public class StockBal
    {
        public int StockId { get; set; }
        [Display(Name = "Payment Types:")]
        public string PaymentType { get; set; }
        [Display(Name = "Qty")]
        public decimal TotalStockQty { get; set; }
        [Display(Name = "Car Model")]
        public string CarModel { get; set; }
        [Display(Name = "Status")]
        public bool Approve { get; set; }
    }
}
