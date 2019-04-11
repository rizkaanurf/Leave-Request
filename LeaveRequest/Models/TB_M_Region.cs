using LeaveRequest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequest.Models
{
    public class TB_M_Region : BaseModel
    {
        public string Name { get; set; }
        public virtual TB_M_Province TB_M_Provinces { get; set; }
    }
}
