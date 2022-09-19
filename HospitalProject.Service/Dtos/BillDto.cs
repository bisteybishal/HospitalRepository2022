using HospitalProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Service.Dtos
{
   public class BillDto
    {
        public int Id { get; set; }
       public int DoctorCharge { get; set; }
        public int RoomCharge { get; set; }
        public int NumberofDays { get; set; }
        public int LabCharge { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
