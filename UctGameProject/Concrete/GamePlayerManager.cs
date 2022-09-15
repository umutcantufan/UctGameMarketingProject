using System;
using System.Collections.Generic;
using System.Text;
using UctGameProject.Abstract;
using UctGameProject.Abstract.Concrete;
using UctGameProject.Entities;

namespace UctGameProject.Concrete
{
   public class GamePlayerManager : IGamePlayerService
    {
        IMernisCheckService mernisCheckService;

        public GamePlayerManager(IMernisCheckService mernisCheckService)
        {
            this.mernisCheckService = mernisCheckService;
        }


        public void Delete(GamePlayer gamePlayer)
        {
            Console.WriteLine("GamePlayer Silindi : " + gamePlayer.FirstName + " " + gamePlayer.LastName);

        }

        public void Save(GamePlayer gamePlayer)
        {
            if (mernisCheckService.CheckIfRealPerson(gamePlayer))
            {
                Console.WriteLine("GamePlayer Kaydedildi : " + gamePlayer.FirstName+ " " + gamePlayer.LastName);
            }

            else
            {
                Console.WriteLine("GamePlayer kayıt edilmedi,bilgilerinizi kontrol ederek tekrar deneyiniz.");
            }
        }

        public void Update(GamePlayer gamePlayer)
        {
            Console.WriteLine("Gameplayer Bilgileri Güncellendi : " + " " + gamePlayer.FirstName + " " +gamePlayer.LastName);
        }
    }
}
