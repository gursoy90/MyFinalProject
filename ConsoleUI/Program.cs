using DataAccess.Concrete.InMemory;
using Business.Concrete;
using System;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(10,20))
            {
               Console.WriteLine(product.ProductName);
            }


        }
    }
}
