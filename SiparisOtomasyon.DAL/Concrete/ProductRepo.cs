using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Concrete
{
    using Abstract;
    using Context;
    using SiparisOtomasyon.DAL.VM;

    public class ProductRepo : IProductRepo
    {
        NorthwindContext DB;
        public ProductRepo()
        {
            DB = new NorthwindContext();
        }

        public void Add(Product item)
        {
            DB.Entry(item).State = System.Data.Entity.EntityState.Added;
            DB.SaveChanges();
        }

        public bool Delete(int Id)
        {
            var dbItem = DB.Products.FirstOrDefault(t0 => t0.ProductID == Id);
            if (dbItem != null)
            {
                DB.Products.Remove(dbItem);
                DB.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Product> Get()
        {
            return DB.Products.AsNoTracking().ToList();
        }

        public Product GetById(int Id)
        {
            return DB.Products.FirstOrDefault(t0 => t0.ProductID == Id);
        }

        public List<ProductVM> GetProductsVM()
        {
            var products = (from t0 in DB.Products
                            select new ProductVM()
                            {
                                ProductId = t0.ProductID,
                                CategoryName = t0.Category.CategoryName,
                                ProductName = t0.ProductName,
                                SupplierName = t0.Supplier.CompanyName,
                                UnitPrice = t0.UnitPrice,
                                UnitsInStock = t0.UnitsInStock
                            }).ToList();
            return products;
        }

        public void Update(Product item)
        {
            DB.Entry(item).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
