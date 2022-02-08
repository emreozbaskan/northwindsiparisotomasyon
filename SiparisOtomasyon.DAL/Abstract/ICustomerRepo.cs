using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisOtomasyon.DAL.Context;

namespace SiparisOtomasyon.DAL.Abstract
{
    public interface ICustomerRepo : IRepository<Customer, string>
    {

    }
}
