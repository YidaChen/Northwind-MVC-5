using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindMVC5.Models.Interface
{
    public interface IProductRepository : IDisposable
    {
        void Create(Product instance);
 
        void Update(Product instance);
 
        void Delete(Product instance);
 
        Product Get(int productID);
 
        IQueryable<Product> GetAll();
 
        void SaveChanges();
    }
}