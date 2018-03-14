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
    public partial class frm_AdNw : Form
    {
        public frm_AdNw()
        {
            InitializeComponent();
        }
        public string tx, tx2, tx3;
        private void button1_Click(object sender, EventArgs e)
        {
            tx = tx_EM_New_RsdBy.Text;
            tx2 = tx_EM_New_CntctEml.Text;
            this.Close();
            //frm_test frm = new frm_test(textBox1.Text, "Values of New Form");
            //frm.Show();
            //this.Hide();
        }
    }
}
