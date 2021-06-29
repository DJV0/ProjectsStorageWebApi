using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projects.BLL.Interfaces;
using Projects.DAL.Interfaces;
using Projects.DAL.Models;

namespace Projects.BLL.Services
{
    public class TeamService : GenericService<Team>, ITeamService
    {
        public TeamService(ITeamRepository context) : base(context) { }

    }
}
