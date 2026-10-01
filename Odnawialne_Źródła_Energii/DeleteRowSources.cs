using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Odnawialne_Źródła_Energii;

public class DeleteRowSources : Form
{
	private SourcesRepository sourcesRepository = new SourcesRepository();

	private ListaŹródeł listaŹródeł;

	private IContainer components = null;

	private Button buttonDelete;

	private Label label1;

	private NumericUpDown numericUpDownId;

	public DeleteRowSources(ListaŹródeł listaŹródeł)
	{
		InitializeComponent();
		this.listaŹródeł = listaŹródeł;
	}

	public void clearFields()
	{
		numericUpDownId.Value = 1m;
	}

	private void buttonDelete_Click(object sender, EventArgs e)
	{
		Sources sources = new Sources();
		sources.id = (int)numericUpDownId.Value;
		sourcesRepository.Delete(sources.id);
		Hide();
		listaŹródeł.showData();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odnawialne_Źródła_Energii.DeleteRowSources));
		this.buttonDelete = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownId).BeginInit();
		base.SuspendLayout();
		this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonDelete.FlatAppearance.BorderSize = 0;
		this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonDelete.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonDelete.Location = new System.Drawing.Point(91, 71);
		this.buttonDelete.Name = "buttonDelete";
		this.buttonDelete.Size = new System.Drawing.Size(100, 23);
		this.buttonDelete.TabIndex = 25;
		this.buttonDelete.Text = "Usuń";
		this.buttonDelete.UseVisualStyleBackColor = false;
		this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label1.Location = new System.Drawing.Point(39, 29);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(16, 13);
		this.label1.TabIndex = 24;
		this.label1.Text = "Id";
		this.numericUpDownId.Location = new System.Drawing.Point(91, 27);
		this.numericUpDownId.Name = "numericUpDownId";
		this.numericUpDownId.Size = new System.Drawing.Size(100, 20);
		this.numericUpDownId.TabIndex = 23;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		base.ClientSize = new System.Drawing.Size(230, 121);
		base.Controls.Add(this.buttonDelete);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.numericUpDownId);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "DeleteRowSources";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Usuń źródło energii";
		((System.ComponentModel.ISupportInitialize)this.numericUpDownId).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
