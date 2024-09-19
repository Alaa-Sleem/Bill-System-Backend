﻿namespace Bill_system_API.Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public double SellingPrice { get; set; }
        public double TotalValue { get; set; }
        public double Quantity { get; set; }
        public double Discount { get; set; }
        public virtual Invoice? Invoice { get; set; }
        public virtual Item? item { get; set; }
    }
}
