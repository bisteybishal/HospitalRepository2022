using HospitalProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Service.Interface.Repository
{
    public interface IpatientRepository
    {
       IEnumerable<Patient> GetAll();
       Patient GetPatient(int patientId);
       void Add(Patient entity);
       void Update(Patient patient);
       void Remove(Patient patient);
    }
}
