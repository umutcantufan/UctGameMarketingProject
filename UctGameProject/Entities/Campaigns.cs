using System;
using System.Collections.Generic;
using System.Text;
using UctGameProject.Abstract;

namespace UctGameProject.Entities
{
    public class Campaigns:ICampaigns
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DiscountRate { get; set; }
    }
}
