using LeaveRequest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequest.Interfaces
{
    public interface IProvince
    {
        List<TB_M_Province> Get();
        TB_M_Province Get(int Id);
        bool Insert(TB_M_Province province);
        bool Update(int Id, TB_M_Province province);
        bool Delete(int Id);
    }
}
