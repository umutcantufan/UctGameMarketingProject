using System;
using System.Collections.Generic;
using System.Text;
using UctGameProject.Abstract;
using UctGameProject.Entities;

namespace UctGameProject.Concrete
{
    public class ProductManager : IProductService
    {
        public void Add(Products products)
        {
            Console.WriteLine("Product Eklendi: " + products.Name + "  " + " | Fiyat : " + products.Price);
        }

        public void Delete(Products products)
        {
            Console.WriteLine("Product Silindi : " + products.Name);
        }


        public void Update(Products products)
        {
            Console.WriteLine("Product Bilgisi Güncellendi : " + products.Name);
        }
    }
}
