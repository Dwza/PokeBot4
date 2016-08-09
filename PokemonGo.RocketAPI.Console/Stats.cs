using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PokemonGo.RocketAPI.Logic;
using POGOProtos.Inventory.Item;
namespace PokemonGo.RocketAPI.Console
{

	public partial class Stats : Form
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
		public Stats()
		{
			InitializeComponent();
			Task.Run(update);
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

		async Task update()
		{
			while (true)
			{
				if (Vars.update)
				{
					//broken rn
					//await Task.Run(getItems);
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
				
				
			}
		}
		async Task getItems()
		{
			var inventoryDump = await new Logic.Logic(new Settings(), new LogicInfoObservable())._client.Inventory.GetItems();
			var inventory = inventoryDump.ToList();
			foreach (var invItem in inventory)
			{
				if (invItem.Unseen == false)
				{
					switch (invItem.ItemId)
					{
						case ItemId.ItemPokeBall:
							pokeballs.Text = invItem.Count + " PokeBalls";
							break;
						case ItemId.ItemGreatBall:
							greatballs.Text = invItem.Count + " GreatBalls";
							break;
						case ItemId.ItemUltraBall:
							ultraballs.Text = invItem.Count + " UltraBalls";
							break;
						case ItemId.ItemMasterBall:
							greatballs.Text = invItem.Count + " MasterBalls";
							break;
						case ItemId.ItemPotion:
							potions.Text = invItem.Count + " Potions";
							break;
						case ItemId.ItemSuperPotion:
							superpotions.Text = invItem.Count + " SuperPotions";
							break;
						case ItemId.ItemHyperPotion:
							hyperpotions.Text = invItem.Count + " HyperPotions";
							break;
						case ItemId.ItemMaxPotion:
							maxpotions.Text = invItem.Count + " MaxPotions";
							break;
						case ItemId.ItemRevive:
							revives.Text = invItem.Count + " Revives";
							break;
						case ItemId.ItemMaxRevive:
							maxrevives.Text = invItem.Count + " MaxRevives";
							break;
						case ItemId.ItemIncenseOrdinary:
							incense.Text = invItem.Count + " Incense";
							break;
						case ItemId.ItemLuckyEgg:
							luckyegg.Text = invItem.Count + " LuckyEggs";
							break;
						case ItemId.ItemRazzBerry:
							luckyegg.Text = invItem.Count + " Berries";
							break;

						default: break;

					}
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