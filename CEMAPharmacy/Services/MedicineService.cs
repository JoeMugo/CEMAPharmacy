using System;
using CEMAPharmacy.Models;
using CEMAPharmacy.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CEMAPharmacy.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly PharmacyInventoryDbContext _dbContext;

        public MedicineService(PharmacyInventoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Medicine>> GetAllMedicinesAsync()
        {
            return await _dbContext.Medicines.ToListAsync();
        }

        public async Task<Medicine> GetMedicineByIdAsync(int id)
        {
            return await _dbContext.Medicines.FindAsync(id);
        }

        public async Task<int> AddMedicineAsync(Medicine medicine)
        {
            _dbContext.Medicines.Add(medicine);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateMedicineAsync(Medicine medicine)
        {
            _dbContext.Entry(medicine).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteMedicineAsync(int id)
        {
            var medicine = await _dbContext.Medicines.FindAsync(id);
            _dbContext.Medicines.Remove(medicine);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
