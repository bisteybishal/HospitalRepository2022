using HospitalProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Service.Interface.Repository
{
    public interface IBillRepository
    {
        IQueryable<Bill> GetAll();
        Bill GetBillbyId(int billId);
        void Add(Bill entity);
        void Update(Bill bill);
        void Remove(Bill bill);
    }
}
