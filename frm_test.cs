using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AON_Ticket_Tracker
{
    public partial class frm_test : Form
    {
        public frm_test(string DataReceived, string title)
        {
            InitializeComponent();

            //next set the label's text to the DataReceived string from the first form (Form1):
            label1.Text = DataReceived;
            //Title of Display form:
            this.Text = title;
        }

        private void frm_test_Load(object sender, EventArgs e)
        {

        }

    }
}
