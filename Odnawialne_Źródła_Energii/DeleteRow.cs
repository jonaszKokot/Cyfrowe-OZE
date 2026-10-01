using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Odnawialne_Źródła_Energii;

public class DeleteRow : Form
{
	private MachineRepository machineRepository = new MachineRepository();

	private ListaNarzędzi listaNarzędzi;

	private IContainer components = null;

	private Label label1;

	private NumericUpDown numericUpDownId;

	private Button buttonDelete;

	public DeleteRow(ListaNarzędzi listaNarzędzi)
	{
		InitializeComponent();
		this.listaNarzędzi = listaNarzędzi;
	}

	public void clearFields()
	{
		numericUpDownId.Value = 1m;
	}

	private void buttonDelete_Click(object sender, EventArgs e)
	{
		Machine machine = new Machine();
		machine.id = (int)numericUpDownId.Value;
		machineRepository.Delete(machine.id);
		Hide();
		listaNarzędzi.showData();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odnawialne_Źródła_Energii.DeleteRow));
		this.label1 = new System.Windows.Forms.Label();
		this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
		this.buttonDelete = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownId).BeginInit();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.label1.Location = new System.Drawing.Point(28, 32);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(16, 13);
		this.label1.TabIndex = 21;
		this.label1.Text = "Id";
		this.numericUpDownId.Location = new System.Drawing.Point(80, 30);
		this.numericUpDownId.Name = "numericUpDownId";
		this.numericUpDownId.Size = new System.Drawing.Size(100, 20);
		this.numericUpDownId.TabIndex = 20;
		this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonDelete.FlatAppearance.BorderSize = 0;
		this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonDelete.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonDelete.Location = new System.Drawing.Point(80, 74);
		this.buttonDelete.Name = "buttonDelete";
		this.buttonDelete.Size = new System.Drawing.Size(100, 23);
		this.buttonDelete.TabIndex = 22;
		this.buttonDelete.Text = "Usuń";
		this.buttonDelete.UseVisualStyleBackColor = false;
		this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		base.ClientSize = new System.Drawing.Size(229, 121);
		base.Controls.Add(this.buttonDelete);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.numericUpDownId);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "DeleteRow";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Usuń urządzenie";
		((System.ComponentModel.ISupportInitialize)this.numericUpDownId).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
