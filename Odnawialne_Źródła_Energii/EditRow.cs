using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Odnawialne_Źródła_Energii;

public class EditRow : Form
{
	private MachineRepository machineRepository = new MachineRepository();

	private ListaNarzędzi listaNarzędzi;

	private IContainer components = null;

	private Label label1;

	private NumericUpDown numericUpDownId;

	private Button buttonEdit;

	private TextBox textBoxMoc;

	private TextBox textBoxCzasUzywania;

	private TextBox textBoxNazwa;

	private Label labelCzasUzywania;

	private Label labelMoc;

	private Label labelNazwa;

	private Label label2;

	private Label label3;

	public EditRow(ListaNarzędzi listaNarzędzi)
	{
		InitializeComponent();
		this.listaNarzędzi = listaNarzędzi;
	}

	public void clearFields()
	{
		numericUpDownId.Value = 1m;
		textBoxNazwa.Text = null;
		textBoxMoc.Text = null;
		textBoxCzasUzywania.Text = null;
	}

	private void buttonEdit_Click(object sender, EventArgs e)
	{
		Machine machine = new Machine();
		bool isError = false;
		try
		{
			machine.id = (int)numericUpDownId.Value;
			machine.name = textBoxNazwa.Text;
			machine.power = Convert.ToInt32(textBoxMoc.Text);
			machine.time = Convert.ToSingle(textBoxCzasUzywania.Text);
		}
		catch (FormatException ex)
		{
			MessageBox.Show(ex.Message);
			listaNarzędzi.buttonEdit_Click(null, EventArgs.Empty);
			isError = true;
		}
		if (!isError)
		{
			machineRepository.Update(machine);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odnawialne_Źródła_Energii.EditRow));
		this.label1 = new System.Windows.Forms.Label();
		this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
		this.buttonEdit = new System.Windows.Forms.Button();
		this.textBoxMoc = new System.Windows.Forms.TextBox();
		this.textBoxCzasUzywania = new System.Windows.Forms.TextBox();
		this.textBoxNazwa = new System.Windows.Forms.TextBox();
		this.labelCzasUzywania = new System.Windows.Forms.Label();
		this.labelMoc = new System.Windows.Forms.Label();
		this.labelNazwa = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownId).BeginInit();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label1.Location = new System.Drawing.Point(37, 33);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(16, 13);
		this.label1.TabIndex = 19;
		this.label1.Text = "Id";
		this.numericUpDownId.Location = new System.Drawing.Point(133, 31);
		this.numericUpDownId.Name = "numericUpDownId";
		this.numericUpDownId.Size = new System.Drawing.Size(100, 20);
		this.numericUpDownId.TabIndex = 0;
		this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonEdit.FlatAppearance.BorderSize = 0;
		this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonEdit.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonEdit.Location = new System.Drawing.Point(133, 206);
		this.buttonEdit.Name = "buttonEdit";
		this.buttonEdit.Size = new System.Drawing.Size(100, 23);
		this.buttonEdit.TabIndex = 17;
		this.buttonEdit.Text = "Edytuj";
		this.buttonEdit.UseVisualStyleBackColor = false;
		this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
		this.textBoxMoc.Location = new System.Drawing.Point(133, 118);
		this.textBoxMoc.Name = "textBoxMoc";
		this.textBoxMoc.Size = new System.Drawing.Size(100, 20);
		this.textBoxMoc.TabIndex = 2;
		this.textBoxCzasUzywania.Location = new System.Drawing.Point(133, 162);
		this.textBoxCzasUzywania.Name = "textBoxCzasUzywania";
		this.textBoxCzasUzywania.Size = new System.Drawing.Size(100, 20);
		this.textBoxCzasUzywania.TabIndex = 3;
		this.textBoxNazwa.Location = new System.Drawing.Point(133, 74);
		this.textBoxNazwa.Name = "textBoxNazwa";
		this.textBoxNazwa.Size = new System.Drawing.Size(100, 20);
		this.textBoxNazwa.TabIndex = 1;
		this.labelCzasUzywania.AutoSize = true;
		this.labelCzasUzywania.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelCzasUzywania.Location = new System.Drawing.Point(37, 165);
		this.labelCzasUzywania.Name = "labelCzasUzywania";
		this.labelCzasUzywania.Size = new System.Drawing.Size(71, 13);
		this.labelCzasUzywania.TabIndex = 13;
		this.labelCzasUzywania.Text = "Czas używnia";
		this.labelMoc.AutoSize = true;
		this.labelMoc.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelMoc.Location = new System.Drawing.Point(37, 121);
		this.labelMoc.Name = "labelMoc";
		this.labelMoc.Size = new System.Drawing.Size(28, 13);
		this.labelMoc.TabIndex = 12;
		this.labelMoc.Text = "Moc";
		this.labelNazwa.AutoSize = true;
		this.labelNazwa.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelNazwa.Location = new System.Drawing.Point(37, 77);
		this.labelNazwa.Name = "labelNazwa";
		this.labelNazwa.Size = new System.Drawing.Size(40, 13);
		this.labelNazwa.TabIndex = 11;
		this.labelNazwa.Text = "Nazwa";
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label2.Location = new System.Drawing.Point(242, 165);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(13, 13);
		this.label2.TabIndex = 21;
		this.label2.Text = "h";
		this.label3.AutoSize = true;
		this.label3.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label3.Location = new System.Drawing.Point(239, 121);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(18, 13);
		this.label3.TabIndex = 20;
		this.label3.Text = "W";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		base.ClientSize = new System.Drawing.Size(270, 261);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.numericUpDownId);
		base.Controls.Add(this.buttonEdit);
		base.Controls.Add(this.textBoxMoc);
		base.Controls.Add(this.textBoxCzasUzywania);
		base.Controls.Add(this.textBoxNazwa);
		base.Controls.Add(this.labelCzasUzywania);
		base.Controls.Add(this.labelMoc);
		base.Controls.Add(this.labelNazwa);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "EditRow";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Edytuj urządzenie";
		((System.ComponentModel.ISupportInitialize)this.numericUpDownId).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
