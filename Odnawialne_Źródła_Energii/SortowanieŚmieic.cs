#define DEBUG
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Odnawialne_Źródła_Energii.Properties;

namespace Odnawialne_Źródła_Energii;

public class SortowanieŚmieic : Form
{
	private Point PanelMouseDownLocation;

	private Start start;

	private bool shuldContinueMethod = true;

	private IContainer components = null;

	private Label labelPapier;

	private Label labelSzkło;

	private Label labelBio;

	private Label labelPlastiki;

	private PictureBox pictureBoxPlastiki;

	private PictureBox pictureBoxOdpadek;

	private PictureBox pictureBoxSzkło;

	private PictureBox pictureBoxBioodpady;

	private PictureBox pictureBoxPapier;

	private Panel panelBackColor;

	private Panel panel1;

	public SortowanieŚmieic(Start start)
	{
		InitializeComponent();
		this.start = start;
		panelBackColor.Visible = false;
	}

	private void changeNextImage()
	{
		if (start.pk == 0)
		{
			miejscePlastiki();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
				return;
			}
			pictureBoxOdpadek.Image = Resources._7wwofua;
			Debug.WriteLine("Jest źle");
		}
		else if (start.pk == 1)
		{
			miejsceSzkło();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
				return;
			}
			pictureBoxOdpadek.Image = Resources.b395b64f287b2cd5fef51fc78b6f5a44;
			Debug.WriteLine("Jest źle");
		}
		else if (start.pk == 2)
		{
			miejsceBio();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
				return;
			}
			pictureBoxOdpadek.Image = Resources.bg6yy7uw;
			Debug.WriteLine("Jest źle");
		}
		else if (start.pk == 3)
		{
			miejsceSzkło();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
				return;
			}
			pictureBoxOdpadek.Image = Resources.c7chcwl6;
			Debug.WriteLine("Jest źle");
		}
		else if (start.pk == 4)
		{
			miejscePlastiki();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
			}
			else
			{
				pictureBoxOdpadek.Image = Resources.ggrquiya;
			}
		}
		else if (start.pk == 5)
		{
			miejsceBio();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
			}
			else
			{
				pictureBoxOdpadek.Image = Resources.kdaeknw;
			}
		}
		else if (start.pk == 6)
		{
			miejscePlastiki();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
			}
			else
			{
				pictureBoxOdpadek.Image = Resources.luzzkgd;
			}
		}
		else if (start.pk == 7)
		{
			miejscePlastiki();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
			}
			else
			{
				pictureBoxOdpadek.Image = Resources.nakrtki_sko_thumb;
			}
		}
		else if (start.pk == 8)
		{
			miejscePlastiki();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
			}
			else
			{
				pictureBoxOdpadek.Image = Resources.qewbkag;
			}
		}
		else if (start.pk == 9)
		{
			miejscePapier();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
			}
			else
			{
				pictureBoxOdpadek.Image = Resources._02jwpb88;
			}
		}
		else if (start.pk == 10)
		{
			miejscePapier();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
			}
			else
			{
				pictureBoxOdpadek.Image = Resources._07q1dgd;
			}
		}
		else if (start.pk == 11)
		{
			miejsceSzkło();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
			}
			else
			{
				pictureBoxOdpadek.Image = Resources._48testc;
			}
		}
		else if (start.pk == 12)
		{
			miejscePapier();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
			}
			else
			{
				pictureBoxOdpadek.Image = Resources._4xdgvpyt;
			}
		}
		else if (start.pk == 13)
		{
			miejscePapier();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
			}
			else
			{
				pictureBoxOdpadek.Image = Resources._7dw9l5bv;
			}
		}
		else if (start.pk == 14)
		{
			miejsceSzkło();
			if (!shuldContinueMethod)
			{
				shuldContinueMethod = true;
			}
			else
			{
				pictureBoxOdpadek.Image = Resources.arrw0y6c;
			}
		}
		else
		{
			SortowanieOkienko sortowanieOkienko = new SortowanieOkienko(start);
			sortowanieOkienko.Show();
			Debug.WriteLine("Brawo");
		}
	}

	private void miejscePlastiki()
	{
		if (pictureBoxOdpadek.Left < 390 && pictureBoxOdpadek.Top < 190)
		{
			start.pk++;
			Debug.WriteLine("Plastiki");
			pictureBoxOdpadek.Left = 390;
			pictureBoxOdpadek.Top = 190;
			Debug.WriteLine("Dobrze");
		}
		else
		{
			shuldContinueMethod = false;
			panelBackColor.Left = pictureBoxOdpadek.Left - 5;
			panelBackColor.Top = pictureBoxOdpadek.Top - 5;
			panelBackColor.Visible = true;
			Debug.WriteLine("źle");
		}
		start.showPk();
	}

	private void miejsceSzkło()
	{
		if (pictureBoxOdpadek.Left < 390 && pictureBoxOdpadek.Top > 190)
		{
			start.pk++;
			Debug.WriteLine("Szkło");
			pictureBoxOdpadek.Left = 390;
			pictureBoxOdpadek.Top = 190;
			Debug.WriteLine("Dobrze");
		}
		else
		{
			shuldContinueMethod = false;
			panelBackColor.Left = pictureBoxOdpadek.Left - 5;
			panelBackColor.Top = pictureBoxOdpadek.Top - 5;
			panelBackColor.Visible = true;
			Debug.WriteLine("źle");
		}
		start.showPk();
	}

	private void miejscePapier()
	{
		if (pictureBoxOdpadek.Left > 390 && pictureBoxOdpadek.Top < 190)
		{
			start.pk++;
			Debug.WriteLine("Papier");
			pictureBoxOdpadek.Left = 390;
			pictureBoxOdpadek.Top = 190;
			Debug.WriteLine("Dobrze");
		}
		else
		{
			shuldContinueMethod = false;
			panelBackColor.Left = pictureBoxOdpadek.Left - 5;
			panelBackColor.Top = pictureBoxOdpadek.Top - 5;
			panelBackColor.Visible = true;
			Debug.WriteLine("źle");
		}
		start.showPk();
	}

	private void miejsceBio()
	{
		if (pictureBoxOdpadek.Left > 390 && pictureBoxOdpadek.Top > 190)
		{
			start.pk++;
			Debug.WriteLine("Bio");
			pictureBoxOdpadek.Left = 390;
			pictureBoxOdpadek.Top = 190;
			Debug.WriteLine("Dobrze");
		}
		else
		{
			shuldContinueMethod = false;
			panelBackColor.Left = pictureBoxOdpadek.Left - 5;
			panelBackColor.Top = pictureBoxOdpadek.Top - 5;
			panelBackColor.Visible = true;
			Debug.WriteLine("źle");
		}
		start.showPk();
	}

	private void pictureBoxOdpadek_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			PanelMouseDownLocation = e.Location;
		}
		panelBackColor.Visible = false;
	}

	private void pictureBoxOdpadek_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			pictureBoxOdpadek.Left += e.X - PanelMouseDownLocation.X;
			pictureBoxOdpadek.Top += e.Y - PanelMouseDownLocation.Y;
		}
	}

	private void pictureBoxOdpadek_MouseUp(object sender, MouseEventArgs e)
	{
		changeNextImage();
		shuldContinueMethod = true;
		Debug.WriteLine(start.pk);
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
		this.labelPapier = new System.Windows.Forms.Label();
		this.labelSzkło = new System.Windows.Forms.Label();
		this.labelBio = new System.Windows.Forms.Label();
		this.labelPlastiki = new System.Windows.Forms.Label();
		this.panelBackColor = new System.Windows.Forms.Panel();
		this.pictureBoxOdpadek = new System.Windows.Forms.PictureBox();
		this.pictureBoxPlastiki = new System.Windows.Forms.PictureBox();
		this.pictureBoxPapier = new System.Windows.Forms.PictureBox();
		this.pictureBoxBioodpady = new System.Windows.Forms.PictureBox();
		this.pictureBoxSzkło = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxOdpadek).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxPlastiki).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxPapier).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxBioodpady).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxSzkło).BeginInit();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.labelPapier.AutoSize = true;
		this.labelPapier.BackColor = System.Drawing.Color.FromArgb(51, 133, 255);
		this.labelPapier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.labelPapier.Font = new System.Drawing.Font("Ubuntu Medium", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		this.labelPapier.ForeColor = System.Drawing.SystemColors.ControlText;
		this.labelPapier.Location = new System.Drawing.Point(651, 216);
		this.labelPapier.Name = "labelPapier";
		this.labelPapier.Size = new System.Drawing.Size(81, 27);
		this.labelPapier.TabIndex = 6;
		this.labelPapier.Text = "Papier";
		this.labelSzkło.AutoSize = true;
		this.labelSzkło.BackColor = System.Drawing.Color.FromArgb(191, 210, 0);
		this.labelSzkło.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.labelSzkło.Font = new System.Drawing.Font("Ubuntu Medium", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		this.labelSzkło.ForeColor = System.Drawing.SystemColors.ControlText;
		this.labelSzkło.Location = new System.Drawing.Point(200, 473);
		this.labelSzkło.Name = "labelSzkło";
		this.labelSzkło.Size = new System.Drawing.Size(70, 27);
		this.labelSzkło.TabIndex = 7;
		this.labelSzkło.Text = "Szkło";
		this.labelBio.AutoSize = true;
		this.labelBio.BackColor = System.Drawing.Color.FromArgb(200, 117, 65);
		this.labelBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.labelBio.Font = new System.Drawing.Font("Ubuntu Medium", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		this.labelBio.ForeColor = System.Drawing.SystemColors.ControlText;
		this.labelBio.Location = new System.Drawing.Point(628, 473);
		this.labelBio.Name = "labelBio";
		this.labelBio.Size = new System.Drawing.Size(128, 27);
		this.labelBio.TabIndex = 8;
		this.labelBio.Text = "Bioodpady";
		this.labelPlastiki.AutoSize = true;
		this.labelPlastiki.BackColor = System.Drawing.Color.FromArgb(254, 216, 93);
		this.labelPlastiki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.labelPlastiki.Font = new System.Drawing.Font("Ubuntu Medium", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		this.labelPlastiki.ForeColor = System.Drawing.SystemColors.ControlText;
		this.labelPlastiki.Location = new System.Drawing.Point(75, 216);
		this.labelPlastiki.Name = "labelPlastiki";
		this.labelPlastiki.Size = new System.Drawing.Size(309, 27);
		this.labelPlastiki.TabIndex = 5;
		this.labelPlastiki.Text = "Metale i tworzywa sztuczne";
		this.panelBackColor.BackColor = System.Drawing.Color.Red;
		this.panelBackColor.Location = new System.Drawing.Point(385, 185);
		this.panelBackColor.Name = "panelBackColor";
		this.panelBackColor.Size = new System.Drawing.Size(140, 140);
		this.panelBackColor.TabIndex = 14;
		this.pictureBoxOdpadek.BackColor = System.Drawing.Color.White;
		this.pictureBoxOdpadek.BackgroundImage = Odnawialne_Źródła_Energii.Properties.Resources.arrw0y6c;
		this.pictureBoxOdpadek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBoxOdpadek.Location = new System.Drawing.Point(390, 190);
		this.pictureBoxOdpadek.Name = "pictureBoxOdpadek";
		this.pictureBoxOdpadek.Size = new System.Drawing.Size(130, 130);
		this.pictureBoxOdpadek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBoxOdpadek.TabIndex = 10;
		this.pictureBoxOdpadek.TabStop = false;
		this.pictureBoxOdpadek.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOdpadek_MouseDown);
		this.pictureBoxOdpadek.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOdpadek_MouseMove);
		this.pictureBoxOdpadek.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOdpadek_MouseUp);
		this.pictureBoxPlastiki.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.pictureBoxPlastiki.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.pictureBoxPlastiki.BackgroundImage = Odnawialne_Źródła_Energii.Properties.Resources.KoszPlastik;
		this.pictureBoxPlastiki.Location = new System.Drawing.Point(0, 0);
		this.pictureBoxPlastiki.Name = "pictureBoxPlastiki";
		this.pictureBoxPlastiki.Size = new System.Drawing.Size(455, 256);
		this.pictureBoxPlastiki.TabIndex = 9;
		this.pictureBoxPlastiki.TabStop = false;
		this.pictureBoxPapier.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.pictureBoxPapier.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.pictureBoxPapier.BackgroundImage = Odnawialne_Źródła_Energii.Properties.Resources.KoszPapier1;
		this.pictureBoxPapier.Location = new System.Drawing.Point(455, 0);
		this.pictureBoxPapier.Name = "pictureBoxPapier";
		this.pictureBoxPapier.Size = new System.Drawing.Size(455, 256);
		this.pictureBoxPapier.TabIndex = 13;
		this.pictureBoxPapier.TabStop = false;
		this.pictureBoxBioodpady.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.pictureBoxBioodpady.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.pictureBoxBioodpady.BackgroundImage = Odnawialne_Źródła_Energii.Properties.Resources.KoszBio;
		this.pictureBoxBioodpady.Location = new System.Drawing.Point(455, 256);
		this.pictureBoxBioodpady.Name = "pictureBoxBioodpady";
		this.pictureBoxBioodpady.Size = new System.Drawing.Size(455, 256);
		this.pictureBoxBioodpady.TabIndex = 12;
		this.pictureBoxBioodpady.TabStop = false;
		this.pictureBoxSzkło.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.pictureBoxSzkło.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.pictureBoxSzkło.BackgroundImage = Odnawialne_Źródła_Energii.Properties.Resources.KoszSzkło1;
		this.pictureBoxSzkło.Location = new System.Drawing.Point(0, 256);
		this.pictureBoxSzkło.Name = "pictureBoxSzkło";
		this.pictureBoxSzkło.Size = new System.Drawing.Size(455, 256);
		this.pictureBoxSzkło.TabIndex = 11;
		this.pictureBoxSzkło.TabStop = false;
		this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.panel1.Controls.Add(this.labelPlastiki);
		this.panel1.Controls.Add(this.labelPapier);
		this.panel1.Controls.Add(this.labelSzkło);
		this.panel1.Controls.Add(this.labelBio);
		this.panel1.Controls.Add(this.pictureBoxPlastiki);
		this.panel1.Controls.Add(this.pictureBoxPapier);
		this.panel1.Controls.Add(this.pictureBoxBioodpady);
		this.panel1.Controls.Add(this.pictureBoxSzkło);
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.MaximumSize = new System.Drawing.Size(910, 515);
		this.panel1.MinimumSize = new System.Drawing.Size(910, 515);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(910, 515);
		this.panel1.TabIndex = 15;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		base.ClientSize = new System.Drawing.Size(910, 509);
		base.Controls.Add(this.pictureBoxOdpadek);
		base.Controls.Add(this.panelBackColor);
		base.Controls.Add(this.panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "SortowanieŚmieic";
		this.Text = "SortowanieŚmieic";
		((System.ComponentModel.ISupportInitialize)this.pictureBoxOdpadek).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxPlastiki).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxPapier).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxBioodpady).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxSzkło).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
	}
}
