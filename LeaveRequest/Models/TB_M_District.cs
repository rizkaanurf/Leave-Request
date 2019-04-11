using LeaveRequest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequest.Models
{
    public class TB_M_District : BaseModel
    {
        public string Name { get; set; }
        public virtual TB_M_Region TB_M_Regions { get; set; }
    }
}
