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
            this.oreMacchina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcolaOre
            // 
            this.calcolaOre.Location = new System.Drawing.Point(107, 179);
            this.calcolaOre.Name = "calcolaOre";
            this.calcolaOre.Size = new System.Drawing.Size(157, 23);
            this.calcolaOre.TabIndex = 2;
            this.calcolaOre.Text = "Calcola Ore";
            this.calcolaOre.Click += new System.EventHandler(this.calcolaOre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oreMacchina);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(107, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome";
            // 
            // oreMacchina
            // 
            this.oreMacchina.Location = new System.Drawing.Point(9, 76);
            this.oreMacchina.Name = "oreMacchina";
            this.oreMacchina.Size = new System.Drawing.Size(131, 22);
            this.oreMacchina.TabIndex = 0;
            this.oreMacchina.Text = "Inserire ore macchina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "inserire ore macchina";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1030, 678);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calcolaOre);
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
    }
}