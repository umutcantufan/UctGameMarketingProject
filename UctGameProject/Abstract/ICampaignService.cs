using System;
using System.Collections.Generic;
using System.Text;
using UctGameProject.Entities;

namespace UctGameProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaigns campaign);
        void Delete(Campaigns campaigns);
        void Update(Campaigns campaigns, double discountRate);
        void CalculateDiscount(Campaigns campaign, Products product);
    }
}
