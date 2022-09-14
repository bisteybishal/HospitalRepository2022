using HospitalProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Service.Interface.Repository
{
   public interface IRoomRepository

    {
        IEnumerable<Room> GetAllRoom();
        Room GetRoombyId(int id);
        void Add(Room entity);
        void Update(Room room);
        void Remove(int id);
    }
}
