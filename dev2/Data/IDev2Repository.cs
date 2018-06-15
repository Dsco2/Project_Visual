using System.Collections.Generic;
using dev2.Data.Entities;

namespace dev2.Data
{
    public interface IDev2Repository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);

        bool SaveChanges();
        void AddEntity(object model);
    }
}