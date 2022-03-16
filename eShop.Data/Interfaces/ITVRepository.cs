using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Data.Interfaces
{
   public interface ITVRepository
    {
        IEnumerable<TV> GetAll();
        TV getbyid(int TVid);
        TV Creat(TV tv);
        TV Update(TV updateTV);
        TV Delete(int id);
    }
}
