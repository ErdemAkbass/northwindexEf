using business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            ProductManager productManager = new ProductManager(new EfProductDal());
            OrderManager orderManager = new OrderManager(new EfOrderDal());

            //foreach (var Order in orderManager.GetAll())
            //{
            //    Console.WriteLine(Order.OrderId);
            //}
            //foreach (var Product in productManager.GetAll())
            //{
            //    Console.WriteLine(Product.ProductId + "/" + Product.ProductName + "/" + Product.UnitsInStock);
            //}   

            foreach (var Product in productManager.GetProductDetails())
            {
                Console.WriteLine(Product.CategoryId+"/"+Product.ProductName);

            }
            

            
        }
        
	

	
    }
}
