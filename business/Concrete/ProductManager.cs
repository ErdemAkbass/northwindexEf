    using business.Abstract;
using DataAccess.Abstact;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if (product.ProductId>2)
            {
                _productDal.Add(product);
            }
            else
            {
                Console.WriteLine("Kurallara uymayan ürün ekleyemezsiniz");
            }
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll(x=>x.ProductId>55);
        }

        public List<ProductDetailsDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
