using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
