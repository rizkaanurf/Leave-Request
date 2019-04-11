using LeaveRequest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequest.Models
{
    public class TB_M_Employee : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsMarried { get; set; }
        public DateTime JoinDate { get; set; }
        public string Street { get; set; }
        public string WorkStatus { get; set; }
        public virtual TB_M_Village TB_M_Villages { get; set; }
        public virtual TB_M_Religion TB_M_Religions { get; set; }
        public virtual TB_M_Employee TB_M_Employees { get; set; }
        public virtual TB_M_Department TB_M_Departments { get; set; }
        public virtual TB_M_Job TB_M_Jobs { get; set; }
    }
}
