using System;
using CEMAPharmacy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMAPharmacy.Services
{
    public class DeliveryService : IDeliveryService
    {
        public async Task<bool> DeliverOrderAsync(Order order)
        {
            // Implement delivery functionality here
            return true;
        }
    }
}
