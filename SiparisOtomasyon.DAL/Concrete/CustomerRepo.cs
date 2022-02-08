using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Concrete
{
    using Abstract;
    using Context;

    public class CustomerRepo : ICustomerRepo
    {
        private NorthwindContext DB;
        public CustomerRepo()
        {
            DB = new NorthwindContext();
            DB.Configuration.AutoDetectChangesEnabled = false;
        }

        public void Add(Customer item)
        {
            DB.Customers.Add(item);
            DB.SaveChanges(); //SaveChanges değişikliği onayla
        }

        public bool Delete(string Id)
        {
            var dbItem = DB.Customers.FirstOrDefault(t0 => t0.CustomerID == Id);
            if (dbItem != null)
            {
                DB.Customers.Remove(dbItem);
                DB.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Customer> Get()
        {
            var result = DB.Customers.AsNoTracking().ToList();
            return result;
        }

        public Customer GetById(string Id)
        {
            var result = DB.Customers.AsNoTracking().FirstOrDefault(t0 => t0.CustomerID == Id);
            return result;
        }

        public void Update(Customer item)
        {
            DB.Entry(item).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }

    }
}
