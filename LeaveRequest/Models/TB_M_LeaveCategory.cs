using LeaveRequest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequest.Models
{
    public class TB_M_LeaveCategory : BaseModel
    {
        public string Name { get; set; }
        public string LeaveFor { get; set; }
        public int LeaveDays { get; set; }
    }
}
