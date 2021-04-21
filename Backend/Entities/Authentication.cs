﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entities
{
	public class SignIn
	{
		public string Username { get; set; }
		public string Password { get; set; }
	}

	public class SignUp
	{
		public string Username { get; set; }
	}

	public class Data
	{
		public string Username { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }
	}
}