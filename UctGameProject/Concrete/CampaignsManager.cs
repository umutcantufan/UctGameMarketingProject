using System;
using System.Collections.Generic;
using System.Text;
using UctGameProject.Abstract;
using UctGameProject.Entities;

namespace UctGameProject.Concrete
{
    class CampaignsManager : ICampaignService
    {
        public void Add(Campaigns campaign)
        {
            Console.WriteLine("New Campaigns :" + campaign.Name + "  | İndirim Oranı : %"+ campaign.DiscountRate);
        }

        public void CalculateDiscount(Campaigns campaigns, Products products)
        {
            double discountAmount = (products.Price * campaigns.DiscountRate) / 100;
            double discountedPrice = (products.Price - discountAmount);
            products.Price = discountedPrice;
            Console.WriteLine("Product İndirimli Fiyat : " + products.Name + " | Fiyatı : " + products.Price);

        }

        public void Delete(Campaigns campaigns)
        {
            Console.WriteLine("Campaign Sil : " + campaigns.Name);
        }

        public void Update(Campaigns campaign, double discountRate)
        {
            campaign.DiscountRate = discountRate;
            Console.WriteLine("Campaign : " + campaign.Name + " " + "Güncellenen campaign fiyatı : " + campaign.DiscountRate);
             
        }
    }
}
