using System;
using System.Collections.Generic;
using System.Text;
using UctGameProject.Abstract;
using UctGameProject.Entities;

namespace UctGameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void SellTo(GamePlayer gamer, Products product)
        {
            Console.WriteLine("Product: " + product.Name + " adlı ürün" + " gamer Adı: " + gamer.FirstName + " olan kişiye ürün fiyatı : " + product.Price + " TL olarak satılmıştır.");
        }
    }
}
 