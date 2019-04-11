using LeaveRequest.Core;
using LeaveRequest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.Models;
using System.Data.Entity;

namespace LeaveRequest.Applications
{
    public class ProvinceController : Validation, IProvince
    {
        MyContext myContext = new MyContext();
        public ProvinceController(MyContext context)
        {
            myContext = context;
        }
        public ProvinceController() { }

        public List<TB_M_Province> Get()
        {
            var get = myContext.TB_M_Provinces.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public TB_M_Province Get(int Id)
        {
            var get = myContext.TB_M_Provinces.Find(Id);
            if (get != null)
            {
                return get;
            }
            else
            {
                return null;
            }
        }

        public bool Insert(TB_M_Province province)
        {
            myContext.TB_M_Provinces.Add(province);
            return validation(myContext);
        }

        public bool Update(int Id, TB_M_Province province)
        {
            var get = Get(Id);
            if (get != null)
            {
                get.Name = province.Name;
                get.UpdateDate = DateTimeOffset.Now.LocalDateTime;
                myContext.Entry(get).State = EntityState.Modified;
                validation(myContext);
            }
            else
            {
                status = false;
            }
            return status;
        }

        public bool Delete(int Id)
        {
            var get = Get(Id);
            if (get != null)
            {
                get.IsDelete = true;
                get.DeleteDate = DateTimeOffset.Now.LocalDateTime;
                myContext.Entry(get).State = EntityState.Modified;
                validation(myContext);
            }
            else
            {
                Console.Write("No Data Found");
            }
            return status;
        }
    }
}
