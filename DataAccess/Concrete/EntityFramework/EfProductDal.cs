﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstact;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
        public List<ProductDetailsDto> GetProductDetails()
        {
            using(NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailsDto
                             {
                                 ProductName = p.ProductName,
                                 CategoryId = p.CategoryId,
                                 


                             };
                return result.ToList();
            }
        }
    }
}
