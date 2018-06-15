using dev2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dev2.Data
{
    public class Dev2Repository : IDev2Repository
    {
        private readonly Dev2Context _ctx;
        public Dev2Repository(Dev2Context ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable <Product> GetAllProducts()
        {
            return _ctx.Products
                .OrderBy(p => p.Title)
                .ToList();
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _ctx.Products
                .Where(p => p.Category == category)
                .ToList();
        }

        public bool SaveChanges()
        {
            return _ctx.SaveChanges() > 0;
        }

        //public bool SaveAll()
        //{
        //    return _ctx.SaveChanges() > 0;
        //}


    }
}
