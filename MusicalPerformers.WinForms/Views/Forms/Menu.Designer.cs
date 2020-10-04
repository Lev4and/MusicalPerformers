namespace MusicalPerformers.WinForms.Views.Forms
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Genres = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.InfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Genres
            // 
            this.Genres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Genres.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Genres.Location = new System.Drawing.Point(12, 12);
            this.Genres.Name = "Genres";
            this.Genres.Size = new System.Drawing.Size(776, 50);
            this.Genres.TabIndex = 0;
            this.Genres.Text = "Жанры";
            this.InfoToolTip.SetToolTip(this.Genres, "Жанры");
            this.Genres.UseVisualStyleBackColor = true;
            this.Genres.Click += new System.EventHandler(this.Genres_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(12, 68);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(776, 50);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.InfoToolTip.SetToolTip(this.Exit, "Выход");
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // InfoToolTip
            // 
            this.InfoToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.InfoToolTip.ToolTipTitle = "Информация";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Genres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Menu";
            this.Text = "Электронный каталог музыкальных исполнителей - Меню";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Genres;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ToolTip InfoToolTip;
    }
}