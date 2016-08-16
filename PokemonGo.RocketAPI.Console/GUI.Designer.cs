namespace PokemonGo.RocketAPI.Console
{
	partial class GUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
			this.progress = new MetroFramework.Controls.MetroLabel();
			this.stardust = new MetroFramework.Controls.MetroLabel();
			this.items = new MetroFramework.Controls.MetroLabel();
			this.pokemon = new MetroFramework.Controls.MetroLabel();
			this.evolvecount = new MetroFramework.Controls.MetroLabel();
			this.catchrate = new MetroFramework.Controls.MetroLabel();
			this.xprate = new MetroFramework.Controls.MetroLabel();
			this.username = new MetroFramework.Controls.MetroLabel();
			this.levelbar = new MetroFramework.Controls.MetroProgressBar();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.evolve = new MetroFramework.Controls.MetroRadioButton();
			this.discard = new MetroFramework.Controls.MetroRadioButton();
			this.transfer = new MetroFramework.Controls.MetroRadioButton();
			this.idle = new MetroFramework.Controls.MetroRadioButton();
			this.catchpoke = new MetroFramework.Controls.MetroRadioButton();
			this.farm = new MetroFramework.Controls.MetroRadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.metroLabel9);
			this.groupBox1.Controls.Add(this.progress);
			this.groupBox1.Controls.Add(this.stardust);
			this.groupBox1.Controls.Add(this.items);
			this.groupBox1.Controls.Add(this.pokemon);
			this.groupBox1.Controls.Add(this.evolvecount);
			this.groupBox1.Controls.Add(this.catchrate);
			this.groupBox1.Controls.Add(this.xprate);
			this.groupBox1.Controls.Add(this.username);
			this.groupBox1.Controls.Add(this.levelbar);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(23, 63);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(311, 203);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stats";
			// 
			// metroLabel9
			// 
			this.metroLabel9.AutoSize = true;
			this.metroLabel9.Location = new System.Drawing.Point(2, 174);
			this.metroLabel9.Name = "metroLabel9";
			this.metroLabel9.Size = new System.Drawing.Size(137, 19);
			this.metroLabel9.TabIndex = 9;
			this.metroLabel9.Text = "Progress to next Level";
			// 
			// progress
			// 
			this.progress.AutoSize = true;
			this.progress.Location = new System.Drawing.Point(6, 149);
			this.progress.Name = "progress";
			this.progress.Size = new System.Drawing.Size(62, 19);
			this.progress.TabIndex = 8;
			this.progress.Text = "Unknown";
			// 
			// stardust
			// 
			this.stardust.AutoSize = true;
			this.stardust.Location = new System.Drawing.Point(6, 132);
			this.stardust.Name = "stardust";
			this.stardust.Size = new System.Drawing.Size(56, 19);
			this.stardust.TabIndex = 7;
			this.stardust.Text = "Stardust";
			// 
			// items
			// 
			this.items.AutoSize = true;
			this.items.Location = new System.Drawing.Point(6, 113);
			this.items.Name = "items";
			this.items.Size = new System.Drawing.Size(43, 19);
			this.items.TabIndex = 6;
			this.items.Text = "Items:";
			// 
			// pokemon
			// 
			this.pokemon.AutoSize = true;
			this.pokemon.Location = new System.Drawing.Point(6, 94);
			this.pokemon.Name = "pokemon";
			this.pokemon.Size = new System.Drawing.Size(67, 19);
			this.pokemon.TabIndex = 5;
			this.pokemon.Text = "Pokemon:";
			// 
			// evolvecount
			// 
			this.evolvecount.AutoSize = true;
			this.evolvecount.Location = new System.Drawing.Point(6, 75);
			this.evolvecount.Name = "evolvecount";
			this.evolvecount.Size = new System.Drawing.Size(124, 19);
			this.evolvecount.TabIndex = 4;
			this.evolvecount.Text = "Pokemon to Evolve:";
			// 
			// catchrate
			// 
			this.catchrate.AutoSize = true;
			this.catchrate.Location = new System.Drawing.Point(6, 56);
			this.catchrate.Name = "catchrate";
			this.catchrate.Size = new System.Drawing.Size(102, 19);
			this.catchrate.TabIndex = 3;
			this.catchrate.Text = "Pokemon/Hour:";
			// 
			// xprate
			// 
			this.xprate.AutoSize = true;
			this.xprate.Location = new System.Drawing.Point(6, 37);
			this.xprate.Name = "xprate";
			this.xprate.Size = new System.Drawing.Size(63, 19);
			this.xprate.TabIndex = 2;
			this.xprate.Text = "XP/Hour:";
			// 
			// username
			// 
			this.username.AutoSize = true;
			this.username.Location = new System.Drawing.Point(6, 18);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(39, 19);
			this.username.TabIndex = 1;
			this.username.Text = "User:";
			// 
			// levelbar
			// 
			this.levelbar.Location = new System.Drawing.Point(145, 173);
			this.levelbar.Name = "levelbar";
			this.levelbar.Size = new System.Drawing.Size(160, 23);
			this.levelbar.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.evolve);
			this.groupBox2.Controls.Add(this.discard);
			this.groupBox2.Controls.Add(this.transfer);
			this.groupBox2.Controls.Add(this.idle);
			this.groupBox2.Controls.Add(this.catchpoke);
			this.groupBox2.Controls.Add(this.farm);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox2.Location = new System.Drawing.Point(23, 272);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(311, 153);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Actions";
			// 
			// evolve
			// 
			this.evolve.AutoSize = true;
			this.evolve.Enabled = false;
			this.evolve.Location = new System.Drawing.Point(7, 106);
			this.evolve.Name = "evolve";
			this.evolve.Size = new System.Drawing.Size(111, 15);
			this.evolve.TabIndex = 5;
			this.evolve.Text = "Evolve Pokemon";
			this.evolve.UseCustomForeColor = true;
			this.evolve.UseSelectable = true;
			// 
			// discard
			// 
			this.discard.AutoSize = true;
			this.discard.Enabled = false;
			this.discard.Location = new System.Drawing.Point(7, 127);
			this.discard.Name = "discard";
			this.discard.Size = new System.Drawing.Size(94, 15);
			this.discard.TabIndex = 4;
			this.discard.Text = "Discard Items";
			this.discard.UseCustomForeColor = true;
			this.discard.UseSelectable = true;
			// 
			// transfer
			// 
			this.transfer.AutoSize = true;
			this.transfer.Enabled = false;
			this.transfer.Location = new System.Drawing.Point(7, 85);
			this.transfer.Name = "transfer";
			this.transfer.Size = new System.Drawing.Size(119, 15);
			this.transfer.TabIndex = 3;
			this.transfer.Text = "Transfer Pokemon";
			this.transfer.UseCustomForeColor = true;
			this.transfer.UseSelectable = true;
			// 
			// idle
			// 
			this.idle.AutoSize = true;
			this.idle.Enabled = false;
			this.idle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.idle.Location = new System.Drawing.Point(7, 22);
			this.idle.Name = "idle";
			this.idle.Size = new System.Drawing.Size(77, 15);
			this.idle.TabIndex = 2;
			this.idle.Text = "Move/Idle";
			this.idle.UseCustomForeColor = true;
			this.idle.UseSelectable = true;
			// 
			// catchpoke
			// 
			this.catchpoke.AutoSize = true;
			this.catchpoke.Enabled = false;
			this.catchpoke.Location = new System.Drawing.Point(7, 64);
			this.catchpoke.Name = "catchpoke";
			this.catchpoke.Size = new System.Drawing.Size(108, 15);
			this.catchpoke.TabIndex = 1;
			this.catchpoke.Text = "Catch Pokemon";
			this.catchpoke.UseCustomForeColor = true;
			this.catchpoke.UseSelectable = true;
			// 
			// farm
			// 
			this.farm.AutoSize = true;
			this.farm.Enabled = false;
			this.farm.Location = new System.Drawing.Point(7, 43);
			this.farm.Name = "farm";
			this.farm.Size = new System.Drawing.Size(107, 15);
			this.farm.TabIndex = 0;
			this.farm.Text = "Farm Pokestops";
			this.farm.UseCustomForeColor = true;
			this.farm.UseSelectable = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.metroButton2);
			this.groupBox3.Controls.Add(this.metroButton1);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox3.Location = new System.Drawing.Point(23, 431);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(311, 56);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Control";
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(208, 21);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(97, 23);
			this.metroButton2.TabIndex = 1;
			this.metroButton2.Text = "Toggle PokeList";
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new System.EventHandler(this.togglelist_Click);
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(7, 21);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(132, 23);
			this.metroButton1.TabIndex = 0;
			this.metroButton1.Text = "Toggle Log (for errors)";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.toggleconsole_Click);
			// 
			// GUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 500);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.Name = "GUI";
			this.Resizable = false;
			this.Text = "PokeBot";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Stats_FormClosed);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private MetroFramework.Controls.MetroProgressBar levelbar;
		private MetroFramework.Controls.MetroLabel metroLabel9;
		private MetroFramework.Controls.MetroLabel progress;
		private MetroFramework.Controls.MetroLabel stardust;
		private MetroFramework.Controls.MetroLabel items;
		private MetroFramework.Controls.MetroLabel pokemon;
		private MetroFramework.Controls.MetroLabel evolvecount;
		private MetroFramework.Controls.MetroLabel catchrate;
		private MetroFramework.Controls.MetroLabel xprate;
		private MetroFramework.Controls.MetroLabel username;
		private MetroFramework.Controls.MetroRadioButton discard;
		private MetroFramework.Controls.MetroRadioButton transfer;
		private MetroFramework.Controls.MetroRadioButton idle;
		private MetroFramework.Controls.MetroRadioButton catchpoke;
		private MetroFramework.Controls.MetroRadioButton farm;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroRadioButton evolve;
	}
}