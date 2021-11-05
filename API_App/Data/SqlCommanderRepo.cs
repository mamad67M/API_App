using API_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_App.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderDbContext _dbCtxt;

        public SqlCommanderRepo( CommanderDbContext dbCtxt)
        {
            _dbCtxt = dbCtxt;
        }

        public void CreatCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _dbCtxt.Commands.Add(cmd);
        }

        public IEnumerable<Command> GetAllCommand()
        {
            return _dbCtxt.Commands.ToList();
        }

        public Command GetCommandeById(int id)
        {
            return _dbCtxt.Commands.SingleOrDefault(o => o.Id == id);
        }

        public bool SaveChanges()
        {
            return (_dbCtxt.SaveChanges() >= 0);
        }
    }
}
