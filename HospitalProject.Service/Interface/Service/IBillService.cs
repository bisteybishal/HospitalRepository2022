using HospitalProject.Domain.Model;
using HospitalProject.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Service.Interface.Service
{
   public interface IBillService
    {
        IQueryable<BillDto> GetAll();
        BillDto GetBill(int Id);
        void Add(Bill entity);
        void Update(BillDto billDto);
        void Delete(int Id);
    }
}
