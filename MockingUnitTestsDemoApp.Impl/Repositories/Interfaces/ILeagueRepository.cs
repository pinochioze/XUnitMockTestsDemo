﻿using MockingUnitTestsDemoApp.Impl.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Impl.Repositories.Interfaces
{
    public interface ILeagueRepository
    {
        Task<League> GetByID(int id);
        Task<bool> IsValid(int leagueID);
    }
}
