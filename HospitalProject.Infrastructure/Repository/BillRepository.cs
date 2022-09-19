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
    public class BillRepository : IBillRepository
    {
        private readonly AppDbContext _dbContext;

        public BillRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Bill entity)
        {
            _dbContext.Bills.Add(entity);
            _dbContext.SaveChanges();
        }

        public IQueryable<Bill> GetAll()
        {
            return _dbContext.Bills.AsQueryable();
        }

        public Bill GetBillbyId(int billId)
        {
           return _dbContext.Bills.Where(x => x.Id == billId).FirstOrDefault();
        }

        public void Remove(Bill bill)
        {
            _dbContext.Bills.Remove(bill);
            _dbContext.SaveChanges();
        }

        public void Update(Bill bill)
        {
            _dbContext.Bills.Update(bill);
            _dbContext.SaveChanges();
        }
    }
}
