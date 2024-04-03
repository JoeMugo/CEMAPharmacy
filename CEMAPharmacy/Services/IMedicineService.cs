using System;
using CEMAPharmacy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMAPharmacy.Services
{
    public interface IMedicineService
    {
        Task<List<Medicine>> GetAllMedicinesAsync();
        Task<Medicine> GetMedicineByIdAsync(int id);
        Task<int> AddMedicineAsync(Medicine medicine);
        Task<int> UpdateMedicineAsync(Medicine medicine);
        Task<int> DeleteMedicineAsync(int id);
    }
}
