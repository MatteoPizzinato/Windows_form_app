namespace windows_form_app
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
            this.calcolaOre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowCustomLavorations = new System.Windows.Forms.ComboBox();
            this.CreateCustomLavorations = new System.Windows.Forms.Button();
            this.LavorazionePlasticaRadioButton = new System.Windows.Forms.RadioButton();
            this.LavorazioneFerroRadioButton = new System.Windows.Forms.RadioButton();
            this.LavorazioneLentiRadioButton = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcolaOre
            // 
            this.calcolaOre.Location = new System.Drawing.Point(12, 238);
            this.calcolaOre.Name = "calcolaOre";
            this.calcolaOre.Size = new System.Drawing.Size(141, 23);
            this.calcolaOre.TabIndex = 2;
            this.calcolaOre.Text = "Calcola Ore";
            this.calcolaOre.Click += new System.EventHandler(this.calcolaOre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ShowCustomLavorations);
            this.groupBox1.Controls.Add(this.CreateCustomLavorations);
            this.groupBox1.Controls.Add(this.LavorazionePlasticaRadioButton);
            this.groupBox1.Controls.Add(this.LavorazioneFerroRadioButton);
            this.groupBox1.Controls.Add(this.LavorazioneLentiRadioButton);
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
            // LavorazionePlasticaRadioButton
            // 
            this.LavorazionePlasticaRadioButton.AutoSize = true;
            this.LavorazionePlasticaRadioButton.Location = new System.Drawing.Point(312, 45);
            this.LavorazionePlasticaRadioButton.Name = "LavorazionePlasticaRadioButton";
            this.LavorazionePlasticaRadioButton.Size = new System.Drawing.Size(160, 21);
            this.LavorazionePlasticaRadioButton.TabIndex = 14;
            this.LavorazionePlasticaRadioButton.TabStop = true;
            this.LavorazionePlasticaRadioButton.Text = "Lavorazione Plastica";
            this.LavorazionePlasticaRadioButton.UseVisualStyleBackColor = true;
            this.LavorazionePlasticaRadioButton.CheckedChanged += new System.EventHandler(this.LavorazionePlasticaRadioButton_CheckedChanged);
            // 
            // LavorazioneFerroRadioButton
            // 
            this.LavorazioneFerroRadioButton.AutoSize = true;
            this.LavorazioneFerroRadioButton.Location = new System.Drawing.Point(160, 45);
            this.LavorazioneFerroRadioButton.Name = "LavorazioneFerroRadioButton";
            this.LavorazioneFerroRadioButton.Size = new System.Drawing.Size(145, 21);
            this.LavorazioneFerroRadioButton.TabIndex = 13;
            this.LavorazioneFerroRadioButton.TabStop = true;
            this.LavorazioneFerroRadioButton.Text = "Lavorazione Ferro";
            this.LavorazioneFerroRadioButton.UseVisualStyleBackColor = true;
            this.LavorazioneFerroRadioButton.CheckedChanged += new System.EventHandler(this.LavorazioneFerroRadioButton_CheckedChanged);
            // 
            // LavorazioneLentiRadioButton
            // 
            this.LavorazioneLentiRadioButton.AutoSize = true;
            this.LavorazioneLentiRadioButton.Location = new System.Drawing.Point(12, 45);
            this.LavorazioneLentiRadioButton.Name = "LavorazioneLentiRadioButton";
            this.LavorazioneLentiRadioButton.Size = new System.Drawing.Size(142, 21);
            this.LavorazioneLentiRadioButton.TabIndex = 12;
            this.LavorazioneLentiRadioButton.TabStop = true;
            this.LavorazioneLentiRadioButton.Text = "Lavorazione Lenti";
            this.LavorazioneLentiRadioButton.UseVisualStyleBackColor = true;
            this.LavorazioneLentiRadioButton.CheckedChanged += new System.EventHandler(this.LavorazioneLentiRadioButton_CheckedChanged);
            // 
            // ResetHours
            // 
            this.ResetHours.Location = new System.Drawing.Point(12, 283);
            this.ResetHours.Name = "ResetHours";
            this.ResetHours.Size = new System.Drawing.Size(141, 23);
            this.ResetHours.TabIndex = 11;
            this.ResetHours.Text = "Reset";
            this.ResetHours.Click += new System.EventHandler(this.ResetHours_Click);
            // 
            // Result7Fase
            // 
            this.Result7Fase.AutoSize = true;
            this.Result7Fase.Location = new System.Drawing.Point(219, 337);
            this.Result7Fase.Name = "Result7Fase";
            this.Result7Fase.Size = new System.Drawing.Size(212, 17);
            this.Result7Fase.TabIndex = 10;
            this.Result7Fase.Text = "Le ore per la settima fase sono: ";
            // 
            // Result6Fase
            // 
            this.Result6Fase.AutoSize = true;
            this.Result6Fase.Location = new System.Drawing.Point(219, 310);
            this.Result6Fase.Name = "Result6Fase";
            this.Result6Fase.Size = new System.Drawing.Size(201, 17);
            this.Result6Fase.TabIndex = 9;
            this.Result6Fase.Text = "Le ore per la sesta fase sono: ";
            this.Result6Fase.Click += new System.EventHandler(this.Result6Fase_Click);
            // 
            // Result4Fase
            // 
            this.Result4Fase.AutoSize = true;
            this.Result4Fase.Location = new System.Drawing.Point(219, 254);
            this.Result4Fase.Name = "Result4Fase";
            this.Result4Fase.Size = new System.Drawing.Size(208, 17);
            this.Result4Fase.TabIndex = 7;
            this.Result4Fase.Text = "Le ore per la quarta fase sono: ";
            this.Result4Fase.Click += new System.EventHandler(this.Result4Fase_Click);
            // 
            // Result5Fase
            // 
            this.Result5Fase.AutoSize = true;
            this.Result5Fase.Location = new System.Drawing.Point(219, 283);
            this.Result5Fase.Name = "Result5Fase";
            this.Result5Fase.Size = new System.Drawing.Size(206, 17);
            this.Result5Fase.TabIndex = 8;
            this.Result5Fase.Text = "Le ore per la quinta fase sono: ";
            this.Result5Fase.Click += new System.EventHandler(this.Result5Fase_Click);
            // 
            // Result3Fase
            // 
            this.Result3Fase.AutoSize = true;
            this.Result3Fase.Location = new System.Drawing.Point(219, 225);
            this.Result3Fase.Name = "Result3Fase";
            this.Result3Fase.Size = new System.Drawing.Size(199, 17);
            this.Result3Fase.TabIndex = 6;
            this.Result3Fase.Text = "Le ore per la terza fase sono: ";
            this.Result3Fase.Click += new System.EventHandler(this.Result3Fase_Click);
            // 
            // Result2Fase
            // 
            this.Result2Fase.AutoSize = true;
            this.Result2Fase.Location = new System.Drawing.Point(219, 199);
            this.Result2Fase.Name = "Result2Fase";
            this.Result2Fase.Size = new System.Drawing.Size(221, 17);
            this.Result2Fase.TabIndex = 5;
            this.Result2Fase.Text = "Le ore per la seconda fase sono: ";
            this.Result2Fase.Click += new System.EventHandler(this.Result2Fase_Click);
            // 
            // Result1Fase
            // 
            this.Result1Fase.AutoSize = true;
            this.Result1Fase.Location = new System.Drawing.Point(219, 172);
            this.Result1Fase.Name = "Result1Fase";
            this.Result1Fase.Size = new System.Drawing.Size(202, 17);
            this.Result1Fase.TabIndex = 4;
            this.Result1Fase.Text = "Le ore per la prima fase sono: ";
            this.Result1Fase.Click += new System.EventHandler(this.Result1Fase_Click);
            // 
            // ShowValues
            // 
            this.ShowValues.AutoSize = true;
            this.ShowValues.Location = new System.Drawing.Point(219, 143);
            this.ShowValues.Name = "ShowValues";
            this.ShowValues.Size = new System.Drawing.Size(98, 17);
            this.ShowValues.TabIndex = 3;
            this.ShowValues.Text = "Risultati in ore";
            this.ShowValues.Click += new System.EventHandler(this.ShowValues_Click);
            // 
            // oreMacchina
            // 
            this.oreMacchina.Location = new System.Drawing.Point(12, 172);
            this.oreMacchina.Name = "oreMacchina";
            this.oreMacchina.Size = new System.Drawing.Size(141, 22);
            this.oreMacchina.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inserire ore macchina";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1030, 783);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RadioButton LavorazioneLentiRadioButton;
        private System.Windows.Forms.RadioButton LavorazioneFerroRadioButton;
        private System.Windows.Forms.RadioButton LavorazionePlasticaRadioButton;
        private System.Windows.Forms.Button CreateCustomLavorations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ShowCustomLavorations;
    }
}