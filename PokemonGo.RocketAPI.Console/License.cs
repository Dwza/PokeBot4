using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace PokemonGo.RocketAPI.Console
{
	public partial class License : Form
	{
		private const int CP_NOCLOSE_BUTTON = 0x200;
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams myCp = base.CreateParams;
				myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
				return myCp;
			}
		}
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
				Globals.licensekey = textBox1.Text;
				Globals.licensed = true;
				this.Dispose();
			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Globals.licensekey = "Free";
			Globals.licensed = false;
			this.Dispose();
		}
	}
}
