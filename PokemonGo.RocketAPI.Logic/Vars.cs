﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.RocketAPI.Logic
{
	public class Vars
	{
		public static bool update = false;
		public static string username = "Unknown";
		public static string xprate = "Unknown";
		public static string catchrate = "Unknown";
		public static string evolvecount = "Unknown";
		public static string pokemon = "Unknown";
		public static string items = "Unknown";
		public static string stardust = "Unknown";
		public static string level = "Unknown";
		public static string percentage = "0";
	}
	public class TaskVars
	{
		public static string task = "";
		//Tasks: farm, transfer, evolve, discard, catch, move
	}
}