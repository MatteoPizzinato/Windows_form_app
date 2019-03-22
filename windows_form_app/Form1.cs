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

namespace windows_form_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CountTables();
            BlockInsertHours();
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
        public void GenerateExcel()
        {
            SLDocument sl = new SLDocument();

            // set a boolean at "A1"
            sl.SetCellValue("A1", true);

           
            // set the value of PI
            sl.SetCellValue("B3", 3.14159);

            // set the value of PI at row 4, column 2 (or "B4") in string form.
            // use this when you already have numeric data in string form and don't
            // want to parse it to a double or float variable type
            // and then set it as a value.
            // Note that "3,14159" is invalid. Excel (or Open XML) stores numerals in
            // invariant culture mode. Frankly, even "1,234,567.89" is invalid because
            // of the comma. If you can assign it in code, then it's fine, like so:
            // double fTemp = 1234567.89;
            sl.SetCellValueNumeric(4, 2, "3.14159");

            // normal string data
            sl.SetCellValue("C6", "This is at C6!");

            // typical XML-invalid characters are taken care of,
            // in particular the & and < and >
            sl.SetCellValue("I6", "Dinner & Dance costs < $10");

            // this sets a cell formula
            // Note that if you want to set a string that starts with the equal sign,
            // but is not a formula, prepend a single quote.
            // For example, "'==" will display 2 equal signs
            sl.SetCellValue(7, 3, "=SUM(A2:T2)");

            // if you need cell references and cell ranges *really* badly, consider the SLConvert class.
            sl.SetCellValue(SLConvert.ToCellReference(7, 4), string.Format("=SUM({0})", SLConvert.ToCellRange(2, 1, 2, 20)));

            // dates need the format code to be displayed as the typical date.
            // Otherwise it just looks like a floating point number.
            sl.SetCellValue("C8", new DateTime(3141, 5, 9));
            SLStyle style = sl.CreateStyle();
            style.FormatCode = "d-mmm-yyyy";
            sl.SetCellStyle("C8", style);

            sl.SetCellValue(8, 6, "I predict this to be a significant date. Why, I do not know...");

            sl.SetCellValue(9, 4, 456.123789);
            // we don't have to create a new SLStyle because
            // we only used the FormatCode property
            style.FormatCode = "0.000%";
            sl.SetCellStyle(9, 4, style);

            sl.SetCellValue(9, 6, "Perhaps a phenomenal growth in something?");

            sl.SetColumnWidth("A8", 20); // setta la larghezza di una colonna


             /* TRY TO PRINT THE SEQUENCE OF THE WEEKS */
            SLDocument sl_2 = new SLDocument();
            SLStyle date_style = sl_2.CreateStyle();

            SLStyle week_style = sl_2.CreateStyle();

            string week = "W ";
            sl_2.SetCellValue("B1", week);

            



            date_style.Alignment.Horizontal = DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center;
            // Alternatively, use the shortcut function:
            // style.SetHorizontalAlignment(HorizontalAlignmentValues.Left);

            // each indent is 3 spaces, so this is 15 spaces total
            date_style.Alignment.Indent = 5;
            date_style.Alignment.JustifyLastLine = true;
            date_style.Alignment.ReadingOrder = SLAlignmentReadingOrderValues.RightToLeft;
            date_style.Alignment.ShrinkToFit = true;
            date_style.Alignment.TextRotation = 90;
            date_style.Font.FontColor = System.Drawing.Color.Black;
            date_style.Font.FontName = "Gill-Sans";
            date_style.Font.FontSize = 12;
            date_style.Font.Bold = true;

            week_style.Alignment.Indent = 5;
            week_style.Alignment.Horizontal = DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center;

            // sl_2.SetDefinedName("MySum", "sl_2!$B$1:$B$8");
            // sl.SetCellValue(8, 2, "=SUM(MySum)");

            // sl.SetDefinedName("MySum", "Sheet1!$B$2:$D$4");


            Calendar myCal = CultureInfo.InvariantCulture.Calendar;
            DateTime localDateToday = DateTime.Today;

            for (int i = 1; i <= 365; i++) // print the sequence of the weeks of a year
            {
                
                sl_2.MergeWorksheetCells("B1", "H1");
                sl_2.MergeWorksheetCells("I1", "O1");
                sl_2.MergeWorksheetCells("P1", "X1");
                sl_2.MergeWorksheetCells("Y1", "AF1");
                sl_2.MergeWorksheetCells("AG1", "AN1");
                sl_2.MergeWorksheetCells("AO1", "AV1");
                sl_2.MergeWorksheetCells("BC1", "BJ1");
                sl_2.MergeWorksheetCells("BQ1", "BX1");
                
                sl_2.SetCellValue("B5", week + i);
                sl_2.SetCellValue("I1", week + i);
                sl_2.SetCellValue("P1", week + i);
                sl_2.SetCellValue("Y1", week + i);
                sl_2.SetCellValue("AG1", week + i);
                sl_2.SetCellValue("AO1", week + i);
                sl_2.SetCellValue("BC1", week + i);
                sl_2.SetCellValue("BQ1", week + i);

                sl_2.SetCellStyle(2, i, date_style);
                localDateToday = myCal.AddDays(localDateToday, + 1).Date;
                sl_2.SetCellValue(2, i, localDateToday.Day + "/" + localDateToday.Month + "/" + localDateToday.Year);
            }               

            sl_2.SaveAs("C:/Users/Utente/Desktop/C#FormApp/Windows_form_app/windows_form_app/TEST_CALENDAR_EXCEL_WEEK.xlsx");
            

            //  sl.SaveAs("C:/Users/Utente/Desktop/C#FormApp/Windows_form_app/windows_form_app/TEST_CALENDAR_EXCEL_2.xlsx");

            MessageBox.Show("File Created");

        }

        private void CreateExcel_Click(object sender, EventArgs e)
        {
            GenerateExcel();
            // strobo(); funzione che colora le celle secondo una scala di colori
        }


        public static void DisplayValues(Calendar myCal, DateTime myDT)
        {
            Console.WriteLine("   Era:          {0}", myCal.GetEra(myDT));
            Console.WriteLine("   Year:         {0}", myCal.GetYear(myDT));
            Console.WriteLine("   Month:        {0}", myCal.GetMonth(myDT));
            Console.WriteLine("   DayOfYear:    {0}", myCal.GetDayOfYear(myDT));
            Console.WriteLine("   DayOfMonth:   {0}", myCal.GetDayOfMonth(myDT));
            Console.WriteLine("   DayOfWeek:    {0}", myCal.GetDayOfWeek(myDT));
            Console.WriteLine("   Hour:         {0}", myCal.GetHour(myDT));
            Console.WriteLine("   Minute:       {0}", myCal.GetMinute(myDT));
            Console.WriteLine("   Second:       {0}", myCal.GetSecond(myDT));
            Console.WriteLine("   Milliseconds: {0}", myCal.GetMilliseconds(myDT));
            Console.WriteLine();
        }


        /*
         * 
        This code produces the following output.

        April 3, 2002 of the Gregorian calendar:
           Era:          1
           Year:         2002
           Month:        4
           DayOfYear:    93
           DayOfMonth:   3
           DayOfWeek:    Wednesday
           Hour:         0
           Minute:       0
           Second:       0
           Milliseconds: 0

        After adding 5 to each component of the DateTime:
           Era:          1
           Year:         2007
           Month:        10
           DayOfYear:    286
           DayOfMonth:   13
           DayOfWeek:    Saturday
           Hour:         5
           Minute:       5
           Second:       5
           Milliseconds: 5

      

        public void Calendar()
        {
            // Sets a DateTime to April 3, 2002 of the Gregorian calendar.
            DateTime myDT = new DateTime(2002, 4, 3, new GregorianCalendar());

            // Uses the default calendar of the InvariantCulture.
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;

            // Displays the values of the DateTime.
            Console.WriteLine("April 3, 2002 of the Gregorian calendar:");
            DisplayValues(myCal, myDT);

            // Adds 5 to every component of the DateTime.
            myDT = myCal.AddYears(myDT, 5);
            myDT = myCal.AddMonths(myDT, 5);
            myDT = myCal.AddWeeks(myDT, 5);
            myDT = myCal.AddDays(myDT, 5);
            myDT = myCal.AddHours(myDT, 5);
            myDT = myCal.AddMinutes(myDT, 5);
            myDT = myCal.AddSeconds(myDT, 5);
            myDT = myCal.AddMilliseconds(myDT, 5);

            // Displays the values of the DateTime.
            Console.WriteLine("After adding 5 to each component of the DateTime:");
            DisplayValues(myCal, myDT);


            sl.SetCellValue(1, 1, myCal.AddWeeks(myDT, 5));
            // Sets a DateTime to April 3, 2002 of the Gregorian calendar.
            DateTime myDT = new DateTime(2002, 4, 3, new GregorianCalendar());

            // Uses the default calendar of the InvariantCulture.
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;

            // Displays the values of the DateTime.
            Console.WriteLine("April 3, 2002 of the Gregorian calendar:");
            DisplayValues(myCal, myDT);

            // Adds 5 to every component of the DateTime.
            myDT = myCal.AddYears(myDT, 5);
            myDT = myCal.AddMonths(myDT, 5);
            myDT = myCal.AddWeeks(myDT, 5);
            myDT = myCal.AddDays(myDT, 5);
            myDT = myCal.AddHours(myDT, 5);
            myDT = myCal.AddMinutes(myDT, 5);
            myDT = myCal.AddSeconds(myDT, 5);
            myDT = myCal.AddMilliseconds(myDT, 5);

            // Displays the values of the DateTime.
            Console.WriteLine("After adding 5 to each component of the DateTime:");
            DisplayValues(myCal, myDT);

            // set current date
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;

            for (int i = 1; i <= 24; i++)
            {
                for (int j = 1; j <= 24; j++)
                {
                    sl.SetCellValue(17, i, localDate.AddMonths(j)); /* GUARDA STRUTTURE IN C# e cerca di creare la successione di settimane
                }
            }


            // set at row 2, columns 1 through 20, a value that's equal to the column index
            for (int i = 1; i <= 20; i++)
            {
                sl.SetCellValue(2, i, i);
                sl.SetCellValue(16, i, myCal.GetMonth(myDT));
            }


        }

     

        public void strobo()
        {
            SLDocument sl = new SLDocument();

            Random rand = new Random();
            int i, j;
            for (i = 1; i <= 20; ++i)
            {
                for (j = 1; j <= 10; ++j)
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

            sl.SaveAs("ConditionalFormatColorScale.xlsx");

            Console.WriteLine("End of program");
            Console.ReadLine();


        }
         */





    }
}


/*
*
*
* DA FARE: METTERE TUTTO NEL DATABASE E CERCARE UN MODO PER GENERARE IL FILE EXCEL CHE SARà LA COSA PIù ARDUA
* 
* 
*/
