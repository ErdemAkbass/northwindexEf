using business.Abstract;
using DataAccess.Abstact;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Concrete
{
    public class OrderManager : IOrderService
    {

        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);


        }

        public List<Order> GetAll()
        {


            return _orderDal.GetAll(x => x.OrderId > 10000);
            
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }
    
    }
}
