
using HospitalProject.Domain.Model;
using HospitalProject.Service.Dtos;
using System.Linq;

namespace HospitalProject.Service.Interface.Service
{
    public interface IPatientService
    {
        IQueryable<PatientDto> GetAll();
        Patient GetPatient(int patientId);
        void Add(Patient entity);
        void Update(PatientDto patientDto);
    }
}
