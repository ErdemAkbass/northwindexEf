using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        void Add(Order order);
        void Delete(Order order);
        void Update(Order order);
            }
}
