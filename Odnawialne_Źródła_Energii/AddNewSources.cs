using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Odnawialne_Źródła_Energii;

public class AddNewSources : Form
{
	private SourcesRepository sourcesRepository = new SourcesRepository();

	private ListaŹródeł listaŹródeł;

	private IContainer components = null;

	private Button buttonAdd;

	private TextBox textBoxMoc;

	private TextBox textBoxSprawność;

	private TextBox textBoxNazwa;

	private Label labelSprawność;

	private Label labelMoc;

	private Label labelNazwa;

	private TextBox textBoxPowiechrznia;

	private Label labelPowiechrznia;

	private TextBox textBoxCzasUżywania;

	private Label labelCzasUżywania;

	private Label label2;

	private Label label1;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	public AddNewSources(ListaŹródeł listaŹródeł)
	{
		InitializeComponent();
		this.listaŹródeł = listaŹródeł;
	}

	public void clearFields()
	{
		textBoxNazwa.Text = null;
		textBoxMoc.Text = null;
		textBoxSprawność.Text = null;
		textBoxPowiechrznia.Text = null;
		textBoxCzasUżywania.Text = null;
	}

	private void buttonAdd_Click(object sender, EventArgs e)
	{
		Sources sources = new Sources();
		bool isError = false;
		try
		{
			sources.name = textBoxNazwa.Text;
			sources.power = Convert.ToInt32(textBoxMoc.Text);
			sources.efficiency = Convert.ToInt32(textBoxSprawność.Text);
			sources.field = Convert.ToSingle(textBoxPowiechrznia.Text);
			sources.time = Convert.ToSingle(textBoxCzasUżywania.Text);
		}
		catch (FormatException ex)
		{
			MessageBox.Show(ex.Message);
			listaŹródeł.buttonNewSources_Click(null, EventArgs.Empty);
			isError = true;
		}
		if (!isError)
		{
			sourcesRepository.Add(sources);
			listaŹródeł.showData();
		}
		Hide();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odnawialne_Źródła_Energii.AddNewSources));
		this.buttonAdd = new System.Windows.Forms.Button();
		this.textBoxMoc = new System.Windows.Forms.TextBox();
		this.textBoxSprawność = new System.Windows.Forms.TextBox();
		this.textBoxNazwa = new System.Windows.Forms.TextBox();
		this.labelSprawność = new System.Windows.Forms.Label();
		this.labelMoc = new System.Windows.Forms.Label();
		this.labelNazwa = new System.Windows.Forms.Label();
		this.textBoxPowiechrznia = new System.Windows.Forms.TextBox();
		this.labelPowiechrznia = new System.Windows.Forms.Label();
		this.textBoxCzasUżywania = new System.Windows.Forms.TextBox();
		this.labelCzasUżywania = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonAdd.FlatAppearance.BorderSize = 0;
		this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonAdd.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonAdd.Location = new System.Drawing.Point(122, 241);
		this.buttonAdd.Name = "buttonAdd";
		this.buttonAdd.Size = new System.Drawing.Size(100, 23);
		this.buttonAdd.TabIndex = 15;
		this.buttonAdd.Text = "Dodaj";
		this.buttonAdd.UseVisualStyleBackColor = false;
		this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
		this.textBoxMoc.Location = new System.Drawing.Point(122, 66);
		this.textBoxMoc.Name = "textBoxMoc";
		this.textBoxMoc.Size = new System.Drawing.Size(100, 20);
		this.textBoxMoc.TabIndex = 1;
		this.textBoxSprawność.Location = new System.Drawing.Point(122, 109);
		this.textBoxSprawność.Name = "textBoxSprawność";
		this.textBoxSprawność.Size = new System.Drawing.Size(100, 20);
		this.textBoxSprawność.TabIndex = 2;
		this.textBoxNazwa.Location = new System.Drawing.Point(122, 23);
		this.textBoxNazwa.Name = "textBoxNazwa";
		this.textBoxNazwa.Size = new System.Drawing.Size(100, 20);
		this.textBoxNazwa.TabIndex = 0;
		this.labelSprawność.AutoSize = true;
		this.labelSprawność.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelSprawność.Location = new System.Drawing.Point(26, 112);
		this.labelSprawność.Name = "labelSprawność";
		this.labelSprawność.Size = new System.Drawing.Size(60, 13);
		this.labelSprawność.TabIndex = 11;
		this.labelSprawność.Text = "Sprawność";
		this.labelMoc.AutoSize = true;
		this.labelMoc.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelMoc.Location = new System.Drawing.Point(26, 69);
		this.labelMoc.Name = "labelMoc";
		this.labelMoc.Size = new System.Drawing.Size(28, 13);
		this.labelMoc.TabIndex = 10;
		this.labelMoc.Text = "Moc";
		this.labelNazwa.AutoSize = true;
		this.labelNazwa.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelNazwa.Location = new System.Drawing.Point(26, 25);
		this.labelNazwa.Name = "labelNazwa";
		this.labelNazwa.Size = new System.Drawing.Size(40, 13);
		this.labelNazwa.TabIndex = 9;
		this.labelNazwa.Text = "Nazwa";
		this.textBoxPowiechrznia.Location = new System.Drawing.Point(122, 152);
		this.textBoxPowiechrznia.Name = "textBoxPowiechrznia";
		this.textBoxPowiechrznia.Size = new System.Drawing.Size(100, 20);
		this.textBoxPowiechrznia.TabIndex = 3;
		this.labelPowiechrznia.AutoSize = true;
		this.labelPowiechrznia.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelPowiechrznia.Location = new System.Drawing.Point(26, 155);
		this.labelPowiechrznia.Name = "labelPowiechrznia";
		this.labelPowiechrznia.Size = new System.Drawing.Size(70, 13);
		this.labelPowiechrznia.TabIndex = 16;
		this.labelPowiechrznia.Text = "Powiechrznia";
		this.textBoxCzasUżywania.Location = new System.Drawing.Point(122, 195);
		this.textBoxCzasUżywania.Name = "textBoxCzasUżywania";
		this.textBoxCzasUżywania.Size = new System.Drawing.Size(100, 20);
		this.textBoxCzasUżywania.TabIndex = 4;
		this.labelCzasUżywania.AutoSize = true;
		this.labelCzasUżywania.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelCzasUżywania.Location = new System.Drawing.Point(26, 198);
		this.labelCzasUżywania.Name = "labelCzasUżywania";
		this.labelCzasUżywania.Size = new System.Drawing.Size(71, 13);
		this.labelCzasUżywania.TabIndex = 18;
		this.labelCzasUżywania.Text = "Czas używnia";
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label2.Location = new System.Drawing.Point(231, 199);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(13, 13);
		this.label2.TabIndex = 21;
		this.label2.Text = "h";
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label1.Location = new System.Drawing.Point(228, 69);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(31, 13);
		this.label1.TabIndex = 20;
		this.label1.Text = "W/m";
		this.label3.AutoSize = true;
		this.label3.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label3.Location = new System.Drawing.Point(228, 112);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(15, 13);
		this.label3.TabIndex = 22;
		this.label3.Text = "%";
		this.label4.AutoSize = true;
		this.label4.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label4.Location = new System.Drawing.Point(229, 156);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(15, 13);
		this.label4.TabIndex = 23;
		this.label4.Text = "m";
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label5.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label5.Location = new System.Drawing.Point(237, 152);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(9, 9);
		this.label5.TabIndex = 24;
		this.label5.Text = "2";
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label6.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label6.Location = new System.Drawing.Point(251, 64);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(9, 9);
		this.label6.TabIndex = 25;
		this.label6.Text = "2";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		base.ClientSize = new System.Drawing.Size(268, 288);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.textBoxCzasUżywania);
		base.Controls.Add(this.labelCzasUżywania);
		base.Controls.Add(this.textBoxPowiechrznia);
		base.Controls.Add(this.labelPowiechrznia);
		base.Controls.Add(this.buttonAdd);
		base.Controls.Add(this.textBoxMoc);
		base.Controls.Add(this.textBoxSprawność);
		base.Controls.Add(this.textBoxNazwa);
		base.Controls.Add(this.labelSprawność);
		base.Controls.Add(this.labelMoc);
		base.Controls.Add(this.labelNazwa);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "AddNewSources";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Dodaj źródło energii";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
