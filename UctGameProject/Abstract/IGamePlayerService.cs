using UctGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UctGameProject.Abstract
{
    public interface IGamePlayerService
    {
        void Save(GamePlayer gamePlayer);
        void Update(GamePlayer gamePlayer);
        void Delete(GamePlayer gamePlayer);
    }
}