namespace MusicalPerformers.WinForms.Views.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Authorization = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.InfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Authorization
            // 
            this.Authorization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Authorization.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorization.Location = new System.Drawing.Point(12, 12);
            this.Authorization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(755, 50);
            this.Authorization.TabIndex = 0;
            this.Authorization.Text = "Авторизация";
            this.InfoToolTip.SetToolTip(this.Authorization, "Авторизация");
            this.Authorization.UseVisualStyleBackColor = true;
            this.Authorization.Click += new System.EventHandler(this.Authorization_Click);
            // 
            // Registration
            // 
            this.Registration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Registration.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(12, 68);
            this.Registration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(755, 50);
            this.Registration.TabIndex = 1;
            this.Registration.Text = "Регистрация";
            this.InfoToolTip.SetToolTip(this.Registration, "Регистрация");
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Settings
            // 
            this.Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings.Location = new System.Drawing.Point(12, 124);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(755, 50);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Настройки";
            this.InfoToolTip.SetToolTip(this.Settings, "Настройки");
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(12, 180);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(755, 50);
            this.Exit.TabIndex = 3;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 241);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Authorization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(797, 288);
            this.MinimumSize = new System.Drawing.Size(797, 288);
            this.Name = "Main";
            this.Text = "Электронный каталог музыкальных исполнителей - Главное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Authorization;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ToolTip InfoToolTip;
    }
}