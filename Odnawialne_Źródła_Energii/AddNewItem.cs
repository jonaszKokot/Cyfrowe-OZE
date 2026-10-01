using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Odnawialne_Źródła_Energii;

public class AddNewItem : Form
{
	private MachineRepository machineRepository = new MachineRepository();

	private ListaNarzędzi listaNarzędzi;

	private IContainer components = null;

	private Label labelNazwa;

	private Label labelMoc;

	private Label labelCzasUzywania;

	private TextBox textBoxNazwa;

	private TextBox textBoxCzasUzywania;

	private TextBox textBoxMoc;

	private Button buttonAdd;

	private Label label1;

	private Label label2;

	public AddNewItem(ListaNarzędzi listaNarzędzi)
	{
		InitializeComponent();
		this.listaNarzędzi = listaNarzędzi;
	}

	public void clearFields()
	{
		textBoxNazwa.Text = null;
		textBoxMoc.Text = null;
		textBoxCzasUzywania.Text = null;
	}

	private void buttonAdd_Click(object sender, EventArgs e)
	{
		Machine machine = new Machine();
		bool isError = false;
		try
		{
			machine.name = textBoxNazwa.Text;
			machine.power = Convert.ToInt32(textBoxMoc.Text);
			machine.time = Convert.ToSingle(textBoxCzasUzywania.Text);
		}
		catch (FormatException ex)
		{
			MessageBox.Show(ex.Message);
			listaNarzędzi.buttonNewItem_Click(null, EventArgs.Empty);
			isError = true;
		}
		if (!isError)
		{
			machineRepository.Add(machine);
			listaNarzędzi.showData();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odnawialne_Źródła_Energii.AddNewItem));
		this.labelNazwa = new System.Windows.Forms.Label();
		this.labelMoc = new System.Windows.Forms.Label();
		this.labelCzasUzywania = new System.Windows.Forms.Label();
		this.textBoxNazwa = new System.Windows.Forms.TextBox();
		this.textBoxCzasUzywania = new System.Windows.Forms.TextBox();
		this.textBoxMoc = new System.Windows.Forms.TextBox();
		this.buttonAdd = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.labelNazwa.AutoSize = true;
		this.labelNazwa.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelNazwa.Location = new System.Drawing.Point(37, 33);
		this.labelNazwa.Name = "labelNazwa";
		this.labelNazwa.Size = new System.Drawing.Size(40, 13);
		this.labelNazwa.TabIndex = 0;
		this.labelNazwa.Text = "Nazwa";
		this.labelMoc.AutoSize = true;
		this.labelMoc.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelMoc.Location = new System.Drawing.Point(37, 77);
		this.labelMoc.Name = "labelMoc";
		this.labelMoc.Size = new System.Drawing.Size(28, 13);
		this.labelMoc.TabIndex = 1;
		this.labelMoc.Text = "Moc";
		this.labelCzasUzywania.AutoSize = true;
		this.labelCzasUzywania.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelCzasUzywania.Location = new System.Drawing.Point(37, 121);
		this.labelCzasUzywania.Name = "labelCzasUzywania";
		this.labelCzasUzywania.Size = new System.Drawing.Size(71, 13);
		this.labelCzasUzywania.TabIndex = 2;
		this.labelCzasUzywania.Text = "Czas używnia";
		this.textBoxNazwa.Location = new System.Drawing.Point(133, 31);
		this.textBoxNazwa.Name = "textBoxNazwa";
		this.textBoxNazwa.Size = new System.Drawing.Size(100, 20);
		this.textBoxNazwa.TabIndex = 0;
		this.textBoxCzasUzywania.Location = new System.Drawing.Point(133, 118);
		this.textBoxCzasUzywania.Name = "textBoxCzasUzywania";
		this.textBoxCzasUzywania.Size = new System.Drawing.Size(100, 20);
		this.textBoxCzasUzywania.TabIndex = 2;
		this.textBoxMoc.Location = new System.Drawing.Point(133, 74);
		this.textBoxMoc.Name = "textBoxMoc";
		this.textBoxMoc.Size = new System.Drawing.Size(100, 20);
		this.textBoxMoc.TabIndex = 1;
		this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonAdd.FlatAppearance.BorderSize = 0;
		this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonAdd.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonAdd.Location = new System.Drawing.Point(133, 162);
		this.buttonAdd.Name = "buttonAdd";
		this.buttonAdd.Size = new System.Drawing.Size(100, 23);
		this.buttonAdd.TabIndex = 8;
		this.buttonAdd.Text = "Dodaj";
		this.buttonAdd.UseVisualStyleBackColor = false;
		this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label1.Location = new System.Drawing.Point(239, 77);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(18, 13);
		this.label1.TabIndex = 9;
		this.label1.Text = "W";
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label2.Location = new System.Drawing.Point(242, 121);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(13, 13);
		this.label2.TabIndex = 10;
		this.label2.Text = "h";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		base.ClientSize = new System.Drawing.Size(270, 213);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.buttonAdd);
		base.Controls.Add(this.textBoxMoc);
		base.Controls.Add(this.textBoxCzasUzywania);
		base.Controls.Add(this.textBoxNazwa);
		base.Controls.Add(this.labelCzasUzywania);
		base.Controls.Add(this.labelMoc);
		base.Controls.Add(this.labelNazwa);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "AddNewItem";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Dodaj urządzenie";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
