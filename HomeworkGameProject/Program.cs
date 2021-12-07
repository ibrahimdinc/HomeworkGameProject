using HomeworkGameProject.Adapter;
using HomeworkGameProject.Entities;
using HomeworkGameProject.Managecment;
using System;

namespace HomeworkGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            Gamer gamer = new Gamer
            {
                GamerId = 1,
                DateOfBirth = 1995,
                FirstName = "Abdulkadir",
                LastName = "Abdulmuttalip",
                NationalityId = 12345678912,
                UserName = "Abdus"
            };
            gamerManager.Add(gamer);
        }
    }
}
