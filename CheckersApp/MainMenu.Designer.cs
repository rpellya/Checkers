namespace CheckersApp
{
    partial class MainMenu
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
            this.StartGame = new System.Windows.Forms.Button();
            this.SettingsForm = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGame.Location = new System.Drawing.Point(498, 56);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(207, 91);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Начать игру";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // SettingsForm
            // 
            this.SettingsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsForm.Location = new System.Drawing.Point(498, 204);
            this.SettingsForm.Name = "SettingsForm";
            this.SettingsForm.Size = new System.Drawing.Size(207, 91);
            this.SettingsForm.TabIndex = 1;
            this.SettingsForm.Text = "Настройки";
            this.SettingsForm.UseVisualStyleBackColor = true;
            this.SettingsForm.Click += new System.EventHandler(this.SettingsForm_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(498, 342);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(207, 91);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = global::CheckersApp.Properties.Resources.kartinki24_ru_masha_and_the_bear_61;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 491);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SettingsForm);
            this.Controls.Add(this.StartGame);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button SettingsForm;
        private System.Windows.Forms.Button Exit;
    }
}