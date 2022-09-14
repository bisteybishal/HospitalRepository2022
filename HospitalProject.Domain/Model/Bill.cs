using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Domain.Model
{
  public  class Bill
    {
        public int Id { get; set; }
        public int BillNumber { get; set; }
        public int PatientId { get; set; }
        public int DoctorCharge { get; set; }
        public int RoomCharge { get; set; }
        public int NumberofDays { get; set; }
        public int LabCharge { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
