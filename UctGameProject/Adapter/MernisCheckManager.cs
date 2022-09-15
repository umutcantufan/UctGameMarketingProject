using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using UctGameProject.Abstract.Concrete;
using UctGameProject.Entities;

namespace UctGameProject.Adapter
{
    public class MernisCheckManager : IMernisCheckService
    {
        public bool CheckIfRealPerson(GamePlayer gamePlayer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(gamePlayer.NationaltyId, gamePlayer.FirstName.ToUpper(),
                gamePlayer.LastName.ToUpper(), gamePlayer.DateOfBirth.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
