using System;

namespace Training.AspNetCore.Database.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string BillingAddress { get; set; }
        public bool Book1 { get; set; }
        public bool Book2 { get; set; }
        public bool Book3 { get; set; }
        public DateTime TimeReceived { get; set; }
    }
}
