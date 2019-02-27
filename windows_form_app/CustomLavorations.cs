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

        /*
            inizio private void per far funzionare le textBox
        */

        private void InsertNameCustomLavoration_TextChanged(object sender, EventArgs e)
        {
               
        }
        private void CustPercFase1_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }
        private void CustPercFase2_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }
        private void CustPercFase3_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }
        private void CustPercFase4_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }
        private void CustPercFase5_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }
        private void CustPercFase6_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }
        private void CustPercFase7_TextChanged(object sender, EventArgs e)
        {
            // questo privete void serve per far funzionare effettivamente la textBox 
        }

        /*
            fine private void per far funzionare le textBox
        */

        /* apro la connessione al DB */
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=ScatterpH8.41");
        MySqlCommand command;
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

        public void executeQuery(String query) // funzione che mi permette di creare una stringa per fare cose del database
        {
            try // provo ad aprire la connessione e generare un nuovo comando di query e di connessione 
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Query Executed");
                }else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch(Exception ex) // prendo l'eccezione e la mostro
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void SavingDataInMySQLDB_Click(object sender, EventArgs e)
        {

            string query_saving_custom_lavoration = "USE lavorazioni_meccaniche; CREATE TABLE " +InsertNameCustomLavoration.Text+ "(percent_phase_1 INT, percent_phase_2 INT, percent_phase_3 INT, percent_phase_4 INT, percent_phase_5 INT, percent_phase_6 INT, percent_phase_7 INT); INSERT INTO" + InsertNameCustomLavoration+" VALUES('"+CustPercFase1.Text+"','"+CustPercFase2.Text+"','"+CustPercFase3.Text+"','"+CustPercFase4.Text+"','"+CustPercFase5.Text+"','"+CustPercFase6.Text+"',"+CustPercFase7.Text+")";
            executeQuery(query_saving_custom_lavoration);
        }

        private void CustomLavorations_Load(object sender, EventArgs e)
        {

        }
    }
}
