using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Abstract
{
    using Context;
    using VM;

    public interface IProductRepo : IRepository<Product, int>
    {
        List<ProductVM> GetProductsVM();

    }
}
