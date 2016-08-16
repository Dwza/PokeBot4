using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PokemonGo.RocketAPI.Logic;

namespace PokemonGo.RocketAPI.Console
{
	public partial class GUI : MetroFramework.Forms.MetroForm
	{
		[DllImport("kernel32.dll")]
		static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		const int SW_HIDE = 0;
		const int SW_SHOW = 5;
		bool console = true;

		bool list = false;
		Pokemons pokemonList = new Pokemons();

		public GUI()
		{
			InitializeComponent();

			var handle = GetConsoleWindow();
			ShowWindow(handle, SW_HIDE);
			console = false;

			Task.Run(update);
			Task.Run(updateTasks);
			if (Globals.pokeList)
			{
				list = true;
				Task.Run(() =>
				{
					pokemonList.ShowDialog();
				});
			}
			else
				list = false;
		}

		async Task updateTasks()
		{
			while (true)
			{
				switch (TaskVars.task)
				{
					case "move":
						check(0);
						break;
					case "farm":
						check(1);
						break;
					case "catch":
						check(2);
						break;
					case "transfer":
						check(3);
						break;
					case "evolve":
						check(4);
						break;
					case "discard":
						check(5);
						break;
				}
				await Task.Delay(5);
			}
		}


		private void check(int item)
		{
			switch (item)
			{
				case 0:
					idle.Checked = true;
					farm.Checked = false;
					catchpoke.Checked = false;
					transfer.Checked = false;
					evolve.Checked = false;
					discard.Checked = false;
					break;
				case 1:
					idle.Checked = false;
					farm.Checked = true;
					catchpoke.Checked = false;
					transfer.Checked = false;
					evolve.Checked = false;
					discard.Checked = false;
					break;
				case 2:
					idle.Checked = false;
					farm.Checked = false;
					catchpoke.Checked = true;
					transfer.Checked = false;
					evolve.Checked = false;
					discard.Checked = false;
					break;
				case 3:
					idle.Checked = false;
					farm.Checked = false;
					catchpoke.Checked = false;
					transfer.Checked = true;
					evolve.Checked = false;
					discard.Checked = false;
					break;
				case 4:
					idle.Checked = false;
					farm.Checked = false;
					catchpoke.Checked = false;
					transfer.Checked = false;
					evolve.Checked = true;
					discard.Checked = false;
					break;
				case 5:
					idle.Checked = false;
					farm.Checked = false;
					catchpoke.Checked = false;
					transfer.Checked = false;
					evolve.Checked = false;
					discard.Checked = true;
					break;
			}
		}

		async Task update()
		{
			while (true)
			{
				if (Vars.update)
				{
					this.username.Text = "User: " + Vars.username;
					xprate.Text = "XP/Hour: " + Vars.xprate;
					catchrate.Text = "Pokemon/Hour: " + Vars.catchrate;
					evolvecount.Text = "Pokemon to Evolve: " + Vars.evolvecount;
					pokemon.Text = "Pokemon: " + Vars.pokemon;
					items.Text = "Items: " + Vars.items;
					stardust.Text = "Stardust: " + Vars.stardust;
					progress.Text = Vars.level;
					levelbar.Value = int.Parse(Vars.percentage);
					Vars.update = false;
				}

				else
				{
					await Task.Delay(5000);
				}


			}
		}


		private void togglelist_Click(object sender, EventArgs e)
		{
			if (list)
			{
				Task.Run(() =>
				{
					list = false;
					pokemonList.Hide();
				});
			}
			else
			{
				Task.Run(() =>
				{
					list = true;
					pokemonList.ShowDialog();
				});
			}
		}

		public void toggleconsole_Click(object sender, EventArgs e)
		{
			if (console)
			{
				var handle = GetConsoleWindow();
				ShowWindow(handle, SW_HIDE);
				console = false;
			}
			else
			{
				var handle = GetConsoleWindow();
				ShowWindow(handle, SW_SHOW);
				console = true;
			}
		}

		private void Stats_FormClosed(object sender, FormClosedEventArgs e)
		{
			System.Environment.Exit(0);
		}

		
	}
}
