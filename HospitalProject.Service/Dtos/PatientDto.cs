using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Service.Dtos
{
  public  class PatientDto
    {
        public string Name { get; set; }
        public string Address  { get; set; }
        public int Age { get; set; }
        public string Disease { get; set; }
    }
}
