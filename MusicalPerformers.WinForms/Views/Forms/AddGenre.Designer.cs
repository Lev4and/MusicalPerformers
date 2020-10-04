namespace MusicalPerformers.WinForms.Views.Forms
{
    partial class AddGenre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGenre));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenreName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Save)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GenreName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 50);
            this.panel1.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.Image = global::MusicalPerformers.WinForms.Properties.Resources.Save;
            this.Save.Location = new System.Drawing.Point(378, 68);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(50, 50);
            this.Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Save.TabIndex = 1;
            this.Save.TabStop = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название жанра:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenreName
            // 
            this.GenreName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreName.Location = new System.Drawing.Point(175, 11);
            this.GenreName.Name = "GenreName";
            this.GenreName.Size = new System.Drawing.Size(598, 30);
            this.GenreName.TabIndex = 2;
            // 
            // AddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 133);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddGenre";
            this.Text = "Электронный каталог музыкальных исполнителей - Добавление жанра";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Save)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Save;
        private System.Windows.Forms.TextBox GenreName;
        private System.Windows.Forms.Label label1;
    }
}