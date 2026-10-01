using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Odnawialne_Źródła_Energii;

public class ListaŹródeł : Form
{
	private Start start;

	private SourcesRepository sourcesRepository = new SourcesRepository();

	private IContainer components = null;

	private Button buttonNext;

	private DataGridView dataGridViewPanelsProperties;

	private Button buttonEdit;

	private Button buttonDelete;

	private Button buttonNewSources;

	private Panel panel1;

	public ListaŹródeł(Start start)
	{
		InitializeComponent();
		this.start = start;
		showData();
	}

	private void buttonNext_Click(object sender, EventArgs e)
	{
		start.buttonPodsumowanie_Click(null, EventArgs.Empty);
	}

	public void showData()
	{
		dataGridViewPanelsProperties.DataSource = sourcesRepository.GetDataTable();
	}

	public void buttonNewSources_Click(object sender, EventArgs e)
	{
		AddNewSources addNewSources = new AddNewSources(this);
		addNewSources.clearFields();
		addNewSources.Show();
	}

	private void buttonDelete_Click(object sender, EventArgs e)
	{
		DeleteRowSources deleteRowSources = new DeleteRowSources(this);
		deleteRowSources.clearFields();
		deleteRowSources.Show();
	}

	public void buttonEdit_Click(object sender, EventArgs e)
	{
		EditRowSources editRowSources = new EditRowSources(this);
		editRowSources.clearFields();
		editRowSources.Show();
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		this.dataGridViewPanelsProperties = new System.Windows.Forms.DataGridView();
		this.buttonNext = new System.Windows.Forms.Button();
		this.buttonEdit = new System.Windows.Forms.Button();
		this.buttonDelete = new System.Windows.Forms.Button();
		this.buttonNewSources = new System.Windows.Forms.Button();
		this.panel1 = new System.Windows.Forms.Panel();
		((System.ComponentModel.ISupportInitialize)this.dataGridViewPanelsProperties).BeginInit();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.dataGridViewPanelsProperties.AllowUserToAddRows = false;
		this.dataGridViewPanelsProperties.AllowUserToDeleteRows = false;
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(32, 35, 40);
		dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
		this.dataGridViewPanelsProperties.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
		this.dataGridViewPanelsProperties.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.dataGridViewPanelsProperties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.dataGridViewPanelsProperties.BackgroundColor = System.Drawing.Color.FromArgb(32, 33, 50);
		this.dataGridViewPanelsProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.dataGridViewPanelsProperties.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.dataGridViewPanelsProperties.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(32, 35, 40);
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dataGridViewPanelsProperties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.dataGridViewPanelsProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewPanelsProperties.Cursor = System.Windows.Forms.Cursors.Default;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(32, 35, 40);
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.dataGridViewPanelsProperties.DefaultCellStyle = dataGridViewCellStyle3;
		this.dataGridViewPanelsProperties.EnableHeadersVisualStyles = false;
		this.dataGridViewPanelsProperties.GridColor = System.Drawing.Color.White;
		this.dataGridViewPanelsProperties.Location = new System.Drawing.Point(131, 89);
		this.dataGridViewPanelsProperties.Name = "dataGridViewPanelsProperties";
		this.dataGridViewPanelsProperties.ReadOnly = true;
		this.dataGridViewPanelsProperties.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(32, 35, 40);
		dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dataGridViewPanelsProperties.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.dataGridViewPanelsProperties.RowHeadersVisible = false;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(32, 33, 50);
		this.dataGridViewPanelsProperties.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.dataGridViewPanelsProperties.Size = new System.Drawing.Size(653, 229);
		this.dataGridViewPanelsProperties.TabIndex = 0;
		this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.buttonNext.AutoSize = true;
		this.buttonNext.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonNext.FlatAppearance.BorderSize = 0;
		this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonNext.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonNext.Location = new System.Drawing.Point(498, 74);
		this.buttonNext.Name = "buttonNext";
		this.buttonNext.Size = new System.Drawing.Size(153, 32);
		this.buttonNext.TabIndex = 3;
		this.buttonNext.Text = "Przejdź dalej";
		this.buttonNext.UseVisualStyleBackColor = false;
		this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
		this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.buttonEdit.AutoSize = true;
		this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonEdit.FlatAppearance.BorderSize = 0;
		this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonEdit.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonEdit.Location = new System.Drawing.Point(180, 3);
		this.buttonEdit.Name = "buttonEdit";
		this.buttonEdit.Size = new System.Drawing.Size(153, 32);
		this.buttonEdit.TabIndex = 7;
		this.buttonEdit.Text = "Edytuj";
		this.buttonEdit.UseVisualStyleBackColor = false;
		this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
		this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.buttonDelete.AutoSize = true;
		this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonDelete.FlatAppearance.BorderSize = 0;
		this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonDelete.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonDelete.Location = new System.Drawing.Point(339, 3);
		this.buttonDelete.Name = "buttonDelete";
		this.buttonDelete.Size = new System.Drawing.Size(153, 32);
		this.buttonDelete.TabIndex = 6;
		this.buttonDelete.Text = "Usuń";
		this.buttonDelete.UseVisualStyleBackColor = false;
		this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
		this.buttonNewSources.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.buttonNewSources.AutoSize = true;
		this.buttonNewSources.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonNewSources.FlatAppearance.BorderSize = 0;
		this.buttonNewSources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonNewSources.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonNewSources.Location = new System.Drawing.Point(498, 3);
		this.buttonNewSources.Name = "buttonNewSources";
		this.buttonNewSources.Size = new System.Drawing.Size(153, 32);
		this.buttonNewSources.TabIndex = 5;
		this.buttonNewSources.Text = "Dodaj urządzenie";
		this.buttonNewSources.UseVisualStyleBackColor = false;
		this.buttonNewSources.Click += new System.EventHandler(this.buttonNewSources_Click);
		this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.panel1.AutoSize = true;
		this.panel1.Controls.Add(this.buttonEdit);
		this.panel1.Controls.Add(this.buttonNewSources);
		this.panel1.Controls.Add(this.buttonDelete);
		this.panel1.Controls.Add(this.buttonNext);
		this.panel1.Location = new System.Drawing.Point(131, 328);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(653, 109);
		this.panel1.TabIndex = 8;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoSize = true;
		this.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.ClientSize = new System.Drawing.Size(910, 509);
		base.Controls.Add(this.dataGridViewPanelsProperties);
		base.Controls.Add(this.panel1);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "ListaŹródeł";
		this.Text = "Form1";
		((System.ComponentModel.ISupportInitialize)this.dataGridViewPanelsProperties).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
