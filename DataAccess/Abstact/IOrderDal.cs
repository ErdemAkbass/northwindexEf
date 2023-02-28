using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstact
{
    public interface IOrderDal: IEntityRepository<Order>
    {
    }
}
