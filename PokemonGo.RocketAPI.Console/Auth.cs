using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.RocketAPI.Console
{
	class Auth
	{
		public static string auth(string key)
		{
			using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
			{
				string response;
				try
				{
					response = client.DownloadString("http://pokebot.pw/applications/nexus/interface/licenses/?info&key=" + key);
				}
				catch (Exception)
				{
					response = "{\"errorCode\":\"BAD_KEY_OR_ID\",\"errorMessage\":101}";
				}
				return response;
			}
		}
		public static bool valid(string key)
		{
			JObject license = JObject.Parse(auth(key));
			if (license["key"] != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public static string user(string key)
		{
			JObject license = JObject.Parse(auth(key));
			if (license["key"] != null)
			{
				return license["customer_name"] + "";
			}
			else
			{
				return "Everyone";
			}
		}
		public static string rank(string key)
		{
			JObject license = JObject.Parse(auth(key));
			if (license["key"] != null)
			{
				return license["purchase_name"] + "";
			}
			else
			{
				return "";
			}
		}
	}
}
