using StudentManagementApi.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApi.Models.DataAccess.Abstract
{
   public interface IAdminDAL : IRepository<Admin>
    {
    }
}
