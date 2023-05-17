using System;
using System.Collections.Generic;
using FootballTeamApp.Models;

namespace FootballTeamApp.Functionality
{
    interface IFootballOperation
    {
        int CreateFootballPlayer(Football pl);
        List<Football> GetAllFootballs();
        void updatePlayer();
        void RemovePlayer();
        void AddPlayer();
        void SearchPlayer();
        void ReadPlayer();
    }
}
