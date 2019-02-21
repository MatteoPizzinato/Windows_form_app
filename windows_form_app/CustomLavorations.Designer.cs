namespace windows_form_app
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
            this.CustomLavorationContainer = new System.Windows.Forms.GroupBox();
            this.SavingDataInMySQLDB = new System.Windows.Forms.Button();
            this.InsertNameCustomLavoration = new System.Windows.Forms.TextBox();
            this.CustomLavorationName = new System.Windows.Forms.Label();
            this.CustomLavorationContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomLavorationContainer
            // 
            this.CustomLavorationContainer.Controls.Add(this.SavingDataInMySQLDB);
            this.CustomLavorationContainer.Controls.Add(this.InsertNameCustomLavoration);
            this.CustomLavorationContainer.Controls.Add(this.CustomLavorationName);
            this.CustomLavorationContainer.Location = new System.Drawing.Point(40, 17);
            this.CustomLavorationContainer.Name = "CustomLavorationContainer";
            this.CustomLavorationContainer.Size = new System.Drawing.Size(686, 394);
            this.CustomLavorationContainer.TabIndex = 0;
            this.CustomLavorationContainer.TabStop = false;
            this.CustomLavorationContainer.Text = "Lavorazione personalizzata";
            // 
            // SavingDataInMySQLDB
            // 
            this.SavingDataInMySQLDB.Location = new System.Drawing.Point(9, 130);
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
            this.Controls.Add(this.CustomLavorationContainer);
            this.Name = "CustomLavorations";
            this.Text = "CustomLavorations";
            this.CustomLavorationContainer.ResumeLayout(false);
            this.CustomLavorationContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomLavorationContainer;
        private System.Windows.Forms.TextBox InsertNameCustomLavoration;
        private System.Windows.Forms.Label CustomLavorationName;
        private System.Windows.Forms.Button SavingDataInMySQLDB;
    }
}