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
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public void Add(Doctor entity)
        {
            _doctorRepository.Add(entity);
        }

        public void Delete(int Id)
        {
            var doctor = GetDoctor(Id);
             _doctorRepository.Remove(doctor);
        }

        public IQueryable<DoctorDto> GetAll()
        {
           throw new NotImplementedException();
        }

        public DoctorDto GetDoctor(int Id)
        {
            throw new NotImplementedException();

        }

        public void Update(DoctorDto doctorDto)
        {
            throw new NotImplementedException();
        }

        Doctor IDoctorService.GetDoctor(int Id)
        {
            throw new NotImplementedException();
        }
    }
}