using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace windows_form_app
{
    public partial class CustomLavorations : Form
    {
        public CustomLavorations()
        {
            InitializeComponent();
        }
        private void InsertNameCustomLavoration_TextChanged(object sender, EventArgs e)
        {
            InsertNameCustomLavoration.SelectionStart = 0; // dovrebbe prendere in input una stringa
            InsertNameCustomLavoration.SelectionLength = 0; // calcola la lunghezza dell'imput   
        }

        /* apro la connessione al DB */
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=ScatterpH8.41");
        /* adesso creo delle funzioni per gestire l'apertura e la chiusura della connessione in base alle esigenze */
        public void openConnection() // con questa funzione apro la connessione se questa è chiusa 
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection() // con questa funzione chiudo la connessione se questa è aperta
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }


        private void SavingDataInMySQLDB_Click(object sender, EventArgs e)
        {

        }
    }
}
