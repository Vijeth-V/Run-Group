﻿using System;
using RunGroup.Models;

namespace RunGroup.Interfaces
{
	public interface IRaceRepository
	{
        Task<IEnumerable<Race>> GetAll();

        Task<Race> GetByIdAsync(int id);

        Task<IEnumerable<Race>> GetAllRacesByCity(string City);

        bool Add(Race race);

        bool Update(Race race);

        bool Delete(Race race);

        bool Save();
    }
}

