using LeaveRequest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequest.Models
{
    public class TB_T_File : BaseModel
    {
        public string Name { get; set; }
        public virtual TB_T_LeaveRequest TB_T_LeaveRequests { get; set; }
    }
}
