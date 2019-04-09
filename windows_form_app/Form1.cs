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
/* the depencies for using the xml properties and the Spreadsheet library */
using DocumentFormat.OpenXml; // for manipulate xml file
using System.Xml; // for manipulate xml file
using SpreadsheetLight; // for manipulate xml file
using System.Globalization; // manipulate and create a calendar
using DocumentFormat.OpenXml.Drawing;

namespace windows_form_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CountTables();
            BlockInsertHours();
            TikTakClock.Start();
            LocalDateHours.Text = DateTime.Now.ToLongTimeString(); // show the local hour
            Today.Text = DateTime.Today.ToLongDateString(); // show the current date
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

        private void OreMacchina_TextChanged(object sender, EventArgs e)
        {
            // questo private void mi serve per inserire le ore macchina            
        }

        private void CalcolaOre_Click(object sender, EventArgs e)
        {
            Elaborate();
            CalculateCustomTimeWPL();

            /* per stampare un valore preso in input bisogna rischiamare direttamente la text box tramite
            il suo nome così verrà stampato il suo valore */
            if (ShowCustomLavorations.SelectedItem.ToString() == null)
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
        public void OpenConnection() // con questa funzione apro la connessione se questa è chiusa 
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection() // con questa funzione chiudo la connessione se questa è aperta
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
                OpenConnection();
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
                CloseConnection();
            }
        }

        public void CountTables()
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
                    OpenConnection();
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
                    CloseConnection();
                }

                if (OldNumTable != countIndex)
                {
                    FillCombo();
                }
            }
        }

        public void ShowCustomLavorations_SelectedIndexChanged(object sender, EventArgs e)
        {
            // serve per far funzionare il dropdwon menu           
        }


        public void Elaborate() // function which I used for take the value of the phases of a custom lavoration and store it in variables
        {

            string table_name = ShowCustomLavorations.SelectedItem.ToString();  // prendo il valore che seleziono nel dropdown menù e lo salvo in una variabile che uso come identificativo poi per prendere i valori relativi a quella tabella

            string select_value = "USE lavorazioni_meccaniche; SELECT percentPhase1, percentPhase2, percentPhase3, percentPhase4, percentPhase5, percentPhase6, percentPhase7 FROM lavorazioni_meccaniche." + table_name + ";"; //, percentPhase2, percentPhase3, percentPhase4, percentPhase5, percentPhase6, percentPhase7
            MySqlCommand command = new MySqlCommand(select_value, connection);

            MySqlDataReader myReader_getData;

            try // provo ad eseguire il comando che dovrebbe ritornarmi il nome delle tabelle sul menù dropdown
            {
                OpenConnection();
                myReader_getData = command.ExecuteReader();
                while (myReader_getData.Read())
                {
                    storage_value_data_1 = myReader_getData.GetInt32("percentPhase1"); // scorta di punti esclamativi !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!                                            
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
                throw new System.NullReferenceException();
            }
            finally
            {
                CloseConnection();
            }
        }

        public void CalculateCustomTimeWPL() // calculate time with custom time with personal lavoration
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
            string query_delete = "USE lavorazioni_meccaniche; DROP TABLE lavorazioni_meccaniche." + delete_lavoration + ";"; // drop the selected table
            MySqlCommand command_delete = new MySqlCommand(query_delete, connection);

            try // provo ad eseguire il comando che dovrebbe ritornarmi il nome delle tabelle sul menù dropdown
            {
                OpenConnection();
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

        public void BlockInsertHours() // function which control every second if the user have selected a lavoration and block or allow the insertion of the hours
        { // non ha assolutamente senso mettere un timer al posto di un while ma non so perchè col while non funziona mentre con il timer si

            Timer myTimer;
            myTimer = new Timer();
            myTimer.Interval = 100; // controllo ogni 5 secondi 
            myTimer.Tick += new EventHandler(blockOrAllow);
            myTimer.Start();

            void blockOrAllow(object sender, EventArgs e)
            {
                if (ShowCustomLavorations.SelectedIndex.ToString() == "-1")
                {
                    oreMacchina.Enabled = false;
                    calcolaOre.Enabled = false;
                }
                else
                {
                    oreMacchina.Enabled = true;
                    calcolaOre.Enabled = true;
                }
                ShowHiddenAlertLabel();

                /*
                 * 
                while(ShowCustomLavorations.SelectedIndex.ToString() == "-1")
                {
                    oreMacchina.Enabled = false;
                    if (ShowCustomLavorations.SelectedIndex.ToString() != "-1")
                    {
                        oreMacchina.Enabled = true;
                    }
                }

                */

            }
        }
        public void ShowHiddenAlertLabel()
        {
            Color FailedColor = Color.Red;
            SelectLavorationAlert.ForeColor = FailedColor;
            if (oreMacchina.Enabled == false && calcolaOre.Enabled == false)
            {
                SelectLavorationAlert.Visible = true;
            } else
            {
                SelectLavorationAlert.Visible = false;
            }
        }

        private void SelectLavorationAlert_Click(object sender, EventArgs e)
        {
            // make active the red alert if an user don't select first a lavoration    
        }

        public void CreateCalendar(SLDocument document)
        {
            SLStyle date_style = document.CreateStyle();
            /* Date_style is the style which must have the date's cells */
            date_style.Alignment.Indent = 5;
            date_style.Alignment.JustifyLastLine = true;
            date_style.Alignment.ReadingOrder = SLAlignmentReadingOrderValues.RightToLeft;
            date_style.Alignment.ShrinkToFit = true;
            date_style.Alignment.TextRotation = 90;
            date_style.Font.FontColor = System.Drawing.Color.Black;
            date_style.Font.FontName = "Gill-Sans";
            date_style.Font.FontSize = 12;
            date_style.Font.Bold = true;
            date_style.SetBottomBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thick, System.Drawing.Color.Blue);
            date_style.Alignment.Horizontal = DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center;

            /* Style for separating weeks with a column left and a column right colored in blue */
            SLStyle date_column_left_style = document.CreateStyle();
            SLStyle date_column_right_style = document.CreateStyle();
            /* Style for the weeks */

            SLStyle week_style = document.CreateStyle();
            date_column_left_style.SetLeftBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thick, System.Drawing.Color.Blue);
            date_column_right_style.SetRightBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thick, System.Drawing.Color.Blue);
            /* Now I separe the weeks with blue colums, calling the date_column_left_style and the date_column_right_style */


            /* divide column from January to the end of April */
            document.SetCellStyle("B2", date_column_left_style); // put the column for divide weeks            
            document.SetCellStyle("H2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("O2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("V2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("AC2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("AJ2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("AQ2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("AX2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("BE2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("BL2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("BS2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("BZ2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("CG2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("CN2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("CU2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("DB2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("DI2", date_column_right_style); // put the column for divide weeks
            document.SetCellStyle("DP2", date_column_right_style); // put the column for divide weeks

            /* divide column from May to the end of July */
            document.SetCellStyle("DQ2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("DX2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("EE2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("EL2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("ES2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("EZ2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("FG2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("FN2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("FU2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("GB2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("GI2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("GP2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("GW2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("HD2", date_column_left_style); // put the column for divide weeks

            /* divide column from August to the end of November */
            document.SetCellStyle("HK2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("HR2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("HY2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("IF2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("IM2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("IT2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("JA2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("JH2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("JO2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("JV2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("KC2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("KJ2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("KQ2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("KX2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("LE2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("LL2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("LS2", date_column_left_style); // put the column for divide weeks      

            /* divide column of December */
            document.SetCellStyle("LZ2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("MG2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("MN2", date_column_left_style); // put the column for divide weeks
            document.SetCellStyle("MU2", date_column_left_style); // put the column for divide weeks            
            document.SetCellStyle("NB2", date_column_right_style); // put the column for divide weeks
            /* Style for displaing the weeks */
            week_style.Alignment.Indent = 5;
            week_style.Alignment.Horizontal = DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center;
            week_style.Font.FontColor = System.Drawing.Color.Blue;
            week_style.SetTopBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thick, System.Drawing.Color.Blue);
            week_style.SetLeftBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thick, System.Drawing.Color.Blue);
            week_style.SetRightBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thick, System.Drawing.Color.Blue);

            /* Creation of a calendar which is putted in the sheet */
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;
            DateTime localDateToday = DateTime.Today;

            string week = "W ";

            for (int i = 1; i <= 366; i++) // print the sequence of the weeks of a year
            {

                int f = 1;

                /* Print days from January to the end of April */
                document.MergeWorksheetCells("B1", "H1");
                document.MergeWorksheetCells("I1", "O1");
                document.MergeWorksheetCells("P1", "V1");
                document.MergeWorksheetCells("W1", "AC1");
                document.MergeWorksheetCells("AD1", "AJ1");
                document.MergeWorksheetCells("AK1", "AQ1");
                document.MergeWorksheetCells("AR1", "AX1");
                document.MergeWorksheetCells("AY1", "BE1");
                document.MergeWorksheetCells("BF1", "BL1");
                document.MergeWorksheetCells("BM1", "BS1");
                document.MergeWorksheetCells("BT1", "BZ1");
                document.MergeWorksheetCells("CA1", "CG1");
                document.MergeWorksheetCells("CH1", "CN1");
                document.MergeWorksheetCells("CO1", "CU1");
                document.MergeWorksheetCells("CV1", "DB1");
                document.MergeWorksheetCells("DC1", "DI1");
                document.MergeWorksheetCells("DJ1", "DP1");

                /* Print the numbered weeks from January to the end of April */
                document.SetCellValue("B1", week + f++);
                document.SetCellValue("I1", week + f++);
                document.SetCellValue("P1", week + f++);
                document.SetCellValue("W1", week + f++);
                document.SetCellValue("AD1", week + f++);
                document.SetCellValue("AK1", week + f++);
                document.SetCellValue("AR1", week + f++);
                document.SetCellValue("AY1", week + f++);
                document.SetCellValue("BF1", week + f++);
                document.SetCellValue("BM1", week + f++);
                document.SetCellValue("BT1", week + f++);
                document.SetCellValue("CA1", week + f++);
                document.SetCellValue("CH1", week + f++);
                document.SetCellValue("CO1", week + f++);
                document.SetCellValue("CV1", week + f++);
                document.SetCellValue("DC1", week + f++);
                document.SetCellValue("DJ1", week + f++);

                /* Print days from May to the end of July */
                document.MergeWorksheetCells("DQ1", "DW1");
                document.MergeWorksheetCells("DX1", "ED1");
                document.MergeWorksheetCells("EE1", "EK1");
                document.MergeWorksheetCells("EL1", "ER1");
                document.MergeWorksheetCells("ES1", "EY1");
                document.MergeWorksheetCells("EZ1", "FF1");
                document.MergeWorksheetCells("FG1", "FM1");
                document.MergeWorksheetCells("FN1", "FT1");
                document.MergeWorksheetCells("FU1", "GA1");
                document.MergeWorksheetCells("GB1", "GH1");
                document.MergeWorksheetCells("GI1", "GO1");
                document.MergeWorksheetCells("GP1", "GV1");
                document.MergeWorksheetCells("GW1", "HC1");
                document.MergeWorksheetCells("HD1", "HJ1");

                /* Print the numbered weeks from May to the end of July */
                document.SetCellValue("DQ1", week + f++);
                document.SetCellValue("DX1", week + f++);
                document.SetCellValue("EE1", week + f++);
                document.SetCellValue("EL1", week + f++);
                document.SetCellValue("ES1", week + f++);
                document.SetCellValue("EZ1", week + f++);
                document.SetCellValue("FG1", week + f++);
                document.SetCellValue("FN1", week + f++);
                document.SetCellValue("FU1", week + f++);
                document.SetCellValue("GB1", week + f++);
                document.SetCellValue("GI1", week + f++);
                document.SetCellValue("GP1", week + f++);
                document.SetCellValue("GW1", week + f++);
                document.SetCellValue("HD1", week + f++);

                /* Print days from August to the end of November */
                document.MergeWorksheetCells("HK1", "HQ1");
                document.MergeWorksheetCells("HR1", "HX1");
                document.MergeWorksheetCells("HY1", "IE1");
                document.MergeWorksheetCells("IF1", "IL1");
                document.MergeWorksheetCells("IM1", "IS1");
                document.MergeWorksheetCells("IT1", "IZ1");
                document.MergeWorksheetCells("JA1", "JG1");
                document.MergeWorksheetCells("JH1", "JN1");
                document.MergeWorksheetCells("JO1", "JU1");
                document.MergeWorksheetCells("JV1", "KB1");
                document.MergeWorksheetCells("KC1", "KI1");
                document.MergeWorksheetCells("KJ1", "KP1");
                document.MergeWorksheetCells("KQ1", "KW1");
                document.MergeWorksheetCells("KX1", "LD1");
                document.MergeWorksheetCells("LE1", "LK1");
                document.MergeWorksheetCells("LL1", "LR1");
                document.MergeWorksheetCells("LS1", "LY1");

                /* Print the numbered weeks from August to the end of November */
                document.SetCellValue("HK1", week + f++);
                document.SetCellValue("HR1", week + f++);
                document.SetCellValue("HY1", week + f++);
                document.SetCellValue("IF1", week + f++);
                document.SetCellValue("IM1", week + f++);
                document.SetCellValue("IT1", week + f++);
                document.SetCellValue("JA1", week + f++);
                document.SetCellValue("JH1", week + f++);
                document.SetCellValue("JO1", week + f++);
                document.SetCellValue("JV1", week + f++);
                document.SetCellValue("KC1", week + f++);
                document.SetCellValue("KJ1", week + f++);
                document.SetCellValue("KQ1", week + f++);
                document.SetCellValue("KX1", week + f++);
                document.SetCellValue("LE1", week + f++);
                document.SetCellValue("LL1", week + f++);
                document.SetCellValue("LS1", week + f++);

                /* Print days of December */
                document.MergeWorksheetCells("LZ1", "MF1");
                document.MergeWorksheetCells("MG1", "MM1");
                document.MergeWorksheetCells("MN1", "MT1");
                document.MergeWorksheetCells("MU1", "NB1");

                /* Print the numbered weeks of December */
                document.SetCellValue("LZ1", week + f++);
                document.SetCellValue("MG1", week + f++);
                document.SetCellValue("MN1", week + f++);
                document.SetCellValue("MU1", week + f++);


                DateTime myDT = new DateTime(localDateToday.Year - 1, 12, 30, new GregorianCalendar()); // for show the complete current year   
                // IDK why if I want to show the first of january on cell B2 I must set calendar two day before ???

                document.SetCellStyle(2, i, date_style);
                document.SetCellStyle(1, i, week_style);
                document.SetCellValue("A2", " ");
                myDT = myCal.AddDays(myDT, i);               

                var PrintDays = document.SetCellValue(2, i, myDT.Day + "/" + myDT.Month + "/" + myDT.Year);
            }

            localDateToday = myCal.AddDays(localDateToday, +1).Date;
        }

        public void ColorCells(SLDocument document)
        {
            float value = 0;

            DateTime today_from = new DateTime();
            today_from = DateTime.Today;
            document.SetCellValue("C3", today_from.ToString());

            float.TryParse(oreMacchina.Text, out value); // parso la stringa in un float, lo faccio per poter fare i calcoli 



            var ciao = new List<string>();

            SLWorksheetStatistics stats = document.GetWorksheetStatistics();
            int endColumnIndex = stats.EndColumnIndex;

            var fileName = "C:/Users/Utente/Desktop/C#FormApp/Windows_form_app/windows_form_app/TEST_CALENDAR_EXCEL_WEEK_PROVA_COLORE_2.xlsx";
            var sl = new SLDocument(fileName);
          
            foreach (var sheetName in sl.GetWorksheetNames())
            {
                SLDocument sheet = new SLDocument(fileName, sheetName);
                sheet.SetCellValue("A1", "foo");
                sheet.SetCellValue("D1", "bar");
               

                for (int z = 1; z <= endColumnIndex; z++)
                {
                    ciao.Add(sheet.GetCellValueAsString(2, z));
                }

                /*
                foreach (var column in ciao)
                {
                    MessageBox.Show(column);
                }   
                */

            }













            // adesso faccio i calcoli per prima fase
            float result_1 = (value * storage_value_data_1) / 100; // risultato per le ore relative alla prima lavorazione            
            TimeSpan timespan_1 = TimeSpan.FromHours(result_1); // con il timespan converto i decimali in ore 
            string output_hours_1 = timespan_1.ToString("hh\\:mm\\:ss"); // così visualizzo le ore, i minuti ed i secondi previsti per ogni fase
            Result1Fase.Text = Result1Fase.Text + output_hours_1; // stampo nello spazio giusto i valori

            
            
            
            
            
            // method which don't respect the DRY guide line



            SLConditionalFormatting cf; // I need this for color
            int i, j;

            for (i = today_from.Day; i < 5; ++i) // control and set the value of the cell
            { 
            cf = new SLConditionalFormatting("B4", "H4"); // control the color of the cells                 
                
            for (j = 1; j < 7; ++j) // control and set the value of the cell
            {
                if (result_1 > 16)
                {
                    cf = new SLConditionalFormatting("B4", "H4");  // control the color of the cells                        
                }
                document.SetCellValue(i, j, result_1);                   

                // set a custom color for 
                cf.SetCustom3ColorScale(SLConditionalFormatMinMaxValues.Value, "0", SLThemeColorIndexValues.Accent1Color, 0.2,
                    SLConditionalFormatRangeValues.Percentile, "35", SLThemeColorIndexValues.Accent3Color, -0.1,
                    SLConditionalFormatMinMaxValues.Value, "0", SLThemeColorIndexValues.Accent6Color, 0.5);
                document.AddConditionalFormatting(cf);

            }
        }
           
            //cf = new SLConditionalFormatting("A4", "D9"); // control the color of the cells 

    }


        public void GenerateExcel()
        {
            
            SLDocument sl_2 = new SLDocument();
            
            CreateCalendar(sl_2);
            ColorCells(sl_2);
        
            /* FINISCI FOGLIO EXCEL VISUALIZZAZIONE DATA */
            sl_2.SaveAs("C:/Users/Utente/Desktop/C#FormApp/Windows_form_app/windows_form_app/TEST_CALENDAR_EXCEL_WEEK_PROVA_COLORE_2.xlsx"); // savin my excel file

            MessageBox.Show("File Created");
            
        }

        private void CreateExcel_Click(object sender, EventArgs e)
        {
            GenerateExcel();
           // color(); // funzione che colora le celle secondo una scala di colori
        }
        
        private void LocalDateHours_Click(object sender, EventArgs e)
        {
            /// fa funzionare il display dell'ora  
        }

        private void Today_Click(object sender, EventArgs e)
        {
            // fa funzionare il display del giorno corrente 
        }

        private void TikTakClock_Tick(object sender, EventArgs e)
        {
            LocalDateHours.Text = DateTime.Now.ToLongTimeString();
            TikTakClock.Start();
        }        
        
        
        /*

        public void color()
        {

            SLDocument sl = new SLDocument();

            Random rand = new Random();
            int i, j;
            for (i = 5; i <= 2; i++)
            {
                for (j = 1; j <= 2; j++)
                {
                    sl.SetCellValue(i, j, 200 * rand.NextDouble());
                }
            }

            SLConditionalFormatting cf;

            cf = new SLConditionalFormatting("B2", "H5");
            cf.SetColorScale(SLConditionalFormatColorScaleValues.RedYellowGreen);
            sl.AddConditionalFormatting(cf);

            cf = new SLConditionalFormatting("D7", "G12");
            // the minimum color is GreenYellow for values at 20% or below
            // (so it's <= 40 because our cell values range from 0 to 200)
            // the maximum color is OrangeRed for values at 80% or above
            // (so it's >= 160 because our cell values range from 0 to 200)
            cf.SetCustom2ColorScale(SLConditionalFormatMinMaxValues.Percent, "20", System.Drawing.Color.GreenYellow,
                SLConditionalFormatMinMaxValues.Percent, "80", System.Drawing.Color.OrangeRed);
            sl.AddConditionalFormatting(cf);

            cf = new SLConditionalFormatting("C15", "J18");
            // the minimum is colored with accent 1 color that's lightened 20%
            // the midpoint is at the 35th percentile, colored with accent 3 color that's darkened 10%
            // the maximum is colored with accent 6 color that's lightened 50%
            cf.SetCustom3ColorScale(SLConditionalFormatMinMaxValues.Value, "0", SLThemeColorIndexValues.Accent1Color, 0.2,
                SLConditionalFormatRangeValues.Percentile, "35", SLThemeColorIndexValues.Accent3Color, -0.1,
                SLConditionalFormatMinMaxValues.Value, "0", SLThemeColorIndexValues.Accent6Color, 0.5);
            sl.AddConditionalFormatting(cf);

            sl.SaveAs("C:/Users/Utente/Desktop/C#FormApp/Windows_form_app/windows_form_app/ConditionalFormatColorScale.xlsx");

            Console.WriteLine("End of program");
            Console.ReadLine();
            */



    }
}

