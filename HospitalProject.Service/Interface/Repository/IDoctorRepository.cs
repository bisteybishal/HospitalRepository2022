using HospitalProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Service.Interface.Repository
{
   public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetAllDoctor();
        Doctor GetDoctorbyId(int id);
        void Add(Doctor entity);
        void Update(Doctor doctor);
        void Remove(int id);

    }
}
