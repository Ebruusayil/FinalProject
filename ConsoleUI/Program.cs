using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            //Console.WriteLine(productManager.GetAll().Where(<lambda expression>);
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName.FirstOrDefault());
            }

        }
    }
}