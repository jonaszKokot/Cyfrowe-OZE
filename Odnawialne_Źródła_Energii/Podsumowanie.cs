using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Odnawialne_Źródła_Energii;

public class Podsumowanie : Form
{
	private MachineRepository machineRepository;

	private SourcesRepository sourcesRepository;

	private float energyUse = 0f;

	private float energyProduced = 0f;

	private float cost = 0f;

	private IContainer components = null;

	private Label labelSumEnergy;

	private Label labelEnergyProduced;

	private TextBox textBoxSumEnergyUse;

	private TextBox textBoxEnergyProduced;

	private TextBox textBoxSumEnergy;

	private Label labelSumEnergyUse;

	private Panel panel1;

	private Label label3;

	private Label label1;

	private Label label2;

	private Label label5;

	private TextBox textBoxCost;

	private Label label4;

	private Label label6;

	private TextBox textBoxSunCost;

	private Label label7;

	public Podsumowanie()
	{
		InitializeComponent();
		machineRepository = new MachineRepository();
		sourcesRepository = new SourcesRepository();
		textBoxSumEnergyUse.Text = machineRepository.GetSumOfUsage();
		textBoxEnergyProduced.Text = sourcesRepository.GetSumOfUsage();
		doCalculation();
	}

	private void doCalculation()
	{
		try
		{
			energyUse = Convert.ToSingle(textBoxSumEnergyUse.Text);
		}
		catch (FormatException)
		{
			textBoxSumEnergy.Text = energyUse.ToString();
		}
		try
		{
			energyProduced = Convert.ToSingle(textBoxEnergyProduced.Text);
		}
		catch (FormatException)
		{
			textBoxEnergyProduced.Text = energyProduced.ToString();
		}
		try
		{
			textBoxSumEnergy.Text = ((energyUse + energyProduced) / 100000f).ToString();
		}
		catch (FormatException)
		{
		}
		try
		{
			cost = Convert.ToSingle(textBoxCost.Text);
		}
		catch (FormatException)
		{
		}
	}

	private void textBoxCost_TextChanged(object sender, EventArgs e)
	{
		doCalculation();
		textBoxSunCost.Text = Convert.ToString(cost * (energyProduced - energyUse));
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
		this.labelSumEnergy = new System.Windows.Forms.Label();
		this.labelEnergyProduced = new System.Windows.Forms.Label();
		this.textBoxSumEnergyUse = new System.Windows.Forms.TextBox();
		this.textBoxEnergyProduced = new System.Windows.Forms.TextBox();
		this.textBoxSumEnergy = new System.Windows.Forms.TextBox();
		this.labelSumEnergyUse = new System.Windows.Forms.Label();
		this.panel1 = new System.Windows.Forms.Panel();
		this.label5 = new System.Windows.Forms.Label();
		this.textBoxCost = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.textBoxSunCost = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.labelSumEnergy.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.labelSumEnergy.AutoSize = true;
		this.labelSumEnergy.Font = new System.Drawing.Font("Arial", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.labelSumEnergy.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelSumEnergy.Location = new System.Drawing.Point(3, 134);
		this.labelSumEnergy.Name = "labelSumEnergy";
		this.labelSumEnergy.Size = new System.Drawing.Size(59, 22);
		this.labelSumEnergy.TabIndex = 5;
		this.labelSumEnergy.Text = "Suma";
		this.labelEnergyProduced.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.labelEnergyProduced.AutoSize = true;
		this.labelEnergyProduced.Font = new System.Drawing.Font("Arial", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.labelEnergyProduced.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelEnergyProduced.Location = new System.Drawing.Point(3, 79);
		this.labelEnergyProduced.Name = "labelEnergyProduced";
		this.labelEnergyProduced.Size = new System.Drawing.Size(214, 22);
		this.labelEnergyProduced.TabIndex = 4;
		this.labelEnergyProduced.Text = "Energia wyprodukowana";
		this.textBoxSumEnergyUse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.textBoxSumEnergyUse.BackColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.textBoxSumEnergyUse.Location = new System.Drawing.Point(332, 24);
		this.textBoxSumEnergyUse.Name = "textBoxSumEnergyUse";
		this.textBoxSumEnergyUse.ReadOnly = true;
		this.textBoxSumEnergyUse.Size = new System.Drawing.Size(192, 20);
		this.textBoxSumEnergyUse.TabIndex = 1;
		this.textBoxEnergyProduced.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.textBoxEnergyProduced.BackColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.textBoxEnergyProduced.Location = new System.Drawing.Point(332, 79);
		this.textBoxEnergyProduced.Name = "textBoxEnergyProduced";
		this.textBoxEnergyProduced.ReadOnly = true;
		this.textBoxEnergyProduced.Size = new System.Drawing.Size(192, 20);
		this.textBoxEnergyProduced.TabIndex = 2;
		this.textBoxSumEnergy.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.textBoxSumEnergy.BackColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.textBoxSumEnergy.Location = new System.Drawing.Point(332, 134);
		this.textBoxSumEnergy.Name = "textBoxSumEnergy";
		this.textBoxSumEnergy.ReadOnly = true;
		this.textBoxSumEnergy.Size = new System.Drawing.Size(192, 20);
		this.textBoxSumEnergy.TabIndex = 2;
		this.labelSumEnergyUse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.labelSumEnergyUse.AutoSize = true;
		this.labelSumEnergyUse.Font = new System.Drawing.Font("Arial", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.labelSumEnergyUse.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelSumEnergyUse.Location = new System.Drawing.Point(3, 24);
		this.labelSumEnergyUse.Name = "labelSumEnergyUse";
		this.labelSumEnergyUse.Size = new System.Drawing.Size(132, 22);
		this.labelSumEnergyUse.TabIndex = 3;
		this.labelSumEnergyUse.Text = "Energia zużyta";
		this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.panel1.AutoSize = true;
		this.panel1.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.textBoxCost);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.textBoxSumEnergyUse);
		this.panel1.Controls.Add(this.labelSumEnergy);
		this.panel1.Controls.Add(this.labelSumEnergyUse);
		this.panel1.Controls.Add(this.textBoxEnergyProduced);
		this.panel1.Controls.Add(this.textBoxSumEnergy);
		this.panel1.Controls.Add(this.labelEnergyProduced);
		this.panel1.Location = new System.Drawing.Point(171, 137);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(596, 232);
		this.panel1.TabIndex = 10;
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label5.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label5.Location = new System.Drawing.Point(526, 191);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(18, 16);
		this.label5.TabIndex = 12;
		this.label5.Text = "zł";
		this.textBoxCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.textBoxCost.BackColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.textBoxCost.Location = new System.Drawing.Point(332, 189);
		this.textBoxCost.Name = "textBoxCost";
		this.textBoxCost.Size = new System.Drawing.Size(192, 20);
		this.textBoxCost.TabIndex = 0;
		this.textBoxCost.TextChanged += new System.EventHandler(this.textBoxCost_TextChanged);
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Arial", 14.25f);
		this.label4.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label4.Location = new System.Drawing.Point(3, 189);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(236, 22);
		this.label4.TabIndex = 10;
		this.label4.Text = "Koszt energii w twoim kraju";
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label3.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label3.Location = new System.Drawing.Point(526, 137);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(35, 16);
		this.label3.TabIndex = 9;
		this.label3.Text = "kWh";
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label1.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label1.Location = new System.Drawing.Point(526, 82);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(21, 16);
		this.label1.TabIndex = 8;
		this.label1.Text = "W";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label2.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label2.Location = new System.Drawing.Point(526, 26);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(21, 16);
		this.label2.TabIndex = 7;
		this.label2.Text = "W";
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Arial", 14.25f);
		this.label6.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label6.Location = new System.Drawing.Point(173, 382);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(215, 22);
		this.label6.TabIndex = 13;
		this.label6.Text = "Koszt zapłaconej energii";
		this.textBoxSunCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.textBoxSunCost.BackColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.textBoxSunCost.Location = new System.Drawing.Point(503, 386);
		this.textBoxSunCost.Name = "textBoxSunCost";
		this.textBoxSunCost.ReadOnly = true;
		this.textBoxSunCost.Size = new System.Drawing.Size(192, 20);
		this.textBoxSunCost.TabIndex = 4;
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label7.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label7.Location = new System.Drawing.Point(697, 387);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(18, 16);
		this.label7.TabIndex = 13;
		this.label7.Text = "zł";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoSize = true;
		this.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.ClientSize = new System.Drawing.Size(910, 509);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.textBoxSunCost);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.panel1);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "Podsumowanie";
		this.Text = "Podsumowanie";
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
