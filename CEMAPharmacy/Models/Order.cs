using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMAPharmacy.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Medicine Medicine { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentMethod { get; set; }
        public string DeliveryMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsDelivered { get; set; }
    }
}
