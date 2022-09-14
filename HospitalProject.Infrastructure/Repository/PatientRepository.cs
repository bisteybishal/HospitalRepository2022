using HospitalProject.Domain.Model;
using HospitalProject.Infrastructure.Data;
using HospitalProject.Service.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HospitalProject.Infrastructure.Repository
{
    public class PatientRepository : IpatientRepository
    {
        private readonly AppDbContext _dbcontext;

        public PatientRepository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Add(Patient entity)
        {
            _dbcontext.Patients.Add(entity);
             _dbcontext.SaveChanges();

        }
        public IEnumerable<Patient> GetAllPatients()
        {
         return _dbcontext.Patients.Include(x=>x.Doctor).Include(x=>x.Room)
                .ThenInclude(x=>x.RoomNumber);

        }
       public Patient GetPatient(int patientId)
        {
            return _dbcontext.Patients.Where(x => x.Id == patientId).FirstOrDefault();
        }

        public void Remove(int id)
        {
            var patient= _dbcontext.Patients.Where(x=>x.Id==id);
            _dbcontext.Remove(patient);
            _dbcontext.SaveChanges();
        }

        public void Update(Patient patient)
        {
            _dbcontext.Patients.Update(patient);
            _dbcontext.SaveChanges();
        }

       
    }
}
