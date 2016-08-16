using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace PokemonGo.RocketAPI.Console
{
	public partial class License : Form
	{
		public License()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			JObject license = JObject.Parse(Auth.auth(textBox1.Text));
			if(license["key"] == null)
			{
				MessageBox.Show(this, "Key invalid, locked or expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show(this, "License for User " + license["customer_name"] + " was successfully activated. Enjoy your features!", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
				System.Console.WriteLine("-----License Info-----");
				System.Console.WriteLine("Key: " + license["key"]);
				System.Console.WriteLine("ID: " + license["purchase_id"]);
				System.Console.WriteLine("Rank: " + license["purchase_name"]);
				System.Console.WriteLine("Licensed to: " + license["customer_name"]);
				System.Console.WriteLine("-----License Info-----");
				Globals.licensekey = textBox1.Text;
				this.Dispose();
			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Globals.licensekey = "Free";
			this.Dispose();
		}
	}
}
