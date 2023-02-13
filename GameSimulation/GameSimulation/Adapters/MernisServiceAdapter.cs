using GameSimulation.Enities;
using GameSimulation.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Abstract
{
    class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Players players)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient((KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12));
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(players.NationalityId), players.FirstName.ToUpper(), players.LastName.ToUpper(), players.BirthYear);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
