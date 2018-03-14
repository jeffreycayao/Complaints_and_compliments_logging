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
    public partial class frm_About : Form
    {
        public frm_About()
        {
            InitializeComponent();
        }

        private void frm_About_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(311, 288);
            this.MinimumSize = new Size(311, 288);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
