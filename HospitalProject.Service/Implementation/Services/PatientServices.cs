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
    public class PatientServices : IPatientService
    {
        private readonly IpatientRepository _patientRepository;

        public PatientServices(IpatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public void Add(Patient entity)
        {
            _patientRepository.Add(entity);
            
        }

        public IQueryable<PatientDto> GetAll()
        {
            var patients = _patientRepository.GetAll();
            return patients.Select(x => new PatientDto
            {
               
                Name = x.Name,
                Address = x.Address,
                Age = x.Age,
                Disease = x.Disease

            }).AsQueryable();
        }

        public Patient GetPatient(int patientId)
        {
            return _patientRepository.GetPatient(patientId).FirstorDefault();
        }

        public void Update(PatientDto patientDto)
        {
            try
            {
                var patient = GetPatient(patientDto.Id);
                patient.Name = patientDto.Name;
                patient.Address = patientDto.Address;
                patient.Age = patientDto.Age;
                patient.Disease = patientDto.Disease;
                _patientRepository.Update(patient);
            }
            catch
            {
                throw;
            }
        }
        public void Remove(int Id)
        {
            try
            {
                var pat = GetPatient(Id);
                _patientRepository.Remove(pat);

             }
            catch
            {
                throw;
            }

            
            }
        }
    }
}
