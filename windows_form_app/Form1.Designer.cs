﻿namespace windows_form_app
{
    partial class Form1
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
            this.calcolaOre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Today = new System.Windows.Forms.Label();
            this.LocalDateHours = new System.Windows.Forms.Label();
            this.CreateExcel = new System.Windows.Forms.Button();
            this.SelectLavorationAlert = new System.Windows.Forms.Label();
            this.DeleteFromMySQLDB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowCustomLavorations = new System.Windows.Forms.ComboBox();
            this.CreateCustomLavorations = new System.Windows.Forms.Button();
            this.ResetHours = new System.Windows.Forms.Button();
            this.Result7Fase = new System.Windows.Forms.Label();
            this.Result6Fase = new System.Windows.Forms.Label();
            this.Result4Fase = new System.Windows.Forms.Label();
            this.Result5Fase = new System.Windows.Forms.Label();
            this.Result3Fase = new System.Windows.Forms.Label();
            this.Result2Fase = new System.Windows.Forms.Label();
            this.Result1Fase = new System.Windows.Forms.Label();
            this.ShowValues = new System.Windows.Forms.Label();
            this.oreMacchina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TikTakClock = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calcolaOre
            // 
            this.calcolaOre.Location = new System.Drawing.Point(29, 133);
            this.calcolaOre.Name = "calcolaOre";
            this.calcolaOre.Size = new System.Drawing.Size(141, 23);
            this.calcolaOre.TabIndex = 2;
            this.calcolaOre.Text = "Calcola Ore";
            this.calcolaOre.Click += new System.EventHandler(this.CalcolaOre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Today);
            this.groupBox1.Controls.Add(this.LocalDateHours);
            this.groupBox1.Controls.Add(this.CreateExcel);
            this.groupBox1.Controls.Add(this.SelectLavorationAlert);
            this.groupBox1.Controls.Add(this.DeleteFromMySQLDB);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ShowCustomLavorations);
            this.groupBox1.Controls.Add(this.CreateCustomLavorations);
            this.groupBox1.Controls.Add(this.ResetHours);
            this.groupBox1.Controls.Add(this.Result7Fase);
            this.groupBox1.Controls.Add(this.Result6Fase);
            this.groupBox1.Controls.Add(this.Result4Fase);
            this.groupBox1.Controls.Add(this.Result5Fase);
            this.groupBox1.Controls.Add(this.Result3Fase);
            this.groupBox1.Controls.Add(this.Result2Fase);
            this.groupBox1.Controls.Add(this.Result1Fase);
            this.groupBox1.Controls.Add(this.ShowValues);
            this.groupBox1.Controls.Add(this.oreMacchina);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.calcolaOre);
            this.groupBox1.Location = new System.Drawing.Point(55, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 531);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome User";
            // 
            // Today
            // 
            this.Today.AutoSize = true;
            this.Today.Location = new System.Drawing.Point(707, 437);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(64, 17);
            this.Today.TabIndex = 24;
            this.Today.Text = "Sono le: ";
            this.Today.Click += new System.EventHandler(this.Today_Click);
            // 
            // LocalDateHours
            // 
            this.LocalDateHours.AutoSize = true;
            this.LocalDateHours.Location = new System.Drawing.Point(707, 406);
            this.LocalDateHours.Name = "LocalDateHours";
            this.LocalDateHours.Size = new System.Drawing.Size(64, 17);
            this.LocalDateHours.TabIndex = 23;
            this.LocalDateHours.Text = "Sono le: ";
            this.LocalDateHours.Click += new System.EventHandler(this.LocalDateHours_Click);
            // 
            // CreateExcel
            // 
            this.CreateExcel.Location = new System.Drawing.Point(29, 406);
            this.CreateExcel.Name = "CreateExcel";
            this.CreateExcel.Size = new System.Drawing.Size(141, 23);
            this.CreateExcel.TabIndex = 22;
            this.CreateExcel.Text = "Genera Excel";
            this.CreateExcel.Click += new System.EventHandler(this.CreateExcel_Click);
            // 
            // SelectLavorationAlert
            // 
            this.SelectLavorationAlert.AutoSize = true;
            this.SelectLavorationAlert.Location = new System.Drawing.Point(492, 169);
            this.SelectLavorationAlert.Name = "SelectLavorationAlert";
            this.SelectLavorationAlert.Size = new System.Drawing.Size(147, 17);
            this.SelectLavorationAlert.TabIndex = 21;
            this.SelectLavorationAlert.Text = "Inserire la lavorazione";
            this.SelectLavorationAlert.Click += new System.EventHandler(this.SelectLavorationAlert_Click);
            // 
            // DeleteFromMySQLDB
            // 
            this.DeleteFromMySQLDB.Location = new System.Drawing.Point(759, 117);
            this.DeleteFromMySQLDB.Name = "DeleteFromMySQLDB";
            this.DeleteFromMySQLDB.Size = new System.Drawing.Size(160, 24);
            this.DeleteFromMySQLDB.TabIndex = 20;
            this.DeleteFromMySQLDB.Text = "Elimina Lavorazione";
            this.DeleteFromMySQLDB.UseVisualStyleBackColor = true;
            this.DeleteFromMySQLDB.Click += new System.EventHandler(this.DeleteFromMySQLDB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::windows_form_app.Properties.Resources.L_S_logo;
            this.pictureBox1.Location = new System.Drawing.Point(782, 459);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mostra lavorazioni disponibili";
            // 
            // ShowCustomLavorations
            // 
            this.ShowCustomLavorations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShowCustomLavorations.FormattingEnabled = true;
            this.ShowCustomLavorations.Location = new System.Drawing.Point(495, 117);
            this.ShowCustomLavorations.Name = "ShowCustomLavorations";
            this.ShowCustomLavorations.Size = new System.Drawing.Size(258, 24);
            this.ShowCustomLavorations.TabIndex = 16;
            this.ShowCustomLavorations.SelectedIndexChanged += new System.EventHandler(this.ShowCustomLavorations_SelectedIndexChanged);
            // 
            // CreateCustomLavorations
            // 
            this.CreateCustomLavorations.Location = new System.Drawing.Point(495, 38);
            this.CreateCustomLavorations.Name = "CreateCustomLavorations";
            this.CreateCustomLavorations.Size = new System.Drawing.Size(258, 34);
            this.CreateCustomLavorations.TabIndex = 15;
            this.CreateCustomLavorations.Text = "Crea Lavorazione Personalizzata";
            this.CreateCustomLavorations.UseVisualStyleBackColor = true;
            this.CreateCustomLavorations.Click += new System.EventHandler(this.CreateCustomLavorations_Click);
            // 
            // ResetHours
            // 
            this.ResetHours.Location = new System.Drawing.Point(29, 178);
            this.ResetHours.Name = "ResetHours";
            this.ResetHours.Size = new System.Drawing.Size(141, 23);
            this.ResetHours.TabIndex = 11;
            this.ResetHours.Text = "Reset";
            this.ResetHours.Click += new System.EventHandler(this.ResetHours_Click);
            // 
            // Result7Fase
            // 
            this.Result7Fase.AutoSize = true;
            this.Result7Fase.Location = new System.Drawing.Point(225, 232);
            this.Result7Fase.Name = "Result7Fase";
            this.Result7Fase.Size = new System.Drawing.Size(91, 17);
            this.Result7Fase.TabIndex = 10;
            this.Result7Fase.Text = "Ore 1° Prova";
            // 
            // Result6Fase
            // 
            this.Result6Fase.AutoSize = true;
            this.Result6Fase.Location = new System.Drawing.Point(225, 205);
            this.Result6Fase.Name = "Result6Fase";
            this.Result6Fase.Size = new System.Drawing.Size(124, 17);
            this.Result6Fase.TabIndex = 9;
            this.Result6Fase.Text = "Ore Assemblaggio";
            this.Result6Fase.Click += new System.EventHandler(this.Result6Fase_Click);
            // 
            // Result4Fase
            // 
            this.Result4Fase.AutoSize = true;
            this.Result4Fase.Location = new System.Drawing.Point(225, 149);
            this.Result4Fase.Name = "Result4Fase";
            this.Result4Fase.Size = new System.Drawing.Size(97, 17);
            this.Result4Fase.TabIndex = 7;
            this.Result4Fase.Text = "Ore Fresatura";
            this.Result4Fase.Click += new System.EventHandler(this.Result4Fase_Click);
            // 
            // Result5Fase
            // 
            this.Result5Fase.AutoSize = true;
            this.Result5Fase.Location = new System.Drawing.Point(225, 178);
            this.Result5Fase.Name = "Result5Fase";
            this.Result5Fase.Size = new System.Drawing.Size(132, 17);
            this.Result5Fase.TabIndex = 8;
            this.Result5Fase.Text = "Ore Elettroerosione";
            this.Result5Fase.Click += new System.EventHandler(this.Result5Fase_Click);
            // 
            // Result3Fase
            // 
            this.Result3Fase.AutoSize = true;
            this.Result3Fase.Location = new System.Drawing.Point(225, 120);
            this.Result3Fase.Name = "Result3Fase";
            this.Result3Fase.Size = new System.Drawing.Size(64, 17);
            this.Result3Fase.TabIndex = 6;
            this.Result3Fase.Text = "Ore Cam";
            this.Result3Fase.Click += new System.EventHandler(this.Result3Fase_Click);
            // 
            // Result2Fase
            // 
            this.Result2Fase.AutoSize = true;
            this.Result2Fase.Location = new System.Drawing.Point(225, 94);
            this.Result2Fase.Name = "Result2Fase";
            this.Result2Fase.Size = new System.Drawing.Size(122, 17);
            this.Result2Fase.TabIndex = 5;
            this.Result2Fase.Text = "Ore Arrivo Acciaio";
            this.Result2Fase.Click += new System.EventHandler(this.Result2Fase_Click);
            // 
            // Result1Fase
            // 
            this.Result1Fase.AutoSize = true;
            this.Result1Fase.Location = new System.Drawing.Point(225, 67);
            this.Result1Fase.Name = "Result1Fase";
            this.Result1Fase.Size = new System.Drawing.Size(90, 17);
            this.Result1Fase.TabIndex = 4;
            this.Result1Fase.Text = "Ore Progetto";
            this.Result1Fase.Click += new System.EventHandler(this.Result1Fase_Click);
            // 
            // ShowValues
            // 
            this.ShowValues.AutoSize = true;
            this.ShowValues.Location = new System.Drawing.Point(225, 38);
            this.ShowValues.Name = "ShowValues";
            this.ShowValues.Size = new System.Drawing.Size(98, 17);
            this.ShowValues.TabIndex = 3;
            this.ShowValues.Text = "Risultati in ore";
            this.ShowValues.Click += new System.EventHandler(this.ShowValues_Click);
            // 
            // oreMacchina
            // 
            this.oreMacchina.Location = new System.Drawing.Point(29, 67);
            this.oreMacchina.Name = "oreMacchina";
            this.oreMacchina.Size = new System.Drawing.Size(141, 22);
            this.oreMacchina.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inserire ore macchina";
            // 
            // TikTakClock
            // 
            this.TikTakClock.Tick += new System.EventHandler(this.TikTakClock_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1030, 610);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Button calcolaOre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox oreMacchina;
        private System.Windows.Forms.Label label2; // è la scritta: "Inserire ore macchina"
        private System.Windows.Forms.Label ShowValues;
        private System.Windows.Forms.Label Result1Fase;
        private System.Windows.Forms.Label Result6Fase;
        private System.Windows.Forms.Label Result4Fase;
        private System.Windows.Forms.Label Result5Fase;
        private System.Windows.Forms.Label Result3Fase;
        private System.Windows.Forms.Label Result2Fase;
        private System.Windows.Forms.Label Result7Fase;
        private System.Windows.Forms.Button ResetHours;
        private System.Windows.Forms.Button CreateCustomLavorations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ShowCustomLavorations;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DeleteFromMySQLDB;
        private System.Windows.Forms.Label SelectLavorationAlert;
        private System.Windows.Forms.Button CreateExcel;
        private System.Windows.Forms.Label LocalDateHours;
        private System.Windows.Forms.Timer TikTakClock;
        private System.Windows.Forms.Label Today;
    }
}