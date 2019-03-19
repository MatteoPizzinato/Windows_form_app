using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace windows_form_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //FillCombo();
            countTables();            
        }
        /* Variabili per lo storage dei valori da usare durante i calcoli delle ore con una lavorazione personalizzata */
        float storage_value_data_1;
        float storage_value_data_2;
        float storage_value_data_3;
        float storage_value_data_4;
        float storage_value_data_5;
        float storage_value_data_6;
        float storage_value_data_7;

        /* array che contiene i valori standard per le 3 lavorazioni di base più utilizzate */
       
        public void Clear()
        {
            // voglio creare un metodo clear per eliminare i risultati in coda al label 
            Result1Fase.Text = "Le ore per la prima fase sono: ";
            Result2Fase.Text = "Le ore per la seconda fase sono: ";
            Result3Fase.Text = "Le ore per la terza fase sono: ";
            Result4Fase.Text = "Le ore per la quarta fase sono: ";
            Result5Fase.Text = "Le ore per la quinta fase sono: ";
            Result6Fase.Text = "Le ore per la sesta fase sono: ";
            Result7Fase.Text = "Le ore per la settima fase sono: ";
        }

        private void oreMacchina_TextChanged(object sender, EventArgs e)
        {
            // questo private void mi serve per ??
        }

        private void calcolaOre_Click(object sender, EventArgs e)
        {

             elaborate();
             calculateCustomTimeWPL();

            /* per stampare un valore preso in input bisogna rischiamare direttamente la text box tramite
            il suo nome così verrà stampato il suo valore */
            if(ShowCustomLavorations.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Prego selezionare la lavorazione");
            }

        }
        private void ShowValues_Click(object sender, EventArgs e)
        {
            // label con la scritta "Riusutati in ore" 
        }

        private void Result1Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void Result2Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void Result3Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void Result4Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void Result5Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
             secondo le percentuali per ogni lavorazione */
        }

        private void Result6Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void Result7Fase_Click(object sender, EventArgs e)
        {
            /* in questo label printo attraverso la funzione CalculateHours_LL il valore delle ore
            secondo le percentuali per ogni lavorazione */
        }

        private void ResetHours_Click(object sender, EventArgs e)
        {
            Clear();
            oreMacchina.Text = " "; // cancello automaticamente le ore inserite in precedenza
        }


        private void CreateCustomLavorations_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            CustomLavorations createNewLavorations = new CustomLavorations();

            // Show the settings form
            createNewLavorations.Show();
        }
        // riapro la connessione al database, mi serve per vedere le lavorazioni customizzate disponibili 
        //  Funzione Timer che pensavo fosse utile per refreshare i risulatati all'interno del DB 
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=ScatterpH8.41");
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

        /* adesso creo delle funzioni per gestire l'apertura e la chiusura della connessione in base alle esigenze */
        void FillCombo() /* Ho creato due modi differenti per effettuare una connessione perchè così vedo i pro ed i contro dell'effettuare le connessioni in un determinato modo piuttosto che un altro, 
                            che alla fine non sono poi così molto diverse le due connesisoni usate */
        {
            string query = "USE lavorazioni_meccaniche; SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA='lavorazioni_meccaniche';";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader myReader;

            try // provo ad eseguire il comando che dovrebbe ritornarmi il nome delle tabelle sul menù dropdown
            {
                openConnection();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    string nameTable = myReader.GetString("TABLE_NAME");
                    ShowCustomLavorations.Items.Remove(nameTable);
                    ShowCustomLavorations.Items.Add(nameTable);
                }
            }
            catch (Exception ex) // e se c'è un eccezione la prendo e la mostro
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        public void countTables()
        {
            Timer myTimer;
            myTimer = new Timer();
            myTimer.Interval = 5000; // controllo ogni 5 secondi 
            myTimer.Tick += new EventHandler(check);
            myTimer.Start();


            void check(object sender, EventArgs e)
            {
                string query_2 = "USE lavorazioni_meccaniche; SELECT count(*) FROM information_schema.TABLES WHERE table_schema = database(); ";
                MySqlCommand command = new MySqlCommand(query_2, connection);

                MySqlDataReader myReader_2;

                string OldNumTable = "";
                string countIndex = ShowCustomLavorations.Items.Count.ToString();

                try // provo ad eseguire il comando che dovrebbe ritornarmi il nome delle tabelle sul menù dropdown
                {
                    openConnection();
                    myReader_2 = command.ExecuteReader();
                    while (myReader_2.Read())
                    {
                        OldNumTable = myReader_2.GetString("count(*)");  // scorta di punti esclamativi !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!                                            
                    }
                }
                catch (Exception ex) // e se c'è un eccezione la prendo e la mostro
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    closeConnection();
                }

                if (OldNumTable != countIndex)
                {
                    FillCombo();
                    //myTimer.Stop();
                    MessageBox.Show("sono passati 5 secondi e mi sono refreshata");
                }
            }
        }

        public void ShowCustomLavorations_SelectedIndexChanged(object sender, EventArgs e)
        {
            // serve per far funzionare il dropdwon menu           
        }

        public void elaborate() // function which I used for take the value of the phases of a custom lavoration and store it in variables
        {
            string table_name = ShowCustomLavorations.SelectedItem.ToString(); // prendo il valore che seleziono nel dropdown menù e lo salvo in una variabile che uso come identificativo poi per prendere i valori relativi a quella tabella

            if (ShowCustomLavorations.SelectedItem.GetType() == null) 
            {
                throw new System.NullReferenceException();
            }
            try
            {
                // non so cosa scrivere nel try                
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show(exception.ToString());
                MessageBox.Show("Inserire una lavorazione");
            }
          
            string select_value = "USE lavorazioni_meccaniche; SELECT percentPhase1, percentPhase2, percentPhase3, percentPhase4, percentPhase5, percentPhase6, percentPhase7 FROM lavorazioni_meccaniche." + table_name + ";"; //, percentPhase2, percentPhase3, percentPhase4, percentPhase5, percentPhase6, percentPhase7
            MySqlCommand command = new MySqlCommand(select_value, connection);

            MySqlDataReader myReader_getData;                      

            try // provo ad eseguire il comando che dovrebbe ritornarmi il nome delle tabelle sul menù dropdown
            {
                openConnection();
                myReader_getData = command.ExecuteReader();
                while (myReader_getData.Read())
                {
                    storage_value_data_1 = myReader_getData.GetInt32("percentPhase1"); // scorta di punti esclamativi !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!                                            
                    storage_value_data_2 = myReader_getData.GetInt32("percentPhase2");
                    storage_value_data_3 = myReader_getData.GetInt32("percentPhase3");
                    storage_value_data_4 = myReader_getData.GetInt32("percentPhase4");
                    storage_value_data_5 = myReader_getData.GetInt32("percentPhase5");
                    storage_value_data_6 = myReader_getData.GetInt32("percentPhase6");
                    storage_value_data_7 = myReader_getData.GetInt32("percentPhase7"); // riesco a prendere il valore contenuto nella colonna relativa alla lavorazione, e metterla in una variabile da adoperare poi                                                                        
                }                
            }
            catch (Exception ex) // e se c'è un eccezione la prendo e la mostro
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }   
        }

        public void calculateCustomTimeWPL() // calculate time with custom time with personal lavoration
        {
            float value = 0;

            float.TryParse(oreMacchina.Text, out value); // parso la stringa in un float, lo faccio per poter fare i calcoli 

            // adesso faccio i calcoli per prima fase
            float result_1 = (value * storage_value_data_1) / 100; // risultato per le ore relative alla prima lavorazione            
            TimeSpan timespan_1 = TimeSpan.FromHours(result_1); // con il timespan converto i decimali in ore 
            string output_hours_1 = timespan_1.ToString("hh\\:mm\\:ss"); // così visualizzo le ore, i minuti ed i secondi previsti per ogni fase
            Result1Fase.Text = Result1Fase.Text + output_hours_1; // stampo nello spazio giusto i valori

            // adesso faccio i calcoli per seconda fase
            float result_2 = (value * storage_value_data_2) / 100;            
            TimeSpan timespan_2 = TimeSpan.FromHours(result_2);
            string output_hours_2 = timespan_2.ToString("hh\\:mm\\:ss");
            Result2Fase.Text = Result2Fase.Text + output_hours_2;
            
            // adesso faccio i calcoli per terza fase
            float result_3 = (value * storage_value_data_3) / 100;            
            TimeSpan timespan_3 = TimeSpan.FromHours(result_3); 
            string output_hours_3 = timespan_3.ToString("hh\\:mm\\:ss");
            Result3Fase.Text = Result3Fase.Text + output_hours_3;

            // adesso faccio i calcoli per quarta fase
            float result_4 = (value * storage_value_data_4) / 100;
            TimeSpan timespan_4 = TimeSpan.FromHours(result_4);
            string output_hours_4 = timespan_4.ToString("hh\\:mm\\:ss");
            Result4Fase.Text = Result4Fase.Text + output_hours_4;

            // adesso faccio i calcoli per quinta fase
            float result_5 = (value * storage_value_data_5) / 100;
            TimeSpan timespan_5 = TimeSpan.FromHours(result_5);
            string output_hours_5 = timespan_5.ToString("hh\\:mm\\:ss");
            Result5Fase.Text = Result5Fase.Text + output_hours_5;

            // adesso faccio i calcoli per sesta fase
            float result_6 = (value * storage_value_data_6) / 100;
            TimeSpan timespan_6 = TimeSpan.FromHours(result_6);
            string output_hours_6 = timespan_6.ToString("hh\\:mm\\:ss");
            Result6Fase.Text = Result6Fase.Text + output_hours_6;

            // adesso faccio i calcoli per settima fase
            float result_7 = (value * storage_value_data_7) / 100;
            TimeSpan timespan_7 = TimeSpan.FromHours(result_7);
            string output_hours_7 = timespan_7.ToString("hh\\:mm\\:ss");
            Result7Fase.Text = Result7Fase.Text + output_hours_7;
        }

        public void DeleteLavorationFromDB()
        {                        
            var delete_lavoration = ShowCustomLavorations.SelectedItem; // I save the name of the lavoration which I used later to delete that lavoration
            string query_delete = "USE lavorazioni_meccaniche; DROP TABLE lavorazioni_meccaniche." + delete_lavoration + ";" ; // drop the selected table
            MySqlCommand command_delete = new MySqlCommand(query_delete, connection);                        

            try // provo ad eseguire il comando che dovrebbe ritornarmi il nome delle tabelle sul menù dropdown
            {
                openConnection();
                command_delete.ExecuteNonQuery();
                ShowCustomLavorations.Items.Remove(delete_lavoration);

            }
            catch (Exception ex) // e se c'è un eccezione la prendo e la mostro
            {
                MessageBox.Show(ex.Message);
            }            
        }

    private void DeleteFromMySQLDB_Click(object sender, EventArgs e)
        {
            DeleteLavorationFromDB();            
        }
    }
}


/*
*
*
* DA FARE: ELIMINARE LE LAVORAZIONI PIù FREQUENTI CON IL RADIOBUTTON E LE FUNZIONI RELATIVE AD ESSE, METTERE TUTTO NEL DATABASE E CERCARE UN MODO PER GENERARE IL 
* FILE EXCEL CHE SARà LA COSA PIù ARDUA
* 
* 
*/
