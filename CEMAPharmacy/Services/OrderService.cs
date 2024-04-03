using System;
using CEMAPharmacy.Data;
using CEMAPharmacy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CEMAPharmacy.Services
{
    public class OrderService :IOrderService
    {
        private readonly PharmacyInventoryDbContext _dbContext;

        public OrderService(PharmacyInventoryDbContextdbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _dbContext.Orders.ToListAsync();
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _dbContext.Orders.FindAsync(id);
        }

        public async Task<int> AddOrderAsync(Order order)
        {
            _dbContext.Orders.Add(order);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateOrderAsync(Order order)
        {
            _dbContext.Entry(order).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteOrderAsync(int id)
        {
            var order = await _dbContext.Orders.FindAsync(id);
            _dbContext.Orders.Remove(order);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> CheckStockAsync(int medicineId, int quantity)
        {
            var medicine = await _dbContext.Medicines.FindAsync(medicineId);
            return medicine.Quantity >= quantity;
        }
}
