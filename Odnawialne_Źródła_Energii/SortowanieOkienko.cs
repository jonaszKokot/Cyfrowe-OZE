using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Odnawialne_Źródła_Energii.Properties;

namespace Odnawialne_Źródła_Energii;

public class SortowanieOkienko : Form
{
	private Start start;

	private IContainer components = null;

	private Button buttonRetry;

	private Button buttonBack;

	private Label label1;

	private PictureBox pictureBox1;

	private RichTextBox richTextBox1;

	public SortowanieOkienko(Start start)
	{
		InitializeComponent();
		this.start = start;
	}

	private void buttonRetry_Click(object sender, EventArgs e)
	{
		start.buttonSegregacja_Click(null, EventArgs.Empty);
	}

	private void buttonBack_Click(object sender, EventArgs e)
	{
		Close();
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
		this.buttonRetry = new System.Windows.Forms.Button();
		this.buttonBack = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.buttonRetry.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonRetry.Location = new System.Drawing.Point(252, 224);
		this.buttonRetry.Name = "buttonRetry";
		this.buttonRetry.Size = new System.Drawing.Size(153, 32);
		this.buttonRetry.TabIndex = 0;
		this.buttonRetry.Text = "Spróbuj jeszcze raz";
		this.buttonRetry.UseVisualStyleBackColor = true;
		this.buttonRetry.Click += new System.EventHandler(this.buttonRetry_Click);
		this.buttonBack.Location = new System.Drawing.Point(39, 224);
		this.buttonBack.Name = "buttonBack";
		this.buttonBack.Size = new System.Drawing.Size(153, 32);
		this.buttonBack.TabIndex = 1;
		this.buttonBack.Text = "Wróć";
		this.buttonBack.UseVisualStyleBackColor = true;
		this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Arial", 12.75f);
		this.label1.Location = new System.Drawing.Point(299, 43);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(65, 19);
		this.label1.TabIndex = 2;
		this.label1.Text = "Brawo!!";
		this.pictureBox1.Image = Odnawialne_Źródła_Energii.Properties.Resources.buzia;
		this.pictureBox1.Location = new System.Drawing.Point(39, 28);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(190, 162);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 3;
		this.pictureBox1.TabStop = false;
		this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
		this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.richTextBox1.Font = new System.Drawing.Font("Arial", 12.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.richTextBox1.Location = new System.Drawing.Point(270, 94);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.ReadOnly = true;
		this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
		this.richTextBox1.Size = new System.Drawing.Size(119, 96);
		this.richTextBox1.TabIndex = 4;
		this.richTextBox1.Text = "Udało ci się posegregować wszystkie odpadki!";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(440, 276);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.buttonBack);
		base.Controls.Add(this.buttonRetry);
		base.Name = "SortowanieOkienko";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "SortowanieOkienko";
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
