using System;
using System.Threading.Tasks;
using PokemonGo.RocketAPI.Exceptions;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using PokemonGo.RocketAPI.Logic.Utils;
using POGOProtos.Enums;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;

namespace PokemonGo.RocketAPI.Console
{
    internal class Program
    {
		[DllImport("kernel32.dll")]
		static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		const int SW_HIDE = 0;
		const int SW_SHOW = 5;


		public static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "pokebot4");
        public static string path_translation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Translations");
        public static string account = Path.Combine(path, "Config.txt");
        public static string items = Path.Combine(path, "Items.txt");
        public static string keep = Path.Combine(path, "noTransfer.txt");
        public static string ignore = Path.Combine(path, "noCatch.txt");
        public static string evolve = Path.Combine(path, "Evolve.txt");
        public static string lastcords = Path.Combine(path, "LastCoords.txt");
        public static string huntstats = Path.Combine(path, "HuntStats.txt");
		public static string license = Path.Combine(path, "license.txt");
        public static string cmdCoords = string.Empty;



		[STAThread]
		static void Main(string[] args)
		{


			var handle = GetConsoleWindow();
			ShowWindow(handle, SW_HIDE);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			


			if (File.Exists(license))
			{
				if (Auth.valid(File.ReadAllText(license)))
				{
					Globals.licensekey = File.ReadAllText(license);
					Globals.licensed = true;
				}

				else
				{
					Globals.licensed = false;
					License l = new License();
					l.ShowDialog();
				}
				
			}

			else
			{
				License l = new License();
				l.ShowDialog();
			}



			Application.Run(new Config());

            Logger.SetLogger(new Logging.ConsoleLogger(LogLevel.Info));

            Globals.infoObservable.HandleNewHuntStats += SaveHuntStats;
			Task.Run(() =>
			{
				GUI s = new GUI();
				s.ShowDialog();
			});
			Task.Run(async () =>
			{
				while (true)
				{
					try
					{
						await trylogic();
					}
					catch (PtcOfflineException)
					{
						MessageBox.Show("PTC Servers are probably down OR you credentials are wrong. Press OK to try again!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
						Logger.ColoredConsoleWrite(ConsoleColor.Red, "PTC Servers are probably down OR you credentials are wrong.", LogLevel.Error);
					}
					catch (AccountNotVerifiedException)
					{
						MessageBox.Show("Your PTC accoutn is not verified. Press OK to exit!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
						Logger.ColoredConsoleWrite(ConsoleColor.Red, "Your PTC Account is not activated. Exiting in 10 Seconds.");
						Environment.Exit(0);
					}
					catch (Exception ex)
					{
						Logger.ColoredConsoleWrite(ConsoleColor.Red, $"Unhandled exception: {ex}", LogLevel.Error);
						Logger.Error("Restarting in 20 Seconds.");
					}
				}

			});
            System.Console.ReadLine();
        }

        private static void SaveHuntStats(string newHuntStat)
        {
            File.AppendAllText(huntstats, newHuntStat);
        }

		private static async Task download(int x, string loc)
		{
			await Task.Delay(5000);
			WebClient wc = new WebClient();
			wc.DownloadFile("http://pokeapi.co/media/sprites/pokemon/" + x + ".png", @loc);
		}

		public static async Task trylogic()
		{
			new Logic.Logic(new Settings(), Globals.infoObservable).Execute().Wait();
		}
    }
    public static class Globals
    {
		public static string licensekey = "Free";
		public static bool licensed = false;
        public static Enums.AuthType acc = Enums.AuthType.Google;
        public static bool defLoc = true;
        public static string username = "empty";
        public static string password = "empty";
        public static double latitute = 40.764883;
        public static double longitude = -73.972967;
        public static double altitude = 15.173855;
        public static double speed = 50;
        public static int radius = 5000;
        public static bool transfer = true;
        public static int duplicate = 3;
        public static bool evolve = true;
        public static int maxCp = 999;
        public static int pokeball = 20;
        public static int greatball = 50;
        public static int ultraball = 100;
        public static int masterball = 200;
        public static int revive = 20;
        public static int potion = 0;
        public static int superpotion = 0;
        public static int hyperpotion = 50;
        public static int toppotion = 100;
        public static int toprevive = 50;
        public static int berry = 50;
        public static int ivmaxpercent = 0;
        public static List<PokemonId> noTransfer = new List<PokemonId>();
        public static List<PokemonId> noCatch = new List<PokemonId>();
        public static List<PokemonId> doEvolve = new List<PokemonId>();
        public static string telAPI = string.Empty;
        public static string telName = string.Empty;
        public static int telDelay = 5000;

        public static int navigation_option = 1;
        public static bool useluckyegg = true;
        public static bool useincense = true;
        public static bool gerNames = false;
        public static bool pokeList = true;
        public static bool keepPokemonsThatCanEvolve = true;
        public static bool pokevision = false;

        public static bool useLuckyEggIfNotRunning = false;

        public static bool autoIncubate = true;
        public static bool useBasicIncubators = false;

        public static string mapType = "Bing";

        public static IDictionary<string, int> flagCoords = new Dictionary<string, int>();
        
        public static Logic.LogicInfoObservable infoObservable = new Logic.LogicInfoObservable();
    }
}
