﻿using System;
using RunGroup.Data.Enum;
using RunGroup.Models;

namespace RunGroup.ViewModels
{
	public class CreateRaceViewModel
	{
        //public CreateRaceViewModel()
        //{
        //}

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public RaceCategory RaceCategory { get; set; }
    }
}

