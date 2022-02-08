using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Concrete
{
    using Context;
    using Abstract;
    public class ShipperRepo : GenericRepo<Shipper, int>, IShipperRepo
    {

    }
}
