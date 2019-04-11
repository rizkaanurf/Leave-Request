using LeaveRequest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequest.Models
{
    public class TB_T_LeaveRequest : BaseModel
    {
        public string Note { get; set; }
        public int TotalLeave { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int CurrentYearBefore { get; set; }
        public int LastYearBefore { get; set; }
        public bool RequestStatus { get; set; }
        public DateTime ApprovalDate { get; set; }
        public virtual TB_M_Employee TB_M_Employees { get; set; }
        public virtual TB_M_LeaveCategory TB_M_LeaveCategories { get; set; }
    }
}
