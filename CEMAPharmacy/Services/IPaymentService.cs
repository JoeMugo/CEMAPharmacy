using System;
using CEMAPharmacy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMAPharmacy.Services
{
    public interface IPaymentService
    {
        Task<bool> MakePaymentAsync(Order order);
    }
}
