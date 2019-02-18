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
            this.Result1Fase = new System.Windows.Forms.Label();
            this.ShowValues = new System.Windows.Forms.Label();
            this.oreMacchina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcolaOre
            // 
            this.calcolaOre.Location = new System.Drawing.Point(9, 137);
            this.calcolaOre.Name = "calcolaOre";
            this.calcolaOre.Size = new System.Drawing.Size(141, 23);
            this.calcolaOre.TabIndex = 2;
            this.calcolaOre.Text = "Calcola Ore";
            this.calcolaOre.Click += new System.EventHandler(this.calcolaOre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Result1Fase);
            this.groupBox1.Controls.Add(this.ShowValues);
            this.groupBox1.Controls.Add(this.oreMacchina);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.calcolaOre);
            this.groupBox1.Location = new System.Drawing.Point(107, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome";
            // 
            // Result1Fase
            // 
            this.Result1Fase.AutoSize = true;
            this.Result1Fase.Location = new System.Drawing.Point(219, 71);
            this.Result1Fase.Name = "Result1Fase";
            this.Result1Fase.Size = new System.Drawing.Size(202, 17);
            this.Result1Fase.TabIndex = 4;
            this.Result1Fase.Text = "Le ore per la prima fase sono: ";
            this.Result1Fase.Click += new System.EventHandler(this.Result1Fase_Click);
            // 
            // ShowValues
            // 
            this.ShowValues.AutoSize = true;
            this.ShowValues.Location = new System.Drawing.Point(216, 42);
            this.ShowValues.Name = "ShowValues";
            this.ShowValues.Size = new System.Drawing.Size(105, 17);
            this.ShowValues.TabIndex = 3;
            this.ShowValues.Text = "Mostra Risultati";
            this.ShowValues.Click += new System.EventHandler(this.ShowValues_Click);
            // 
            // oreMacchina
            // 
            this.oreMacchina.Location = new System.Drawing.Point(9, 71);
            this.oreMacchina.Name = "oreMacchina";
            this.oreMacchina.Size = new System.Drawing.Size(141, 22);
            this.oreMacchina.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button calcolaOre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox oreMacchina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ShowValues;
        private System.Windows.Forms.Label Result1Fase;
    }
}