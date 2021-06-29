﻿using Projects.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Interfaces
{
    public interface ITeamService
    {
        IEnumerable<Team> GetTeams();
        Team GetTeam(int id);
        void DeleteTeam(Team team);
        void DeleteTeam(int id);

    }
}
