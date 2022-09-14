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
            throw new NotImplementedException();
        }

        public Doctor GetDoctorbyId(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}
