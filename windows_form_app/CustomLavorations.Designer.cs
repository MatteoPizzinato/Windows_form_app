﻿namespace windows_form_app
{
    partial class CustomLavorations
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
            this.SumPercentButton = new System.Windows.Forms.GroupBox();
            this.CheckSumPercent = new System.Windows.Forms.Button();
            this.DisplaySumPercent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustPercFase2 = new System.Windows.Forms.TextBox();
            this.CustPercFase3 = new System.Windows.Forms.TextBox();
            this.CustPercFase4 = new System.Windows.Forms.TextBox();
            this.CustPercFase5 = new System.Windows.Forms.TextBox();
            this.CustPercFase6 = new System.Windows.Forms.TextBox();
            this.CustPercFase7 = new System.Windows.Forms.TextBox();
            this.CustPercFase1 = new System.Windows.Forms.TextBox();
            this.Lavorazione7Custom = new System.Windows.Forms.Label();
            this.Lavorazione6Custom = new System.Windows.Forms.Label();
            this.Lavorazione5Custom = new System.Windows.Forms.Label();
            this.Lavorazione4Custom = new System.Windows.Forms.Label();
            this.Lavorazione3Custom = new System.Windows.Forms.Label();
            this.Lavorazione2Custom = new System.Windows.Forms.Label();
            this.Lavorazione1Custom = new System.Windows.Forms.Label();
            this.SavingDataInMySQLDB = new System.Windows.Forms.Button();
            this.InsertNameCustomLavoration = new System.Windows.Forms.TextBox();
            this.CustomLavorationName = new System.Windows.Forms.Label();
            this.SumPercentButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // SumPercentButton
            // 
            this.SumPercentButton.Controls.Add(this.CheckSumPercent);
            this.SumPercentButton.Controls.Add(this.DisplaySumPercent);
            this.SumPercentButton.Controls.Add(this.label8);
            this.SumPercentButton.Controls.Add(this.label7);
            this.SumPercentButton.Controls.Add(this.label6);
            this.SumPercentButton.Controls.Add(this.label5);
            this.SumPercentButton.Controls.Add(this.label4);
            this.SumPercentButton.Controls.Add(this.label3);
            this.SumPercentButton.Controls.Add(this.label2);
            this.SumPercentButton.Controls.Add(this.label1);
            this.SumPercentButton.Controls.Add(this.CustPercFase2);
            this.SumPercentButton.Controls.Add(this.CustPercFase3);
            this.SumPercentButton.Controls.Add(this.CustPercFase4);
            this.SumPercentButton.Controls.Add(this.CustPercFase5);
            this.SumPercentButton.Controls.Add(this.CustPercFase6);
            this.SumPercentButton.Controls.Add(this.CustPercFase7);
            this.SumPercentButton.Controls.Add(this.CustPercFase1);
            this.SumPercentButton.Controls.Add(this.Lavorazione7Custom);
            this.SumPercentButton.Controls.Add(this.Lavorazione6Custom);
            this.SumPercentButton.Controls.Add(this.Lavorazione5Custom);
            this.SumPercentButton.Controls.Add(this.Lavorazione4Custom);
            this.SumPercentButton.Controls.Add(this.Lavorazione3Custom);
            this.SumPercentButton.Controls.Add(this.Lavorazione2Custom);
            this.SumPercentButton.Controls.Add(this.Lavorazione1Custom);
            this.SumPercentButton.Controls.Add(this.SavingDataInMySQLDB);
            this.SumPercentButton.Controls.Add(this.InsertNameCustomLavoration);
            this.SumPercentButton.Controls.Add(this.CustomLavorationName);
            this.SumPercentButton.Location = new System.Drawing.Point(40, 12);
            this.SumPercentButton.Name = "SumPercentButton";
            this.SumPercentButton.Size = new System.Drawing.Size(721, 399);
            this.SumPercentButton.TabIndex = 0;
            this.SumPercentButton.TabStop = false;
            this.SumPercentButton.Text = "Creazione lavorazione per Charter";
            // 
            // CheckSumPercent
            // 
            this.CheckSumPercent.Location = new System.Drawing.Point(311, 130);
            this.CheckSumPercent.Name = "CheckSumPercent";
            this.CheckSumPercent.Size = new System.Drawing.Size(96, 32);
            this.CheckSumPercent.TabIndex = 26;
            this.CheckSumPercent.Text = "Check";
            this.CheckSumPercent.UseVisualStyleBackColor = true;
            this.CheckSumPercent.Click += new System.EventHandler(this.CheckSumPercent_Click);
            // 
            // DisplaySumPercent
            // 
            this.DisplaySumPercent.AutoSize = true;
            this.DisplaySumPercent.Location = new System.Drawing.Point(308, 165);
            this.DisplaySumPercent.Name = "DisplaySumPercent";
            this.DisplaySumPercent.Size = new System.Drawing.Size(201, 17);
            this.DisplaySumPercent.TabIndex = 25;
            this.DisplaySumPercent.Text = "La somma delle percentuali è: ";
            this.DisplaySumPercent.Click += new System.EventHandler(this.DisplaySumPercent_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Inserire percentuali personalizzate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "%";
            // 
            // CustPercFase2
            // 
            this.CustPercFase2.Location = new System.Drawing.Point(160, 186);
            this.CustPercFase2.Name = "CustPercFase2";
            this.CustPercFase2.Size = new System.Drawing.Size(65, 22);
            this.CustPercFase2.TabIndex = 16;
            this.CustPercFase2.Tag = "";
            // 
            // CustPercFase3
            // 
            this.CustPercFase3.Location = new System.Drawing.Point(160, 214);
            this.CustPercFase3.Name = "CustPercFase3";
            this.CustPercFase3.Size = new System.Drawing.Size(65, 22);
            this.CustPercFase3.TabIndex = 15;
            this.CustPercFase3.Tag = "";
            // 
            // CustPercFase4
            // 
            this.CustPercFase4.Location = new System.Drawing.Point(160, 243);
            this.CustPercFase4.Name = "CustPercFase4";
            this.CustPercFase4.Size = new System.Drawing.Size(65, 22);
            this.CustPercFase4.TabIndex = 14;
            this.CustPercFase4.Tag = "";
            // 
            // CustPercFase5
            // 
            this.CustPercFase5.Location = new System.Drawing.Point(160, 270);
            this.CustPercFase5.Name = "CustPercFase5";
            this.CustPercFase5.Size = new System.Drawing.Size(65, 22);
            this.CustPercFase5.TabIndex = 13;
            this.CustPercFase5.Tag = "";
            // 
            // CustPercFase6
            // 
            this.CustPercFase6.Location = new System.Drawing.Point(160, 299);
            this.CustPercFase6.Name = "CustPercFase6";
            this.CustPercFase6.Size = new System.Drawing.Size(65, 22);
            this.CustPercFase6.TabIndex = 12;
            this.CustPercFase6.Tag = "";
            // 
            // CustPercFase7
            // 
            this.CustPercFase7.Location = new System.Drawing.Point(160, 327);
            this.CustPercFase7.Name = "CustPercFase7";
            this.CustPercFase7.Size = new System.Drawing.Size(65, 22);
            this.CustPercFase7.TabIndex = 11;
            this.CustPercFase7.Tag = "";
            // 
            // CustPercFase1
            // 
            this.CustPercFase1.Location = new System.Drawing.Point(160, 158);
            this.CustPercFase1.Name = "CustPercFase1";
            this.CustPercFase1.Size = new System.Drawing.Size(65, 22);
            this.CustPercFase1.TabIndex = 10;
            this.CustPercFase1.Tag = "";
            // 
            // Lavorazione7Custom
            // 
            this.Lavorazione7Custom.AutoSize = true;
            this.Lavorazione7Custom.Location = new System.Drawing.Point(6, 328);
            this.Lavorazione7Custom.Name = "Lavorazione7Custom";
            this.Lavorazione7Custom.Size = new System.Drawing.Size(74, 17);
            this.Lavorazione7Custom.TabIndex = 9;
            this.Lavorazione7Custom.Text = "1° PROVA";
            // 
            // Lavorazione6Custom
            // 
            this.Lavorazione6Custom.AutoSize = true;
            this.Lavorazione6Custom.Location = new System.Drawing.Point(6, 301);
            this.Lavorazione6Custom.Name = "Lavorazione6Custom";
            this.Lavorazione6Custom.Size = new System.Drawing.Size(117, 17);
            this.Lavorazione6Custom.TabIndex = 8;
            this.Lavorazione6Custom.Text = "ASSEMBLAGGIO";
            // 
            // Lavorazione5Custom
            // 
            this.Lavorazione5Custom.AutoSize = true;
            this.Lavorazione5Custom.Location = new System.Drawing.Point(6, 272);
            this.Lavorazione5Custom.Name = "Lavorazione5Custom";
            this.Lavorazione5Custom.Size = new System.Drawing.Size(145, 17);
            this.Lavorazione5Custom.TabIndex = 7;
            this.Lavorazione5Custom.Text = "ELETTROEROSIONE";
            // 
            // Lavorazione4Custom
            // 
            this.Lavorazione4Custom.AutoSize = true;
            this.Lavorazione4Custom.Location = new System.Drawing.Point(6, 245);
            this.Lavorazione4Custom.Name = "Lavorazione4Custom";
            this.Lavorazione4Custom.Size = new System.Drawing.Size(91, 17);
            this.Lavorazione4Custom.TabIndex = 6;
            this.Lavorazione4Custom.Text = "FRESATURA";
            // 
            // Lavorazione3Custom
            // 
            this.Lavorazione3Custom.AutoSize = true;
            this.Lavorazione3Custom.Location = new System.Drawing.Point(6, 217);
            this.Lavorazione3Custom.Name = "Lavorazione3Custom";
            this.Lavorazione3Custom.Size = new System.Drawing.Size(37, 17);
            this.Lavorazione3Custom.TabIndex = 5;
            this.Lavorazione3Custom.Text = "CAM";
            // 
            // Lavorazione2Custom
            // 
            this.Lavorazione2Custom.AutoSize = true;
            this.Lavorazione2Custom.Location = new System.Drawing.Point(6, 191);
            this.Lavorazione2Custom.Name = "Lavorazione2Custom";
            this.Lavorazione2Custom.Size = new System.Drawing.Size(117, 17);
            this.Lavorazione2Custom.TabIndex = 4;
            this.Lavorazione2Custom.Text = "ARRIVO ACCIAIO";
            // 
            // Lavorazione1Custom
            // 
            this.Lavorazione1Custom.AutoSize = true;
            this.Lavorazione1Custom.Location = new System.Drawing.Point(6, 163);
            this.Lavorazione1Custom.Name = "Lavorazione1Custom";
            this.Lavorazione1Custom.Size = new System.Drawing.Size(87, 17);
            this.Lavorazione1Custom.TabIndex = 3;
            this.Lavorazione1Custom.Text = "PROGETTO";
            // 
            // SavingDataInMySQLDB
            // 
            this.SavingDataInMySQLDB.Location = new System.Drawing.Point(464, 356);
            this.SavingDataInMySQLDB.Name = "SavingDataInMySQLDB";
            this.SavingDataInMySQLDB.Size = new System.Drawing.Size(216, 32);
            this.SavingDataInMySQLDB.TabIndex = 2;
            this.SavingDataInMySQLDB.Text = "Save";
            this.SavingDataInMySQLDB.UseVisualStyleBackColor = true;
            this.SavingDataInMySQLDB.Click += new System.EventHandler(this.SavingDataInMySQLDB_Click);
            // 
            // InsertNameCustomLavoration
            // 
            this.InsertNameCustomLavoration.Location = new System.Drawing.Point(9, 80);
            this.InsertNameCustomLavoration.Name = "InsertNameCustomLavoration";
            this.InsertNameCustomLavoration.Size = new System.Drawing.Size(216, 22);
            this.InsertNameCustomLavoration.TabIndex = 1;
            this.InsertNameCustomLavoration.Tag = "";
            this.InsertNameCustomLavoration.TextChanged += new System.EventHandler(this.InsertNameCustomLavoration_TextChanged);
            // 
            // CustomLavorationName
            // 
            this.CustomLavorationName.AutoSize = true;
            this.CustomLavorationName.Location = new System.Drawing.Point(6, 40);
            this.CustomLavorationName.Name = "CustomLavorationName";
            this.CustomLavorationName.Size = new System.Drawing.Size(227, 17);
            this.CustomLavorationName.TabIndex = 0;
            this.CustomLavorationName.Text = "Inserire il nome  della  lavorazione ";
            // 
            // CustomLavorations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SumPercentButton);
            this.Name = "CustomLavorations";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CustomLavorations_Load);
            this.SumPercentButton.ResumeLayout(false);
            this.SumPercentButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SumPercentButton;
        private System.Windows.Forms.TextBox InsertNameCustomLavoration;
        private System.Windows.Forms.Label CustomLavorationName;
        private System.Windows.Forms.Button SavingDataInMySQLDB;
        private System.Windows.Forms.Label Lavorazione7Custom;
        private System.Windows.Forms.Label Lavorazione6Custom;
        private System.Windows.Forms.Label Lavorazione5Custom;
        private System.Windows.Forms.Label Lavorazione4Custom;
        private System.Windows.Forms.Label Lavorazione3Custom;
        private System.Windows.Forms.Label Lavorazione2Custom;
        private System.Windows.Forms.Label Lavorazione1Custom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustPercFase2;
        private System.Windows.Forms.TextBox CustPercFase3;
        private System.Windows.Forms.TextBox CustPercFase4;
        private System.Windows.Forms.TextBox CustPercFase5;
        private System.Windows.Forms.TextBox CustPercFase6;
        private System.Windows.Forms.TextBox CustPercFase7;
        private System.Windows.Forms.TextBox CustPercFase1;
        private System.Windows.Forms.Button CheckSumPercent;
        private System.Windows.Forms.Label DisplaySumPercent;
    }
}