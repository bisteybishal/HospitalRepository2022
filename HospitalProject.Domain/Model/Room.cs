using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Domain.Model
{
  public  class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public string Status { get; set; }
       
    }
    public enum RoomType
    {
            General_Ward,
            TripleBed_Cabin,
            DoubleBed_Cabin,
            SingleBed_Cabin,
            Vip_Cabin

    }
}
