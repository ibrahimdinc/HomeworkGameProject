using HomeworkGameProject.Entities;
using HomeworkGameProject.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameProject.Managecment
{
    class GamerManager : IGamerService
    {
        ICheckService _checkService;
        public GamerManager (ICheckService checkService)
        {
            _checkService = checkService;
        }
        public void Add(Gamer gamer)
        {
            if (_checkService.Check(gamer))
            {

                Console.WriteLine("Sistemimize başarıyla kayıt oldunuz "+ gamer.UserName+"!");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }


        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " adlı kullanıcı sistemden silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Bilgileriniz güncellendi!");
        }
    }
}
