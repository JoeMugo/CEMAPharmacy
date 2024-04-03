using System;
using CEMAPharmacy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMAPharmacy.Services
{
    public class PaymentService : IPaymentService
    {
        public async Task<bool> MakePaymentAsync(Order order)
        {
            // Implement payment gateway integration here
            return true;
        }
    }
}
