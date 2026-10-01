using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Odnawialne_Źródła_Energii.Properties;

namespace Odnawialne_Źródła_Energii;

public class Informacje : Form
{
	private Point PanelMouseDownLocation;

	private IContainer components = null;

	private Panel panelText;

	private Panel panel1;

	private RichTextBox richTextBox1;

	private RichTextBox richTextBox2;

	private RichTextBox richTextBox3;

	private RichTextBox richTextBox4;

	private RichTextBox richTextBox5;

	private RichTextBox richTextBox6;

	private RichTextBox richTextBox7;

	private PictureBox pictureBox3;

	private PictureBox pictureBox7;

	private PictureBox pictureBox6;

	private PictureBox pictureBox5;

	private PictureBox pictureBox1;

	private PictureBox pictureBox4;

	private PictureBox pictureBox2;

	public Informacje()
	{
		InitializeComponent();
		panelText.AutoScroll = false;
		panelText.HorizontalScroll.Enabled = false;
		panelText.HorizontalScroll.Visible = false;
		panelText.HorizontalScroll.Maximum = 0;
		panelText.AutoScroll = true;
		richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
		richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
		richTextBox3.SelectionAlignment = HorizontalAlignment.Center;
		richTextBox4.SelectionAlignment = HorizontalAlignment.Center;
		richTextBox5.SelectionAlignment = HorizontalAlignment.Center;
		richTextBox6.SelectionAlignment = HorizontalAlignment.Center;
		richTextBox7.SelectionAlignment = HorizontalAlignment.Center;
	}

	private void panel1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			PanelMouseDownLocation = e.Location;
		}
	}

	private void panel1_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			panelText.Left += e.X - PanelMouseDownLocation.X;
			panelText.Top += e.Y - PanelMouseDownLocation.Y;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odnawialne_Źródła_Energii.Informacje));
		this.panelText = new System.Windows.Forms.Panel();
		this.panel1 = new System.Windows.Forms.Panel();
		this.richTextBox7 = new System.Windows.Forms.RichTextBox();
		this.richTextBox6 = new System.Windows.Forms.RichTextBox();
		this.richTextBox5 = new System.Windows.Forms.RichTextBox();
		this.richTextBox4 = new System.Windows.Forms.RichTextBox();
		this.richTextBox3 = new System.Windows.Forms.RichTextBox();
		this.richTextBox2 = new System.Windows.Forms.RichTextBox();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.pictureBox7 = new System.Windows.Forms.PictureBox();
		this.pictureBox6 = new System.Windows.Forms.PictureBox();
		this.pictureBox5 = new System.Windows.Forms.PictureBox();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.pictureBox4 = new System.Windows.Forms.PictureBox();
		this.pictureBox2 = new System.Windows.Forms.PictureBox();
		this.pictureBox3 = new System.Windows.Forms.PictureBox();
		this.panelText.SuspendLayout();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox7).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
		base.SuspendLayout();
		this.panelText.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.panelText.Controls.Add(this.pictureBox7);
		this.panelText.Controls.Add(this.pictureBox6);
		this.panelText.Controls.Add(this.pictureBox5);
		this.panelText.Controls.Add(this.pictureBox1);
		this.panelText.Controls.Add(this.pictureBox4);
		this.panelText.Controls.Add(this.pictureBox2);
		this.panelText.Controls.Add(this.pictureBox3);
		this.panelText.Controls.Add(this.panel1);
		this.panelText.Location = new System.Drawing.Point(0, 0);
		this.panelText.Name = "panelText";
		this.panelText.Size = new System.Drawing.Size(910, 509);
		this.panelText.TabIndex = 0;
		this.panel1.Controls.Add(this.richTextBox7);
		this.panel1.Controls.Add(this.richTextBox6);
		this.panel1.Controls.Add(this.richTextBox5);
		this.panel1.Controls.Add(this.richTextBox4);
		this.panel1.Controls.Add(this.richTextBox3);
		this.panel1.Controls.Add(this.richTextBox2);
		this.panel1.Controls.Add(this.richTextBox1);
		this.panel1.Location = new System.Drawing.Point(138, 72);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(671, 1563);
		this.panel1.TabIndex = 1;
		this.richTextBox7.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.richTextBox7.Font = new System.Drawing.Font("Arial", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.richTextBox7.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.richTextBox7.Location = new System.Drawing.Point(0, 1300);
		this.richTextBox7.Name = "richTextBox7";
		this.richTextBox7.ReadOnly = true;
		this.richTextBox7.Size = new System.Drawing.Size(474, 189);
		this.richTextBox7.TabIndex = 7;
		this.richTextBox7.Text = resources.GetString("richTextBox7.Text");
		this.richTextBox6.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.richTextBox6.Font = new System.Drawing.Font("Arial", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.richTextBox6.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.richTextBox6.Location = new System.Drawing.Point(194, 1114);
		this.richTextBox6.Name = "richTextBox6";
		this.richTextBox6.ReadOnly = true;
		this.richTextBox6.Size = new System.Drawing.Size(474, 134);
		this.richTextBox6.TabIndex = 6;
		this.richTextBox6.Text = resources.GetString("richTextBox6.Text");
		this.richTextBox5.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.richTextBox5.Font = new System.Drawing.Font("Arial", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.richTextBox5.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.richTextBox5.Location = new System.Drawing.Point(0, 904);
		this.richTextBox5.Name = "richTextBox5";
		this.richTextBox5.ReadOnly = true;
		this.richTextBox5.Size = new System.Drawing.Size(474, 134);
		this.richTextBox5.TabIndex = 5;
		this.richTextBox5.Text = resources.GetString("richTextBox5.Text");
		this.richTextBox4.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.richTextBox4.Font = new System.Drawing.Font("Arial", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.richTextBox4.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.richTextBox4.Location = new System.Drawing.Point(194, 730);
		this.richTextBox4.Name = "richTextBox4";
		this.richTextBox4.ReadOnly = true;
		this.richTextBox4.Size = new System.Drawing.Size(474, 134);
		this.richTextBox4.TabIndex = 4;
		this.richTextBox4.Text = resources.GetString("richTextBox4.Text");
		this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.richTextBox3.Font = new System.Drawing.Font("Arial", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.richTextBox3.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.richTextBox3.Location = new System.Drawing.Point(0, 580);
		this.richTextBox3.Name = "richTextBox3";
		this.richTextBox3.ReadOnly = true;
		this.richTextBox3.Size = new System.Drawing.Size(474, 134);
		this.richTextBox3.TabIndex = 3;
		this.richTextBox3.Text = "Energia wiatru wprawia w ruch turbiny nowoczesnych wiatraku co pozwala na produkcję elektryczności.";
		this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.richTextBox2.Font = new System.Drawing.Font("Arial", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.richTextBox2.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.richTextBox2.Location = new System.Drawing.Point(194, 380);
		this.richTextBox2.Name = "richTextBox2";
		this.richTextBox2.ReadOnly = true;
		this.richTextBox2.Size = new System.Drawing.Size(474, 134);
		this.richTextBox2.TabIndex = 2;
		this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
		this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.richTextBox1.Font = new System.Drawing.Font("Arial", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(241, 242, 241);
		this.richTextBox1.Location = new System.Drawing.Point(0, 34);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.ReadOnly = true;
		this.richTextBox1.Size = new System.Drawing.Size(474, 268);
		this.richTextBox1.TabIndex = 1;
		this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
		this.pictureBox7.BackgroundImage = Odnawialne_Źródła_Energii.Properties.Resources.Inform_11;
		this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox7.Location = new System.Drawing.Point(632, 1390);
		this.pictureBox7.Name = "pictureBox7";
		this.pictureBox7.Size = new System.Drawing.Size(234, 157);
		this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox7.TabIndex = 15;
		this.pictureBox7.TabStop = false;
		this.pictureBox6.BackgroundImage = Odnawialne_Źródła_Energii.Properties.Resources.Inform_7;
		this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox6.Location = new System.Drawing.Point(47, 1170);
		this.pictureBox6.Name = "pictureBox6";
		this.pictureBox6.Size = new System.Drawing.Size(234, 157);
		this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox6.TabIndex = 14;
		this.pictureBox6.TabStop = false;
		this.pictureBox5.BackgroundImage = Odnawialne_Źródła_Energii.Properties.Resources.Inform_5;
		this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox5.Location = new System.Drawing.Point(632, 970);
		this.pictureBox5.Name = "pictureBox5";
		this.pictureBox5.Size = new System.Drawing.Size(234, 157);
		this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox5.TabIndex = 13;
		this.pictureBox5.TabStop = false;
		this.pictureBox1.BackgroundImage = Odnawialne_Źródła_Energii.Properties.Resources.Inform_11;
		this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox1.Location = new System.Drawing.Point(632, 155);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(234, 157);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 12;
		this.pictureBox1.TabStop = false;
		this.pictureBox4.BackgroundImage = Odnawialne_Źródła_Energii.Properties.Resources.Inform_4;
		this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox4.Location = new System.Drawing.Point(47, 770);
		this.pictureBox4.Name = "pictureBox4";
		this.pictureBox4.Size = new System.Drawing.Size(234, 157);
		this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox4.TabIndex = 12;
		this.pictureBox4.TabStop = false;
		this.pictureBox2.BackgroundImage = Odnawialne_Źródła_Energii.Properties.Resources.Inform_21;
		this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox2.Location = new System.Drawing.Point(47, 432);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new System.Drawing.Size(234, 157);
		this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox2.TabIndex = 11;
		this.pictureBox2.TabStop = false;
		this.pictureBox3.BackgroundImage = Odnawialne_Źródła_Energii.Properties.Resources.Inform_3;
		this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox3.Location = new System.Drawing.Point(632, 600);
		this.pictureBox3.Name = "pictureBox3";
		this.pictureBox3.Size = new System.Drawing.Size(234, 157);
		this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox3.TabIndex = 10;
		this.pictureBox3.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		base.ClientSize = new System.Drawing.Size(910, 509);
		base.Controls.Add(this.panelText);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "Informacje";
		this.Text = "Informacje";
		this.panelText.ResumeLayout(false);
		this.panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox7).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
		base.ResumeLayout(false);
	}
}
