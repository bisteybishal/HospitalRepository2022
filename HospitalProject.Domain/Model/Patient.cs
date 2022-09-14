using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Domain.Model
{
  public  class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public PatientType PatientType { get; set; }
        public string Disease { get; set; }
        public int DoctorId { get; set; }
        public int RoomId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Room Room { get; set; }

        public Patient FirstorDefault()
        {
            throw new NotImplementedException();
        }
    }
    public enum Gender
    {
        Male,
        Female
    }
    public enum PatientType
    {
        ImPatient,
        OutPatient
    }
}
