using HospitalProject.Domain.Model;
using HospitalProject.Service.Dtos;
using HospitalProject.Service.Interface.Repository;
using HospitalProject.Service.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Service.Implementation.Services
{
    public class BillService : IBillService
    {
        private readonly IBillRepository _billRepository;

        public BillService(IBillRepository billRepository)
        {
            _billRepository = billRepository;
        }

        public void Add(Bill entity)
        {
            _billRepository.Add(entity);
        }

        public void Delete(int Id)
        {
            try
            {
                var bill = _billRepository.GetBillbyId(Id);
                _billRepository.Remove(bill);
            }
            catch
            {
                throw;
            }
           

        }

        public IQueryable<BillDto> GetAll()
        {
            var bills= _billRepository.GetAll();
            return bills.Select(x => new BillDto
            {
                Id = x.Id,
                DoctorCharge = x.DoctorCharge,
                RoomCharge = x.RoomCharge,
                LabCharge = x.LabCharge,
                NumberofDays = x.NumberofDays,
                Patient = x.Patient
            }).AsQueryable();
        }

        public BillDto GetBill(int Id)
        {
            var bill = _billRepository.GetBillbyId(Id);
            return new BillDto
            {
                Patient = bill.Patient,
                RoomCharge = bill.RoomCharge,
                LabCharge = bill.LabCharge,
                DoctorCharge = bill.DoctorCharge
            };
        }

        public void Update(BillDto billDto)
        {
            try
            {
                var bill = GetBill(billDto.Id);
                bill.Patient = billDto.Patient;
                bill.RoomCharge = billDto.RoomCharge;
                bill.NumberofDays = billDto.NumberofDays;
                bill.LabCharge = billDto.LabCharge;
                bill.DoctorCharge = billDto.DoctorCharge;

            }
            catch
            {
                throw;
            }
        }
    }
}
