using HospitalProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Service.Interface.Repository
{
   public interface ILaboratoryRepository
    {
        IEnumerable<Laboratory> GetAllLaboratoryDetail();
        Laboratory GetbyId(int id);
        void Add(Laboratory entity);
        void Update(Laboratory laboratory);
        void Remove(int id);
    }
}
