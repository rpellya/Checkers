namespace CheckersApp
{
    partial class Settings
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
            this.About = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.brown = new System.Windows.Forms.RadioButton();
            this.red = new System.Windows.Forms.RadioButton();
            this.black = new System.Windows.Forms.RadioButton();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // About
            // 
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.About.Location = new System.Drawing.Point(59, 247);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(207, 91);
            this.About.TabIndex = 2;
            this.About.Text = "Об игре";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(604, -3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(38, 40);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "✖ ";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brown);
            this.groupBox1.Controls.Add(this.red);
            this.groupBox1.Controls.Add(this.black);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(31, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 174);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор цвета шашки";
            // 
            // brown
            // 
            this.brown.AutoSize = true;
            this.brown.Location = new System.Drawing.Point(395, 62);
            this.brown.Name = "brown";
            this.brown.Size = new System.Drawing.Size(150, 28);
            this.brown.TabIndex = 2;
            this.brown.TabStop = true;
            this.brown.Text = "Коричневый";
            this.brown.UseVisualStyleBackColor = true;
            this.brown.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(208, 62);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(113, 28);
            this.red.TabIndex = 1;
            this.red.TabStop = true;
            this.red.Text = "Красный";
            this.red.UseVisualStyleBackColor = true;
            this.red.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // black
            // 
            this.black.AutoSize = true;
            this.black.Checked = true;
            this.black.Location = new System.Drawing.Point(28, 62);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(102, 28);
            this.black.TabIndex = 0;
            this.black.TabStop = true;
            this.black.Text = "Черный";
            this.black.UseVisualStyleBackColor = true;
            this.black.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(369, 247);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(207, 91);
            this.Save.TabIndex = 5;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.About);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton brown;
        private System.Windows.Forms.RadioButton red;
        private System.Windows.Forms.RadioButton black;
        private System.Windows.Forms.Button Save;
    }
}