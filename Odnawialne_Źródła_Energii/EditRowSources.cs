using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Odnawialne_Źródła_Energii;

public class EditRowSources : Form
{
	private SourcesRepository sourcesRepository = new SourcesRepository();

	private ListaŹródeł listaŹródeł;

	private IContainer components = null;

	private TextBox textBoxCzasUżywania;

	private Label labelCzasUżywania;

	private TextBox textBoxPowiechrznia;

	private Label labelPowiechrznia;

	private Button buttonEdit;

	private TextBox textBoxMoc;

	private TextBox textBoxSprawność;

	private TextBox textBoxNazwa;

	private Label labelSprawność;

	private Label labelMoc;

	private Label labelNazwa;

	private Label label1;

	private NumericUpDown numericUpDownId;

	private Label label5;

	private Label label4;

	private Label label3;

	private Label label2;

	private Label label6;

	private Label label7;

	public EditRowSources(ListaŹródeł listaŹródeł)
	{
		InitializeComponent();
		this.listaŹródeł = listaŹródeł;
	}

	public void clearFields()
	{
		numericUpDownId.Value = 1m;
		textBoxNazwa.Text = null;
		textBoxMoc.Text = null;
		textBoxSprawność.Text = null;
		textBoxPowiechrznia.Text = null;
		textBoxCzasUżywania.Text = null;
	}

	private void buttonEdit_Click(object sender, EventArgs e)
	{
		Sources sources = new Sources();
		bool isError = false;
		try
		{
			sources.id = (int)numericUpDownId.Value;
			sources.name = textBoxNazwa.Text;
			sources.power = Convert.ToInt32(textBoxMoc.Text);
			sources.efficiency = Convert.ToInt32(textBoxSprawność.Text);
			sources.field = Convert.ToSingle(textBoxPowiechrznia.Text);
			sources.time = Convert.ToSingle(textBoxCzasUżywania.Text);
		}
		catch (FormatException ex)
		{
			MessageBox.Show(ex.Message);
			listaŹródeł.buttonEdit_Click(null, EventArgs.Empty);
			isError = true;
		}
		if (!isError)
		{
			sourcesRepository.Update(sources);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odnawialne_Źródła_Energii.EditRowSources));
		this.textBoxCzasUżywania = new System.Windows.Forms.TextBox();
		this.labelCzasUżywania = new System.Windows.Forms.Label();
		this.textBoxPowiechrznia = new System.Windows.Forms.TextBox();
		this.labelPowiechrznia = new System.Windows.Forms.Label();
		this.buttonEdit = new System.Windows.Forms.Button();
		this.textBoxMoc = new System.Windows.Forms.TextBox();
		this.textBoxSprawność = new System.Windows.Forms.TextBox();
		this.textBoxNazwa = new System.Windows.Forms.TextBox();
		this.labelSprawność = new System.Windows.Forms.Label();
		this.labelMoc = new System.Windows.Forms.Label();
		this.labelNazwa = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownId).BeginInit();
		base.SuspendLayout();
		this.textBoxCzasUżywania.Location = new System.Drawing.Point(126, 242);
		this.textBoxCzasUżywania.Name = "textBoxCzasUżywania";
		this.textBoxCzasUżywania.Size = new System.Drawing.Size(100, 20);
		this.textBoxCzasUżywania.TabIndex = 5;
		this.labelCzasUżywania.AutoSize = true;
		this.labelCzasUżywania.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelCzasUżywania.Location = new System.Drawing.Point(30, 245);
		this.labelCzasUżywania.Name = "labelCzasUżywania";
		this.labelCzasUżywania.Size = new System.Drawing.Size(71, 13);
		this.labelCzasUżywania.TabIndex = 29;
		this.labelCzasUżywania.Text = "Czas używnia";
		this.textBoxPowiechrznia.Location = new System.Drawing.Point(126, 199);
		this.textBoxPowiechrznia.Name = "textBoxPowiechrznia";
		this.textBoxPowiechrznia.Size = new System.Drawing.Size(100, 20);
		this.textBoxPowiechrznia.TabIndex = 4;
		this.labelPowiechrznia.AutoSize = true;
		this.labelPowiechrznia.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelPowiechrznia.Location = new System.Drawing.Point(30, 202);
		this.labelPowiechrznia.Name = "labelPowiechrznia";
		this.labelPowiechrznia.Size = new System.Drawing.Size(70, 13);
		this.labelPowiechrznia.TabIndex = 27;
		this.labelPowiechrznia.Text = "Powiechrznia";
		this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonEdit.FlatAppearance.BorderSize = 0;
		this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonEdit.Font = new System.Drawing.Font("Arial", 8.25f);
		this.buttonEdit.Location = new System.Drawing.Point(126, 288);
		this.buttonEdit.Name = "buttonEdit";
		this.buttonEdit.Size = new System.Drawing.Size(100, 23);
		this.buttonEdit.TabIndex = 26;
		this.buttonEdit.Text = "Edytuj";
		this.buttonEdit.UseVisualStyleBackColor = false;
		this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
		this.textBoxMoc.Location = new System.Drawing.Point(126, 113);
		this.textBoxMoc.Name = "textBoxMoc";
		this.textBoxMoc.Size = new System.Drawing.Size(100, 20);
		this.textBoxMoc.TabIndex = 2;
		this.textBoxSprawność.Location = new System.Drawing.Point(126, 156);
		this.textBoxSprawność.Name = "textBoxSprawność";
		this.textBoxSprawność.Size = new System.Drawing.Size(100, 20);
		this.textBoxSprawność.TabIndex = 3;
		this.textBoxNazwa.Location = new System.Drawing.Point(126, 70);
		this.textBoxNazwa.Name = "textBoxNazwa";
		this.textBoxNazwa.Size = new System.Drawing.Size(100, 20);
		this.textBoxNazwa.TabIndex = 1;
		this.labelSprawność.AutoSize = true;
		this.labelSprawność.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelSprawność.Location = new System.Drawing.Point(30, 159);
		this.labelSprawność.Name = "labelSprawność";
		this.labelSprawność.Size = new System.Drawing.Size(60, 13);
		this.labelSprawność.TabIndex = 22;
		this.labelSprawność.Text = "Sprawność";
		this.labelMoc.AutoSize = true;
		this.labelMoc.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelMoc.Location = new System.Drawing.Point(30, 116);
		this.labelMoc.Name = "labelMoc";
		this.labelMoc.Size = new System.Drawing.Size(28, 13);
		this.labelMoc.TabIndex = 21;
		this.labelMoc.Text = "Moc";
		this.labelNazwa.AutoSize = true;
		this.labelNazwa.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.labelNazwa.Location = new System.Drawing.Point(30, 72);
		this.labelNazwa.Name = "labelNazwa";
		this.labelNazwa.Size = new System.Drawing.Size(40, 13);
		this.labelNazwa.TabIndex = 20;
		this.labelNazwa.Text = "Nazwa";
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label1.Location = new System.Drawing.Point(30, 28);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(16, 13);
		this.label1.TabIndex = 32;
		this.label1.Text = "Id";
		this.numericUpDownId.Location = new System.Drawing.Point(126, 26);
		this.numericUpDownId.Name = "numericUpDownId";
		this.numericUpDownId.Size = new System.Drawing.Size(100, 20);
		this.numericUpDownId.TabIndex = 0;
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label5.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label5.Location = new System.Drawing.Point(241, 199);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(9, 9);
		this.label5.TabIndex = 37;
		this.label5.Text = "2";
		this.label4.AutoSize = true;
		this.label4.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label4.Location = new System.Drawing.Point(233, 203);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(15, 13);
		this.label4.TabIndex = 36;
		this.label4.Text = "m";
		this.label3.AutoSize = true;
		this.label3.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label3.Location = new System.Drawing.Point(232, 159);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(15, 13);
		this.label3.TabIndex = 35;
		this.label3.Text = "%";
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label2.Location = new System.Drawing.Point(235, 246);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(13, 13);
		this.label2.TabIndex = 34;
		this.label2.Text = "h";
		this.label6.AutoSize = true;
		this.label6.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label6.Location = new System.Drawing.Point(232, 116);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(31, 13);
		this.label6.TabIndex = 33;
		this.label6.Text = "W/m";
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label7.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label7.Location = new System.Drawing.Point(255, 110);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(9, 9);
		this.label7.TabIndex = 38;
		this.label7.Text = "2";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		base.ClientSize = new System.Drawing.Size(268, 336);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.numericUpDownId);
		base.Controls.Add(this.textBoxCzasUżywania);
		base.Controls.Add(this.labelCzasUżywania);
		base.Controls.Add(this.textBoxPowiechrznia);
		base.Controls.Add(this.labelPowiechrznia);
		base.Controls.Add(this.buttonEdit);
		base.Controls.Add(this.textBoxMoc);
		base.Controls.Add(this.textBoxSprawność);
		base.Controls.Add(this.textBoxNazwa);
		base.Controls.Add(this.labelSprawność);
		base.Controls.Add(this.labelMoc);
		base.Controls.Add(this.labelNazwa);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "EditRowSources";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Edytuj źródło energii";
		((System.ComponentModel.ISupportInitialize)this.numericUpDownId).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
