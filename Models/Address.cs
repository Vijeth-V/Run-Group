﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RunGroup.Models
{
	public class Address
	{
		[Key]
		public int Id { get; set; }

		public string Street { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;


    }
}

