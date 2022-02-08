using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Abstract
{
    using Context;
    using System.Data.Entity;

    //T Tipi Nesnenin Tipi,
    //T1 Tipi Customer tablosu özelinde yazılmış Id için belirtilen tip
    public abstract class GenericRepo<T, T1>
        : IRepository<T, T1>
        where T : class // T tipi referans tipli bir nesne tipinde olması gerekir
    {
        private NorthwindContext _DB;
        public NorthwindContext DB
        {
            get
            {
                if (_DB == null)
                    _DB = new NorthwindContext();
                return _DB;
            }

        }

        public virtual void Add(T item)
        {
            DB.Set<T>().Add(item);
            DB.SaveChanges();
        }

        public virtual bool Delete(T1 Id)
        {
            var dbItem = DB.Set<T>().Find(Id);
            if (dbItem != null)
            {
                DB.Set<T>().Remove(dbItem);
                DB.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual List<T> Get()
        {
            return DB.Set<T>().AsNoTracking().ToList();
        }

        public virtual T GetById(T1 Id)
        {
            return DB.Set<T>().Find(Id);
        }

        public virtual void Update(T item)
        {
            DB.Entry<T>(item).State = EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
