using System;
using System.Collections.Generic;
using System.Text;
using UctGameProject.Entities;

namespace UctGameProject.Abstract
{
    public interface ISalesService
    {
        void SellTo(GamePlayer gamer, Products product);
    }
}
