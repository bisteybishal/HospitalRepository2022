using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Domain.Model
{
   public  class Laboratory
    {
        [Key]
        public int Id { get; set; }
        public int LabNumber { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
         
        public DateTime DateofRequest { get; set; }
    }
}
