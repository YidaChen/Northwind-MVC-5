using NorthwindMVC5.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NorthwindMVC5.Models.Repository
{
    public class ProductRepository : IProductRepository
    {
        protected NorthwindEntities db
        {
            get;
            private set;
        }

        public ProductRepository()
        {
            this.db = new NorthwindEntities();
        }


        public void Create(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }
            else
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }
            else
            {
                db.Entry(product).State = EntityState.Modified;
                this.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }
            else
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }


        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public IQueryable<Product> GetAll()
        {
            return db.Products.Include(p => p.Category).Include(p => p.Supplier);
        }


        public void SaveChanges()
        {
            this.db.SaveChanges();
        }

        
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.db != null)
                {
                    this.db.Dispose();
                    this.db = null;
                }
            }
        }
    }
}