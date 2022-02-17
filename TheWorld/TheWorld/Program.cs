using System;
using TheWorld.Models;

namespace TheWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen[] citizens = new Citizen[]
            {
                new Citizen("Ion", "Macari", "6745372876342", "060066799", 14, false, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Unemployed) }),
                new Citizen("Cristina", "Musteata", "8754638645365", "078675355", 22, true, new CitizensRole[] { new CitizensRole(CitizensRole.Role.SocialWorker) }),
                new Citizen("Ivan", "Cibotaru", "3423985643564", "067874533", 45, false, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Governor) }),
                new Citizen("Mariana", "Colonita", "8756453423232", "078564321", 56, true, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Employed) }),
                new Citizen("Vasile", "Panasescu", "2016785543935", "067452212", 50, false, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Governor) }),
                new Citizen("Ion", "Vutcarau", "3065459876564", "068651200", 47, false, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Governor) }),
                new Citizen("Sofia", "Balanescu", "9067432187564", "078675432", 43, true, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Governor) }),
                new Citizen("Dan", "Malaescu", "8976432345657", "079764532", 40, false, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Governor) }),
                new Citizen("Mihai", "Vultur", "7656245367853", "079546387", 46, false, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Governor) }),
                new Citizen("Dorian", "Frunzescu", "8745349865453", "078675421", 50, false, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Governor) }),
                new Citizen("Veceaslav", "Pinzari", "8756453423768", "078652434", 52, false, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Governor) }),
                new Citizen("Dumitru", "Fuior", "8745346524356", "067563419", 44, false, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Governor) }),
                new Citizen("Vitalii", "Gorodinschii", "8756349867543", "078112001", 45, false, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Governor) }),
                new Citizen("Victor", "Cucereavii", "7645364256432", "067560012", 56, false, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Governor) }),
                new Citizen("Marius", "Vozniac", "8767564534238", "079650154", 45, false, new CitizensRole[] { new CitizensRole(CitizensRole.Role.Governor) })
            };

            City[] cities = new City[]
            {
                new City("Anenii Noi",  8358, new Governor( new Citizen[] { citizens[2] })),
                new City("Basarabeasca", 11192, new Governor( new Citizen[] { citizens[8] })),
                new City("Briceni", 8765, new Governor( new Citizen[] { citizens[12] } )),
            };

            Commune[] communes = new Commune[]
            {
                new Commune("Botnărești", 898, new Governor( new Citizen[] { citizens[4] })),
                new Commune("Bulboaca", 6230, new Governor( new Citizen[] { citizens[5] })),
                new Commune("Calfa", 1600, new Governor( new Citizen[] { citizens[6] })),
                new Commune("Abaclia", 5519, new Governor( new Citizen[] { citizens[9] })),
                new Commune("Bașcalia", 3903, new Governor( new Citizen[] { citizens[10] })),
                new Commune("Balasinești", 2269, new Governor( new Citizen[] { citizens[13] })),
            };

            Countryside[] countrysides = new Countryside[]
            {
                new Countryside("Albinița", 370, new Governor( new Citizen[] { citizens[7] } )),
                new Countryside("Bogdanovca", 52, new Governor( new Citizen[] { citizens[11] } )),
                new Countryside("Groznița", 345, new Governor( new Citizen[] { citizens[14] } )),
            };

            District[] districts = new District[]
            {
                new District("Anenii Noi", new City[] { cities[0] }, new Commune[] { communes[0], communes[1], communes[2] }, new Countryside[] { countrysides[0] }),
                new District("Basarabeasca", new City[] { cities[1] }, new Commune[] { communes[3], communes[4] }, new Countryside[] { countrysides[1] }),
                new District("Briceni", new City[] { cities[2] }, new Commune[] { communes[5] }, new Countryside[] { countrysides[2] })
            };

            #region Add districts and citizens to cities
            cities[0].District = districts[0];
            cities[1].District = districts[1];
            cities[2].District = districts[2];

            cities[0].Citizens = new Citizen[] { citizens[2] };
            cities[1].Citizens = new Citizen[] { citizens[8] };
            cities[2].Citizens = new Citizen[] { citizens[12] };
            #endregion

            #region Add districts and citizens to communes
            communes[0].District = districts[0];
            communes[1].District = districts[0];
            communes[2].District = districts[0];
            communes[3].District = districts[1];
            communes[4].District = districts[1];
            communes[5].District = districts[2];

            communes[0].Citizens = new Citizen[] { citizens[4] };
            communes[1].Citizens = new Citizen[] { citizens[5] };
            communes[2].Citizens = new Citizen[] { citizens[6] };
            communes[3].Citizens = new Citizen[] { citizens[9] };
            communes[4].Citizens = new Citizen[] { citizens[10] };
            communes[5].Citizens = new Citizen[] { citizens[13] };
            #endregion

            #region Add districts and citizens to countrysides
            countrysides[0].District = districts[0];
            countrysides[1].District = districts[1];
            countrysides[2].District = districts[2];

            countrysides[0].Citizens = new Citizen[] { citizens[7] };
            countrysides[1].Citizens = new Citizen[] { citizens[11] };
            countrysides[2].Citizens = new Citizen[] { citizens[14] };
            #endregion

            Country[] countries = new Country[]
            {
                new Country("Moldova", districts)
            };          
        }
    }
}
