namespace MusicalPerformers.WinForms.Views.Forms
{
    partial class Genres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Genres));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Remove = new System.Windows.Forms.PictureBox();
            this.Edit = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchQuery = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.GenreIdTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreNameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Remove);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 50);
            this.panel1.TabIndex = 0;
            // 
            // Remove
            // 
            this.Remove.Image = global::MusicalPerformers.WinForms.Properties.Resources.Remove;
            this.Remove.Location = new System.Drawing.Point(168, 0);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(50, 50);
            this.Remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Remove.TabIndex = 4;
            this.Remove.TabStop = false;
            this.Remove.Visible = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Edit
            // 
            this.Edit.Image = global::MusicalPerformers.WinForms.Properties.Resources.Edit;
            this.Edit.Location = new System.Drawing.Point(112, 0);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(50, 50);
            this.Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Edit.TabIndex = 3;
            this.Edit.TabStop = false;
            this.Edit.Visible = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Image = global::MusicalPerformers.WinForms.Properties.Resources.Add;
            this.Add.Location = new System.Drawing.Point(56, 0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(50, 50);
            this.Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add.TabIndex = 2;
            this.Add.TabStop = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Back
            // 
            this.Back.Image = global::MusicalPerformers.WinForms.Properties.Resources.Back;
            this.Back.Location = new System.Drawing.Point(0, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(50, 50);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 1;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.SearchQuery);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Location = new System.Drawing.Point(236, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 50);
            this.panel2.TabIndex = 1;
            // 
            // SearchQuery
            // 
            this.SearchQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchQuery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchQuery.Font = new System.Drawing.Font("Times New Roman", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchQuery.Location = new System.Drawing.Point(0, 1);
            this.SearchQuery.Name = "SearchQuery";
            this.SearchQuery.Size = new System.Drawing.Size(496, 48);
            this.SearchQuery.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Image = global::MusicalPerformers.WinForms.Properties.Resources.Search;
            this.Search.Location = new System.Drawing.Point(502, 0);
            this.Search.MaximumSize = new System.Drawing.Size(50, 50);
            this.Search.MinimumSize = new System.Drawing.Size(50, 50);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(50, 50);
            this.Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Search.TabIndex = 5;
            this.Search.TabStop = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.DataGridView);
            this.panel4.Location = new System.Drawing.Point(12, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 370);
            this.panel4.TabIndex = 3;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GenreIdTextBoxColumn,
            this.GenreNameTextBoxColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.Location = new System.Drawing.Point(3, 3);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(770, 364);
            this.DataGridView.TabIndex = 0;
            // 
            // GenreIdTextBoxColumn
            // 
            this.GenreIdTextBoxColumn.DataPropertyName = "genre_id";
            this.GenreIdTextBoxColumn.HeaderText = "Идентификационный номер";
            this.GenreIdTextBoxColumn.MinimumWidth = 6;
            this.GenreIdTextBoxColumn.Name = "GenreIdTextBoxColumn";
            this.GenreIdTextBoxColumn.ReadOnly = true;
            this.GenreIdTextBoxColumn.Visible = false;
            this.GenreIdTextBoxColumn.Width = 377;
            // 
            // GenreNameTextBoxColumn
            // 
            this.GenreNameTextBoxColumn.DataPropertyName = "name";
            this.GenreNameTextBoxColumn.HeaderText = "Имя жанра";
            this.GenreNameTextBoxColumn.MinimumWidth = 6;
            this.GenreNameTextBoxColumn.Name = "GenreNameTextBoxColumn";
            this.GenreNameTextBoxColumn.ReadOnly = true;
            this.GenreNameTextBoxColumn.Width = 173;
            // 
            // Genres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Genres";
            this.Text = "Электронный каталог музыкальных исполнителей - Жанры";
            this.Load += new System.EventHandler(this.Genres_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.PictureBox Remove;
        private System.Windows.Forms.PictureBox Edit;
        private System.Windows.Forms.PictureBox Add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchQuery;
        private System.Windows.Forms.PictureBox Search;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreIdTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreNameTextBoxColumn;
    }
}