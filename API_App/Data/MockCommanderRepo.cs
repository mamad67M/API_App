using API_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_App.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {


        public IEnumerable<Command> GetAppCommand()
        {
            var commands = new List<Command>()
            {
               new Command {Id =0, HowTo="Boil and egg", Line ="oil ", Platform= "blabla0" },
               new Command {Id =1, HowTo="Boil ", Line =" water", Platform= "blabla1" },
               new Command {Id =2, HowTo=" egg", Line ="oil ", Platform= "blabla2" },
               new Command {Id =3, HowTo="Boil and egg", Line =" water", Platform= "blabla3" }
        };

           return commands;
        }

        public Command GetCommandeById(int id)
        {
            var com = GetAppCommand().FirstOrDefault(c =>c.Id ==id);
            return com;
        }

        
    }
}
