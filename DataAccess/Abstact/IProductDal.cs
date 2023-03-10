using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstact
{
    public interface IProductDal: IEntityRepository<Product>
    {
        public List<ProductDetailsDto> GetProductDetails();
    }
}
