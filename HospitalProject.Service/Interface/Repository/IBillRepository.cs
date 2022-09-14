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
       Bill GetBillbyId(int id);
        void Add(Bill entity);
        void Update(Bill bill);
        void Remove(int id);
    }
}
