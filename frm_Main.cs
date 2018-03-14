using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Security.Principal;

namespace AON_Ticket_Tracker
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private string myConStr;
        private string ntLogin;
        private string nowMonth;
        private string nowYear;
        private int ticktimeHours;
        private int ticktimeMinutes;
        private int ticktimeSeconds;
        private int ticktimeRaw;
        private bool isExpand;
        private bool isTiming;
        private bool duplicate;
       

        private DateTime strTme, endTme;
        private void frm_Main_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1136, 830);
            this.MaximumSize = new Size(1136, 1040);
            
            //Initialize connection string
            iniConnStr();
            //Show the Date & Time
            StartTimer();
            //lb_date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            //tx_date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            //tx_bic.Text 

            //Retrieve Sub Categories by Profile and Main Category
            //retAccountStatus();
            //Check if user is authorized
            chkUsrProf();
            //Get Full Name of user
            retName();
            //Get Month's BIC
            chkmBIC();
            //Get Today's BIC
            chkdBIC();
            //Initialize value of form size
            isExpand = false;
            isTiming = false;
            duplicate = false;

            //Retrieve Ticket Status by Profile
            //retTicketStatus();

            //Show records for the day
            shwRecAll();

            //Date and Time Validation

            //mtb_dtr.KeyDown += new KeyEventHandler(mtb_dtr_KeyDown);            
            tt_dtr.IsBalloon = true;

        }
        //confirm if user exists on DB
        private void chkUsrProf()
        {
            int usrExist;
            string tierLevel;
            string saveIdn = WindowsIdentity.GetCurrent().Name.ToString();
            int s = saveIdn.IndexOf("\\");
            ntLogin = saveIdn.Substring(s + 1);
            MySqlConnection myConn = new MySqlConnection(myConStr);
            StringBuilder strCmd = new StringBuilder();
            strCmd.Append("SELECT COUNT(*), profile FROM accounts WHERE n_id = '" + ntLogin + "';");
            MySqlCommand exeCmd = new MySqlCommand(strCmd.ToString(), myConn);
            myConn.Open();
            MySqlDataReader readCmd = exeCmd.ExecuteReader();
            while (readCmd.Read())
            {
                usrExist = Int32.Parse(readCmd.GetString(0));
                tierLevel = readCmd.GetString(1);
                if (usrExist == 0 || tierLevel == "Tier 1")
                {
                    MessageBox.Show("You are unauthorized to use this software.\n\rPlease Contact your Manager about this matter.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            myConn.Close();
        }
        private void retName()
        {
            string usrRole;
            MySqlConnection myConn = new MySqlConnection(myConStr);
            StringBuilder strCmd = new StringBuilder();
            strCmd.Append("SELECT fullname, role FROM accounts WHERE n_id = '" + ntLogin + "';");
            MySqlCommand exeCmd = new MySqlCommand(strCmd.ToString(), myConn);
            myConn.Open();
            MySqlDataReader readCmd = exeCmd.ExecuteReader();
            while (readCmd.Read())
            {
                lbl_Nme.Text = readCmd.GetString(0);
                usrRole = readCmd.GetString(1);
                if (usrRole == "Lead")
                {
                    //actToolStripMenuItem.Visible = true;
                    actToolStripMenuItem.Enabled = true;


                }
                else
                    actToolStripMenuItem.Enabled = false;
            }
            myConn.Close();

        }
        

        private void chkmBIC()
        {
            string saveIdn = WindowsIdentity.GetCurrent().Name.ToString();
            int s = saveIdn.IndexOf("\\");
            ntLogin = saveIdn.Substring(s + 1);
            nowMonth = DateTime.UtcNow.ToString("MMMM");
            nowYear = DateTime.UtcNow.ToString("yyyy");
            MySqlConnection myConn = new MySqlConnection(myConStr);
            StringBuilder strCmd = new StringBuilder();
            strCmd.Append("SELECT COUNT(*) FROM task_motion WHERE month_created = '" + nowMonth + "' AND year_created = '" + nowYear + "' AND a_n_id = '" + ntLogin + "'");
            MySqlCommand exeCmd = new MySqlCommand(strCmd.ToString(), myConn);
            myConn.Open();
            MySqlDataReader readCmd = exeCmd.ExecuteReader();
            while (readCmd.Read())
            {
                tx_mbic.Text = readCmd.GetString(0);
            }
            myConn.Close();
        }

        private void chkdBIC()
        {
            string saveIdn = WindowsIdentity.GetCurrent().Name.ToString();
            int s = saveIdn.IndexOf("\\");
            ntLogin = saveIdn.Substring(s + 1);
            nowMonth = DateTime.UtcNow.ToString("MMMM");
            nowYear = DateTime.UtcNow.ToString("yyyy");
            MySqlConnection myConn = new MySqlConnection(myConStr);
            StringBuilder strCmd = new StringBuilder();
            strCmd.Append("SELECT COUNT(*) FROM task_motion WHERE utc_created = UTC_Date() AND year_created = '" + nowYear + "' AND a_n_id = '" + ntLogin + "'");
            MySqlCommand exeCmd = new MySqlCommand(strCmd.ToString(), myConn);
            myConn.Open();
            MySqlDataReader readCmd = exeCmd.ExecuteReader();
            while (readCmd.Read())
            {
                tx_dbic.Text = readCmd.GetString(0);
            }
            myConn.Close();
        }

        private void aaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_About op_frm = new frm_About();
            op_frm.ShowDialog();
        }
        private void iniConnStr()
        {
            Connection op_con = new Connection();
            myConStr = op_con.connectString;
        }

        public static class Utility
        {

            public static string EscapeApostrophes(String input)
            {
                return input.Replace("'", "''");
            }
        }

        private void insTicDur()
        {
            string tx_ticketB = Utility.EscapeApostrophes(tx_ticket.Text);
            string tx_justificationB = Utility.EscapeApostrophes(tx_justification.Text);
            string tx_usernameB = Utility.EscapeApostrophes(tx_username.Text);
            string tx_serviceB = Utility.EscapeApostrophes(tx_service.Text);
            string tx_rignameB = Utility.EscapeApostrophes(tx_rigname.Text);
            string tx_ctitleB = Utility.EscapeApostrophes(tx_ctitle.Text);
            string tx_descB = Utility.EscapeApostrophes(tx_desc.Text);
            string tx_handlerlogB = Utility.EscapeApostrophes(tx_handlerlog.Text);
            string tx_wgB = Utility.EscapeApostrophes(tx_wg.Text);
            string tx_respersonB = Utility.EscapeApostrophes(tx_resperson.Text);
            string tx_cwgB = Utility.EscapeApostrophes(tx_cwg.Text); 
            string tx_nactionB = Utility.EscapeApostrophes(tx_naction.Text);
            this.nowMonth = DateTime.UtcNow.ToString("MMMM");
            this.nowYear = DateTime.UtcNow.ToString("yyyy");
            MySqlConnection connection = new MySqlConnection(this.myConStr);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("INSERT INTO task_motion2 (a_n_id, ticket_num, escalation_type, status, validity, validity_justification, entry_date, feedback_type, case_type, username, service, country,readname, region, case_createddate, title, task_desk, feedback, handlers_log, category, workgroup, last_followup, hp_delivery, responsible_person, closure_date,current_workgroup, next_action, end_time, duration, date_created, dtr_tracked, month_created, year_created, utc_created, start_time ) VALUES('" + this.ntLogin + "', '" + tx_ticketB + "', '" + this.cb_escaltype.Text + "','" + this.cb_cstatus.Text + "', '" + this.cb_validity.Text + "', '" + tx_justificationB + "',  '" + this.dateTime1B.Value.ToString() + "', '" + this.cb_fbtype.Text + "', '" + this.cb_casetype.Text + "', '" + tx_usernameB + "', '" + tx_serviceB + "', '" + this.cb_country.Text + "', '" + tx_rignameB + "', '" + this.cb_cregion.Text + "', '" + this.dateTime2B.Value.ToString() + "', '" + tx_ctitleB + "', '" + tx_descB + "', '" + this.cb_handler.Text + "', '" + tx_handlerlogB + "', '" + this.cb_ccategory.Text + "', '" + tx_wgB + "', '" + this.dateTime3B.Value.ToString() + "', '" + this.cb_delivtowers.Text + "', '" + tx_respersonB + "', '" + this.dateTime4B.Value.ToString() + "', '" + tx_cwgB + "', '" + tx_nactionB + "', '" + (object)this.endTme + "', '" + this.lbl_time.Text + "', DATE_FORMAT(NOW(),'%Y-%m-%d'), NOW(), '" + this.nowMonth + "', '" + this.nowYear + "', UTC_Date(), '" + (object)this.strTme + "'  )");
            MySqlCommand mySqlCommand = new MySqlCommand(stringBuilder.ToString(), connection);
            connection.Open();
            mySqlCommand.ExecuteNonQuery();
            connection.Close();
        }

       
        private void expandFrm()
        {
            if (isExpand == true)
            {
                this.Height = 830;
                isExpand = false;
                but_expnd.Text = "Hide Records";
            }
            else
            {
                this.Height = 1040;
                isExpand = true;
                but_expnd.Text = "Show Records";
            }
        }
        private void tmr_Dur_Tick(object sender, EventArgs e)
        {
            ticktimeRaw += 1;
            ticktimeSeconds += 1;

            if (ticktimeSeconds >= 60)
            {
                ticktimeMinutes += 1;
                ticktimeSeconds = 0;
            }
            if (ticktimeMinutes >= 60)
            {
                ticktimeHours += 1;
                ticktimeMinutes = 0;
            }
            lbl_time.Text = ticktimeHours + " Hours : " + ticktimeMinutes + " Minutes : " + ticktimeSeconds + " Seconds";
            //lbl_time.Text = DateTime.Now.ToString();
        }

        System.Windows.Forms.Timer tmr = null;
        private void StartTimer()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            tx_date.Text = DateTime.Now.ToString(format: "dd/MM/yyyy HH:mm");
        }

        private void but_expnd_Click(object sender, EventArgs e)
        {
            expandFrm();
        }

        

        class ComboBoxItem
        {
            public string name;
            public int id;

            public ComboBoxItem(string Name, int Id)
            {
                this.name = Name;
                this.id = Id;
            }
            public override string ToString()
            {
                return this.name;
            }
        }

        private void shwRecAll()
        {
            shwRecGCCMS();
            shwRecICCMS();

        }
        private void shwRecGCCMS()
        {
            MySqlConnection myConn = new MySqlConnection(myConStr);
            StringBuilder strCmd = new StringBuilder();
            strCmd.Append("SELECT ticket_num AS 'Ticket #', status AS 'STATUS', entry_date as 'ENTRY DATE', feedback_type AS 'FEEDBACK TYPE', case_type AS 'CASE TYPE', service as 'SERVICE', country as 'COUNTRY', readname as 'RIGNAME', region as 'REGION', title as 'TITLE', task_desk AS 'DESCRIPTION', category AS 'CATEGORY', last_followup AS 'LAST FOLLOWUP', hp_delivery AS 'HP-DELIVERY', responsible_person AS 'RESPONSIBLE PERSON', closure_date AS 'CLOSURE DATE' FROM task_motion2 WHERE escalation_type = 'Global CCMS' AND utc_created = '" + DateTime.UtcNow.ToString("yyyy-MM-dd") + "';");

            System.Data.DataTable dtAnalystProg = new System.Data.DataTable();
            MySqlDataAdapter mysqlAnalystProgAdapter = new MySqlDataAdapter(strCmd.ToString(), myConn);
            MySqlCommandBuilder mysqlBuildAnalystProg = new MySqlCommandBuilder(mysqlAnalystProgAdapter);
            mysqlAnalystProgAdapter.Fill(dtAnalystProg);
            BindingSource bindSourceAnalystProg = new BindingSource();
            bindSourceAnalystProg.DataSource = dtAnalystProg;
            dgv_bpos_logs.DataSource = bindSourceAnalystProg;
            dgv_bpos_logs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

      

        private void shwRecICCMS()
        {
            MySqlConnection myConn = new MySqlConnection(myConStr);
            StringBuilder strCmd = new StringBuilder();
            strCmd.Append("SELECT ticket_num AS 'Ticket #', status AS 'STATUS', entry_date as 'ENTRY DATE', feedback_type AS 'FEEDBACK TYPE', case_type AS 'CASE TYPE', service as 'SERVICE', country as 'COUNTRY', readname as 'RIGNAME', region as 'REGION', title as 'TITLE', task_desk AS 'DESCRIPTION', category AS 'CATEGORY', last_followup AS 'LAST FOLLOWUP', hp_delivery AS 'HP-DELIVERY', responsible_person AS 'RESPONSIBLE PERSON', closure_date AS 'CLOSURE DATE' FROM task_motion2 WHERE escalation_type = 'Internal CCMS' AND utc_created = '" + DateTime.UtcNow.ToString("yyyy-MM-dd") + "';");
            System.Data.DataTable dtAnalystProg = new System.Data.DataTable();
            MySqlDataAdapter mysqlAnalystProgAdapter = new MySqlDataAdapter(strCmd.ToString(), myConn);
            MySqlCommandBuilder mysqlBuildAnalystProg = new MySqlCommandBuilder(mysqlAnalystProgAdapter);
            mysqlAnalystProgAdapter.Fill(dtAnalystProg);
            BindingSource bindSourceAnalystProg = new BindingSource();
            bindSourceAnalystProg.DataSource = dtAnalystProg;
            dgv_RM_logs.DataSource = bindSourceAnalystProg;
            dgv_RM_logs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        
        private void extractRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Xtrct op_frm = new frm_Xtrct();
            this.Hide();
            op_frm.ShowDialog();
            this.Show();
        }

        private void mtb_dtr_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            /*    if (!e.IsValidInput)
                {
                    tt_dtr.ToolTipTitle = "Invalid Date";
                    tt_dtr.Show("Manila Date & Time. Format: dd/MM/yyyy HH:mm.", mtb_dtr, 0, -20, 2000);
                }
                else
                {
                    //Now that the type has passed basic type validation, enforce more specific type rules.
                    DateTime userDate = (DateTime)e.ReturnValue;
                    if (userDate > DateTime.Now)
                    {
                        tt_dtr.ToolTipTitle = "Invalid Date";
                        tt_dtr.Show("Manila Date & Time. Format: dd/MM/yyyy HH:mm.", mtb_dtr, 0, -20, 2000);
                        e.Cancel = true;
                    }
                    else
                    {
             */
            //tx_ticket.Select();
            //tx_ticket.ReadOnly = false;
            //cb_status.Enabled = false;
            /*      }
              }
              */
        }

        // Hide the tooltip if the user starts typing again before the five-second display limit on the tooltip expires. 
        /*
        private void mtb_dtr_KeyDown(object sender, KeyEventArgs e)
        {
            tt_dtr.Hide(mtb_dtr);
        }
         */

        private void cb_sub_categ_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void mtb_dtr_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void tx_date_TextChanged(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void tx_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (tx_date.ContainsFocus && e.Control && e.KeyCode == Keys.C)
                Clipboard.SetText(tx_date.Text);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dbic_Click(object sender, EventArgs e)
        {

        }

        private void tx_dbic_TextChanged(object sender, EventArgs e)
        {

        }

       

       


        private void tx_dup_TextChanged(object sender, EventArgs e)
        {
            //string dup;
           // int dup;

           // dup = int.Parse(textBox1.Text);
          
            //Clipboard.SetText(tx_date.Text);
          // dup= tx_dup.Text = Clipboard.GetText();
         //   for (int i = dup; i < 5; i++)
           // {
            //    Console.WriteLine(i);
                
           // }
          

            //for (int i = 1; i <= 5; i++)
            //{
               // Console.WriteLine(i);
            //}
        }

        private void duplicate1_Click(object sender, EventArgs e)
        {

        }

        private void dupli_Click(object sender, EventArgs e)
        {

        }

        
        private void tx_dup_TextChanged_1(object sender, EventArgs e)
        {
            //Clipboard.SetText(tx_dup.Text);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           // tx_des.ReadOnly = false;

        }

        private void datetime_ValueChanged(object sender, EventArgs e)
        {
            //this.Focus();
            //tx_des.ReadOnly = false;

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


      
        private void cb_fbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tx_ticket_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_escaltype_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_cstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_validity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx_justification_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTime1A_ValueChanged(object sender, EventArgs e)
        {
        }

        private void tx_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_capt_Click(object sender, EventArgs e)
        {
            if (tx_ticket.Text == "" || cb_escaltype.Text == "" || cb_cstatus.Text == "" || cb_validity.Text == "" || tx_justification.Text == "" ||
               dateTime1B.Value.ToString() == "" || cb_fbtype.Text == "" || cb_casetype.Text == "" || tx_username.Text == "" || tx_service.Text == "" || cb_country.Text == "" ||
                tx_rigname.Text == "" || cb_cregion.Text == "" || dateTime2B.Value.ToString() == "" || tx_ctitle.Text == "" || tx_desc.Text == "" ||
                cb_handler.Text == "" || tx_handlerlog.Text == "" || cb_ccategory.Text == "" || tx_wg.Text == "" || dateTime3B.Value.ToString() == "" ||
                cb_delivtowers.Text == "" || tx_resperson.Text == "" || dateTime4B.Value.ToString() == "" || tx_cwg.Text == "" || tx_naction.Text == "")
            {

                MessageBox.Show("Please fill out all details!", "Missing Data",
                        MessageBoxButtons.OK);

            }
            else
            {
                
                insTicDur();
                tx_ticket.Clear();
                cb_escaltype.Text = "";
                cb_cstatus.Text = "";
                cb_validity.Text = "";
                tx_justification.Clear();
                cb_fbtype.Text = "";
                cb_casetype.Text = "";
                tx_username.Clear();
                tx_service.Clear();
                cb_country.Text = "";
                tx_rigname.Clear();
                cb_cregion.Text = "";
                tx_ctitle.Clear();
                tx_desc.Clear();
                cb_handler.Text = "";
                tx_handlerlog.Clear();
                cb_ccategory.Text = "";
                tx_wg.Clear();
                cb_delivtowers.Text = "";
                tx_resperson.Clear();
                tx_cwg.Clear();
                tx_naction.Clear();
                shwRecAll();

                MessageBox.Show("Save Complete!", "Confirmation",
                        MessageBoxButtons.OK);
            }
        }

        private void cb_cregion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx_rigname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_country_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            tx_ticket.Clear();
            cb_escaltype.Text = "";
            cb_cstatus.Text = "";
            cb_validity.Text = "";
            tx_justification.Clear();
            cb_fbtype.Text = "";
            cb_casetype.Text = "";
            tx_username.Clear();
            tx_service.Clear();
            cb_country.Text = "";
            tx_rigname.Clear();
            cb_cregion.Text = "";
            tx_ctitle.Clear();
            tx_desc.Clear();
            cb_handler.Text = "";
            tx_handlerlog.Clear();
            cb_ccategory.Text = "";
            tx_wg.Clear();
            cb_delivtowers.Text = "";
            tx_resperson.Clear();
            tx_cwg.Clear();
            tx_naction.Clear();
        }

        private void tx_service_TextChanged(object sender, EventArgs e)
        {

        }

    
        
        }


        }
      
        
    
