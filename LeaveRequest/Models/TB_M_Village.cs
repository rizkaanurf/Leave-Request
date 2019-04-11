using LeaveRequest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequest.Models
{
    public class TB_M_Village : BaseModel
    {
        public string Name { get; set; }
        public virtual TB_M_District TB_M_Districts { get; set; }
    }
}
