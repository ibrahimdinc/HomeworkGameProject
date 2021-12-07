using HomeworkGameProject.Entities;
using HomeworkGameProject.Services;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameProject.Adapter
{
    class MernisServiceAdapter : ICheckService
    {
        public bool Check(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(gamer.NationalityId, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth);
        }
    }
}
