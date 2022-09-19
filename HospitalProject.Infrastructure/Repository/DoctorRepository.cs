using HospitalProject.Domain.Model;
using HospitalProject.Infrastructure.Data;
using HospitalProject.Service.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Infrastructure.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppDbContext _dbContext;

        public DoctorRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Doctor entity)
        {
            _dbContext.Doctors.Add(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Doctor> GetAllDoctor()
        {
            return _dbContext.Doctors.ToList();
        }

        public Doctor GetDoctorbyId(int id)
        {
            return _dbContext.Doctors.Find(id);
        }

        public void Remove(Doctor doctor)
        {
            _dbContext.Remove(doctor);
            _dbContext.SaveChanges();
        }

        public void Update(Doctor doctor)
        {
            _dbContext.Update(doctor);
            _dbContext.SaveChanges();
        }
    }
}
