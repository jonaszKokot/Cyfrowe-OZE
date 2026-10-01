using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Odnawialne_Źródła_Energii.Properties;

namespace Odnawialne_Źródła_Energii;

public class Start : Form
{
	public int pk;

	private IContainer components = null;

	private Panel panelMenu;

	private Panel panelNavbar;

	private Panel panelMainDefoult;

	private PictureBox pictureBox1;

	private Button buttonUrządzenia;

	private Button buttonPodsumowanie;

	private Button buttonŹródłaPrądu;

	private Button buttonInformacje;

	private Panel panelBackKalkulator;

	private Button buttonKalkulator;

	private Button buttonSegregacja;

	private Label labelTitle;

	private TextBox textBoxPk;

	private Label labelPk;

	private Button buttonJakPomócPlanecie;

	public Start()
	{
		InitializeComponent();
		customizeDesign();
		hideSelectItemFromMenu();
		Informacje_Click(null, EventArgs.Empty);
	}

	public void buttonŹródłaPrądu_Click(object sender, EventArgs e)
	{
		labelTitle.Text = "Źódła prądu";
		hideSelectItemFromMenu();
		buttonŹródłaPrądu.ForeColor = Color.FromArgb(46, 183, 87);
		panelMainDefoult.Controls.Clear();
		ListaŹródeł ListaŹródeł_vrb = new ListaŹródeł(this)
		{
			Dock = DockStyle.Fill,
			TopLevel = false,
			TopMost = true
		};
		ListaŹródeł_vrb.FormBorderStyle = FormBorderStyle.None;
		panelMainDefoult.Controls.Add(ListaŹródeł_vrb);
		ListaŹródeł_vrb.Show();
	}

	private void buttonUrządzenia_Click(object sender, EventArgs e)
	{
		labelTitle.Text = "Urządzenia zasilane prądem";
		hideSelectItemFromMenu();
		buttonUrządzenia.ForeColor = Color.FromArgb(46, 183, 87);
		panelMainDefoult.Controls.Clear();
		ListaNarzędzi ListaNarzędzi_vrb = new ListaNarzędzi(this)
		{
			Dock = DockStyle.Fill,
			TopLevel = false,
			TopMost = true
		};
		ListaNarzędzi_vrb.FormBorderStyle = FormBorderStyle.None;
		panelMainDefoult.Controls.Add(ListaNarzędzi_vrb);
		ListaNarzędzi_vrb.Show();
	}

	public void buttonPodsumowanie_Click(object sender, EventArgs e)
	{
		labelTitle.Text = "Podsumowanie";
		hideSelectItemFromMenu();
		buttonPodsumowanie.ForeColor = Color.FromArgb(46, 183, 87);
		panelMainDefoult.Controls.Clear();
		Podsumowanie Podsumowanie_vrb = new Podsumowanie
		{
			Dock = DockStyle.Fill,
			TopLevel = false,
			TopMost = true
		};
		Podsumowanie_vrb.FormBorderStyle = FormBorderStyle.None;
		panelMainDefoult.Controls.Add(Podsumowanie_vrb);
		Podsumowanie_vrb.Show();
	}

	private void Informacje_Click(object sender, EventArgs e)
	{
		hideMenuCalc();
		labelTitle.Text = "Informacje o OZN";
		hideSelectItemFromMenu();
		buttonInformacje.ForeColor = Color.FromArgb(46, 183, 87);
		panelMainDefoult.Controls.Clear();
		Informacje Informacje_vrb = new Informacje
		{
			Dock = DockStyle.Fill,
			TopLevel = false,
			TopMost = true
		};
		Informacje_vrb.FormBorderStyle = FormBorderStyle.None;
		panelMainDefoult.Controls.Add(Informacje_vrb);
		Informacje_vrb.Show();
	}

	private void buttonJakPomócPlanecie_Click(object sender, EventArgs e)
	{
		hideMenuCalc();
		labelTitle.Text = "Jak Pomóc Planecie";
		hideSelectItemFromMenu();
		buttonJakPomócPlanecie.ForeColor = Color.FromArgb(46, 183, 87);
		panelMainDefoult.Controls.Clear();
		JakPomócPlanecie JakPomócPlanecie_vrb = new JakPomócPlanecie
		{
			Dock = DockStyle.Fill,
			TopLevel = false,
			TopMost = true
		};
		JakPomócPlanecie_vrb.FormBorderStyle = FormBorderStyle.None;
		panelMainDefoult.Controls.Add(JakPomócPlanecie_vrb);
		JakPomócPlanecie_vrb.Show();
	}

	public void buttonSegregacja_Click(object sender, EventArgs e)
	{
		pk = 0;
		hideMenuCalc();
		labelTitle.Text = "Segreguj Śmieci";
		hideSelectItemFromMenu();
		labelPk.Visible = true;
		textBoxPk.Visible = true;
		showPk();
		buttonSegregacja.ForeColor = Color.FromArgb(46, 183, 87);
		panelMainDefoult.Controls.Clear();
		SortowanieŚmieic SortowanieŚmieic_vrb = new SortowanieŚmieic(this)
		{
			Dock = DockStyle.Fill,
			TopLevel = false,
			TopMost = true
		};
		SortowanieŚmieic_vrb.FormBorderStyle = FormBorderStyle.None;
		panelMainDefoult.Controls.Add(SortowanieŚmieic_vrb);
		SortowanieŚmieic_vrb.Show();
	}

	private void hideSelectItemFromMenu()
	{
		buttonSegregacja.ForeColor = Color.FromArgb(224, 224, 224);
		buttonŹródłaPrądu.ForeColor = Color.FromArgb(224, 224, 224);
		buttonPodsumowanie.ForeColor = Color.FromArgb(224, 224, 224);
		buttonInformacje.ForeColor = Color.FromArgb(224, 224, 224);
		buttonUrządzenia.ForeColor = Color.FromArgb(224, 224, 224);
		buttonJakPomócPlanecie.ForeColor = Color.FromArgb(224, 224, 224);
		labelPk.Visible = false;
		textBoxPk.Visible = false;
	}

	public void showPk()
	{
		textBoxPk.Text = pk.ToString();
	}

	private void customizeDesign()
	{
		buttonUrządzenia.Visible = true;
		buttonŹródłaPrądu.Visible = true;
		buttonPodsumowanie.Visible = true;
		panelBackKalkulator.Visible = false;
	}

	private void hideMenuCalc()
	{
		if (buttonUrządzenia.Visible)
		{
			buttonUrządzenia.Visible = false;
		}
		if (buttonŹródłaPrądu.Visible)
		{
			buttonŹródłaPrądu.Visible = false;
		}
		if (buttonPodsumowanie.Visible)
		{
			buttonPodsumowanie.Visible = false;
		}
		panelBackKalkulator.Visible = false;
	}

	private void showMenuCalc()
	{
		if (!buttonUrządzenia.Visible)
		{
			buttonUrządzenia.Visible = true;
		}
		if (!buttonŹródłaPrądu.Visible)
		{
			buttonŹródłaPrądu.Visible = true;
		}
		if (!buttonPodsumowanie.Visible)
		{
			buttonPodsumowanie.Visible = true;
		}
		panelBackKalkulator.Visible = true;
	}

	private void buttonKalkulator_Click(object sender, EventArgs e)
	{
		buttonUrządzenia_Click(null, EventArgs.Empty);
		if (!panelBackKalkulator.Visible)
		{
			showMenuCalc();
		}
		else
		{
			hideMenuCalc();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odnawialne_Źródła_Energii.Start));
		this.panelMenu = new System.Windows.Forms.Panel();
		this.buttonJakPomócPlanecie = new System.Windows.Forms.Button();
		this.buttonSegregacja = new System.Windows.Forms.Button();
		this.panelBackKalkulator = new System.Windows.Forms.Panel();
		this.buttonPodsumowanie = new System.Windows.Forms.Button();
		this.buttonŹródłaPrądu = new System.Windows.Forms.Button();
		this.buttonUrządzenia = new System.Windows.Forms.Button();
		this.buttonKalkulator = new System.Windows.Forms.Button();
		this.buttonInformacje = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panelNavbar = new System.Windows.Forms.Panel();
		this.textBoxPk = new System.Windows.Forms.TextBox();
		this.labelPk = new System.Windows.Forms.Label();
		this.labelTitle = new System.Windows.Forms.Label();
		this.panelMainDefoult = new System.Windows.Forms.Panel();
		this.panelMenu.SuspendLayout();
		this.panelBackKalkulator.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panelNavbar.SuspendLayout();
		base.SuspendLayout();
		resources.ApplyResources(this.panelMenu, "panelMenu");
		this.panelMenu.BackColor = System.Drawing.Color.FromArgb(38, 39, 59);
		this.panelMenu.Controls.Add(this.buttonJakPomócPlanecie);
		this.panelMenu.Controls.Add(this.buttonSegregacja);
		this.panelMenu.Controls.Add(this.panelBackKalkulator);
		this.panelMenu.Controls.Add(this.buttonKalkulator);
		this.panelMenu.Controls.Add(this.buttonInformacje);
		this.panelMenu.Controls.Add(this.pictureBox1);
		this.panelMenu.Name = "panelMenu";
		resources.ApplyResources(this.buttonJakPomócPlanecie, "buttonJakPomócPlanecie");
		this.buttonJakPomócPlanecie.FlatAppearance.BorderSize = 0;
		this.buttonJakPomócPlanecie.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.buttonJakPomócPlanecie.Name = "buttonJakPomócPlanecie";
		this.buttonJakPomócPlanecie.UseVisualStyleBackColor = true;
		this.buttonJakPomócPlanecie.Click += new System.EventHandler(this.buttonJakPomócPlanecie_Click);
		resources.ApplyResources(this.buttonSegregacja, "buttonSegregacja");
		this.buttonSegregacja.FlatAppearance.BorderSize = 0;
		this.buttonSegregacja.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.buttonSegregacja.Name = "buttonSegregacja";
		this.buttonSegregacja.UseVisualStyleBackColor = true;
		this.buttonSegregacja.Click += new System.EventHandler(this.buttonSegregacja_Click);
		this.panelBackKalkulator.BackColor = System.Drawing.Color.FromArgb(57, 65, 65);
		this.panelBackKalkulator.Controls.Add(this.buttonPodsumowanie);
		this.panelBackKalkulator.Controls.Add(this.buttonŹródłaPrądu);
		this.panelBackKalkulator.Controls.Add(this.buttonUrządzenia);
		resources.ApplyResources(this.panelBackKalkulator, "panelBackKalkulator");
		this.panelBackKalkulator.Name = "panelBackKalkulator";
		this.buttonPodsumowanie.BackColor = System.Drawing.Color.FromArgb(51, 51, 71);
		resources.ApplyResources(this.buttonPodsumowanie, "buttonPodsumowanie");
		this.buttonPodsumowanie.FlatAppearance.BorderSize = 0;
		this.buttonPodsumowanie.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.buttonPodsumowanie.Name = "buttonPodsumowanie";
		this.buttonPodsumowanie.UseVisualStyleBackColor = false;
		this.buttonPodsumowanie.Click += new System.EventHandler(this.buttonPodsumowanie_Click);
		this.buttonŹródłaPrądu.BackColor = System.Drawing.Color.FromArgb(51, 51, 71);
		resources.ApplyResources(this.buttonŹródłaPrądu, "buttonŹródłaPrądu");
		this.buttonŹródłaPrądu.FlatAppearance.BorderSize = 0;
		this.buttonŹródłaPrądu.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.buttonŹródłaPrądu.Name = "buttonŹródłaPrądu";
		this.buttonŹródłaPrądu.UseVisualStyleBackColor = false;
		this.buttonŹródłaPrądu.Click += new System.EventHandler(this.buttonŹródłaPrądu_Click);
		this.buttonUrządzenia.BackColor = System.Drawing.Color.FromArgb(51, 51, 71);
		resources.ApplyResources(this.buttonUrządzenia, "buttonUrządzenia");
		this.buttonUrządzenia.FlatAppearance.BorderSize = 0;
		this.buttonUrządzenia.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.buttonUrządzenia.Name = "buttonUrządzenia";
		this.buttonUrządzenia.UseVisualStyleBackColor = false;
		this.buttonUrządzenia.Click += new System.EventHandler(this.buttonUrządzenia_Click);
		resources.ApplyResources(this.buttonKalkulator, "buttonKalkulator");
		this.buttonKalkulator.FlatAppearance.BorderSize = 0;
		this.buttonKalkulator.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.buttonKalkulator.Name = "buttonKalkulator";
		this.buttonKalkulator.UseVisualStyleBackColor = true;
		this.buttonKalkulator.Click += new System.EventHandler(this.buttonKalkulator_Click);
		resources.ApplyResources(this.buttonInformacje, "buttonInformacje");
		this.buttonInformacje.FlatAppearance.BorderSize = 0;
		this.buttonInformacje.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.buttonInformacje.Name = "buttonInformacje";
		this.buttonInformacje.UseVisualStyleBackColor = true;
		this.buttonInformacje.Click += new System.EventHandler(this.Informacje_Click);
		this.pictureBox1.BackgroundImage = Odnawialne_Źródła_Energii.Properties.Resources.Logo_OZN4;
		resources.ApplyResources(this.pictureBox1, "pictureBox1");
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.TabStop = false;
		resources.ApplyResources(this.panelNavbar, "panelNavbar");
		this.panelNavbar.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.panelNavbar.Controls.Add(this.textBoxPk);
		this.panelNavbar.Controls.Add(this.labelPk);
		this.panelNavbar.Controls.Add(this.labelTitle);
		this.panelNavbar.Name = "panelNavbar";
		this.textBoxPk.BackColor = System.Drawing.Color.FromArgb(112, 229, 144);
		this.textBoxPk.BorderStyle = System.Windows.Forms.BorderStyle.None;
		resources.ApplyResources(this.textBoxPk, "textBoxPk");
		this.textBoxPk.Name = "textBoxPk";
		resources.ApplyResources(this.labelPk, "labelPk");
		this.labelPk.ForeColor = System.Drawing.Color.FromArgb(112, 229, 144);
		this.labelPk.Name = "labelPk";
		resources.ApplyResources(this.labelTitle, "labelTitle");
		this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(112, 229, 144);
		this.labelTitle.Name = "labelTitle";
		resources.ApplyResources(this.panelMainDefoult, "panelMainDefoult");
		this.panelMainDefoult.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.panelMainDefoult.Name = "panelMainDefoult";
		resources.ApplyResources(this, "$this");
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		base.Controls.Add(this.panelMainDefoult);
		base.Controls.Add(this.panelNavbar);
		base.Controls.Add(this.panelMenu);
		base.Name = "Start";
		this.panelMenu.ResumeLayout(false);
		this.panelBackKalkulator.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panelNavbar.ResumeLayout(false);
		this.panelNavbar.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
