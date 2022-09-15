using UctGameProject.Abstract;
using UctGameProject.Adapter;
using UctGameProject.Concrete;
using UctGameProject.Entities;
using System;

namespace UctGameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            GamePlayer player1 = new GamePlayer()
            {
                Id = 1,
                FirstName = "Umutcan",
                LastName = "TUFAN",
                DateOfBirth = new DateTime(1996, 06, 14),
                NationaltyId = 15988058172
            };

            GamePlayerManager gamePlayerManager = new GamePlayerManager(new MernisCheckManager());
            gamePlayerManager.Save(player1);
            //gamePlayerManager.Delete(player1);
            //gamePlayerManager.Update(player1);



            //Oyuncu mernis sistemiden bilgilerini kontrol ediyor. Eğer bilgiler doğruysa kaydı tamamlıyor.
            //Eğer yanlışsa bilgilerini kontrol etmesi için bilgilendirici mesaj içeriyor.



            Products products1 = new Products()
            {
                Id = 1,
                Name = "CS 1.6",
                Price = 69.99
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(products1);
            //productManager.Delete(products1);
            //productManager.Update(products1);


            Campaigns campaigns1 = new Campaigns();
            campaigns1.Name = "Büyük Yaz İndirimi";
            campaigns1.Id = 2;
            campaigns1.DiscountRate = 35;

            CampaignsManager campaignsManager = new CampaignsManager();
            campaignsManager.Add(campaigns1);
            campaignsManager.CalculateDiscount(campaigns1,products1);
            campaignsManager.Update(campaigns1,40);
            campaignsManager.CalculateDiscount(campaigns1, products1);


            SalesManager salesManager = new SalesManager();
            salesManager.SellTo(player1,products1);

        }
    }
}
