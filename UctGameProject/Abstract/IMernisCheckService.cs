using System;
using System.Collections.Generic;
using System.Text;
using UctGameProject.Entities;

namespace UctGameProject.Abstract.Concrete
{
    public interface IMernisCheckService
    {
        bool CheckIfRealPerson(GamePlayer gamePlayer);

    }
}
