using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Odnawialne_Źródła_Energii;

public class ListaNarzędzi : Form
{
	private Start start;

	private MachineRepository machineRepository = new MachineRepository();

	private IContainer components = null;

	private DataGridView dataGridViewToolsList;

	private Button buttonNext;

	private Button buttonNewItem;

	private Button buttonDelete;

	private Button buttonEdit;

	private Panel panel1;

	public ListaNarzędzi(Start start)
	{
		InitializeComponent();
		this.start = start;
		showData();
	}

	private void buttonNext_Click(object sender, EventArgs e)
	{
		start.buttonŹródłaPrądu_Click(null, EventArgs.Empty);
	}

	public void showData()
	{
		dataGridViewToolsList.DataSource = machineRepository.GetDataTable();
	}

	public void buttonNewItem_Click(object sender, EventArgs e)
	{
		AddNewItem addNewItem = new AddNewItem(this);
		addNewItem.clearFields();
		addNewItem.Show();
	}

	private void buttonDelete_Click(object sender, EventArgs e)
	{
		DeleteRow deleteRow = new DeleteRow(this);
		deleteRow.clearFields();
		deleteRow.Show();
	}

	public void buttonEdit_Click(object sender, EventArgs e)
	{
		EditRow editRow = new EditRow(this);
		editRow.clearFields();
		editRow.Show();
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
		this.dataGridViewToolsList = new System.Windows.Forms.DataGridView();
		this.buttonNext = new System.Windows.Forms.Button();
		this.buttonNewItem = new System.Windows.Forms.Button();
		this.buttonDelete = new System.Windows.Forms.Button();
		this.buttonEdit = new System.Windows.Forms.Button();
		this.panel1 = new System.Windows.Forms.Panel();
		((System.ComponentModel.ISupportInitialize)this.dataGridViewToolsList).BeginInit();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.dataGridViewToolsList.AllowUserToAddRows = false;
		this.dataGridViewToolsList.AllowUserToDeleteRows = false;
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(32, 33, 50);
		dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
		this.dataGridViewToolsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
		this.dataGridViewToolsList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.dataGridViewToolsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.dataGridViewToolsList.BackgroundColor = System.Drawing.Color.FromArgb(32, 33, 50);
		this.dataGridViewToolsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.dataGridViewToolsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.dataGridViewToolsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(32, 33, 50);
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dataGridViewToolsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.dataGridViewToolsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewToolsList.Cursor = System.Windows.Forms.Cursors.Default;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(32, 33, 50);
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(32, 33, 50);
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.dataGridViewToolsList.DefaultCellStyle = dataGridViewCellStyle3;
		this.dataGridViewToolsList.EnableHeadersVisualStyles = false;
		this.dataGridViewToolsList.GridColor = System.Drawing.Color.White;
		this.dataGridViewToolsList.Location = new System.Drawing.Point(131, 89);
		this.dataGridViewToolsList.Name = "dataGridViewToolsList";
		this.dataGridViewToolsList.ReadOnly = true;
		this.dataGridViewToolsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(32, 35, 40);
		dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9f);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.NullValue = null;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dataGridViewToolsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.dataGridViewToolsList.RowHeadersVisible = false;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(32, 33, 50);
		this.dataGridViewToolsList.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.dataGridViewToolsList.RowTemplate.Height = 25;
		this.dataGridViewToolsList.Size = new System.Drawing.Size(653, 229);
		this.dataGridViewToolsList.TabIndex = 0;
		this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.buttonNext.AutoSize = true;
		this.buttonNext.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonNext.FlatAppearance.BorderSize = 0;
		this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonNext.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonNext.ForeColor = System.Drawing.Color.Black;
		this.buttonNext.Location = new System.Drawing.Point(498, 74);
		this.buttonNext.Name = "buttonNext";
		this.buttonNext.Size = new System.Drawing.Size(153, 32);
		this.buttonNext.TabIndex = 1;
		this.buttonNext.Text = "Przejdź dalej";
		this.buttonNext.UseVisualStyleBackColor = false;
		this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
		this.buttonNewItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.buttonNewItem.AutoSize = true;
		this.buttonNewItem.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonNewItem.FlatAppearance.BorderSize = 0;
		this.buttonNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonNewItem.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonNewItem.ForeColor = System.Drawing.Color.Black;
		this.buttonNewItem.Location = new System.Drawing.Point(498, 3);
		this.buttonNewItem.Name = "buttonNewItem";
		this.buttonNewItem.Size = new System.Drawing.Size(153, 32);
		this.buttonNewItem.TabIndex = 2;
		this.buttonNewItem.Text = "Dodaj urządzenie";
		this.buttonNewItem.UseVisualStyleBackColor = false;
		this.buttonNewItem.Click += new System.EventHandler(this.buttonNewItem_Click);
		this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.buttonDelete.AutoSize = true;
		this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonDelete.FlatAppearance.BorderSize = 0;
		this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonDelete.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonDelete.ForeColor = System.Drawing.Color.Black;
		this.buttonDelete.Location = new System.Drawing.Point(339, 3);
		this.buttonDelete.Name = "buttonDelete";
		this.buttonDelete.Size = new System.Drawing.Size(153, 32);
		this.buttonDelete.TabIndex = 3;
		this.buttonDelete.Text = "Usuń";
		this.buttonDelete.UseVisualStyleBackColor = false;
		this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
		this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.buttonEdit.AutoSize = true;
		this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(46, 183, 87);
		this.buttonEdit.FlatAppearance.BorderSize = 0;
		this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonEdit.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.buttonEdit.ForeColor = System.Drawing.Color.Black;
		this.buttonEdit.Location = new System.Drawing.Point(180, 3);
		this.buttonEdit.Name = "buttonEdit";
		this.buttonEdit.Size = new System.Drawing.Size(153, 32);
		this.buttonEdit.TabIndex = 4;
		this.buttonEdit.Text = "Edytuj";
		this.buttonEdit.UseVisualStyleBackColor = false;
		this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
		this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.panel1.AutoSize = true;
		this.panel1.Controls.Add(this.buttonEdit);
		this.panel1.Controls.Add(this.buttonNewItem);
		this.panel1.Controls.Add(this.buttonNext);
		this.panel1.Controls.Add(this.buttonDelete);
		this.panel1.Location = new System.Drawing.Point(131, 328);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(653, 109);
		this.panel1.TabIndex = 5;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(51, 51, 77);
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.ClientSize = new System.Drawing.Size(910, 509);
		base.Controls.Add(this.dataGridViewToolsList);
		base.Controls.Add(this.panel1);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "ListaNarzędzi";
		this.Text = "Kalkulator oszczędności";
		((System.ComponentModel.ISupportInitialize)this.dataGridViewToolsList).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
