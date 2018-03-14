using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;

namespace AON_Ticket_Tracker
{
    public partial class frm_Xtrct : Form
    {
        public frm_Xtrct()
        {
            InitializeComponent();
        }
        private string myConStr;
        //Variable used for search feature
        private string fil_Date, fil_eDate;
        private void frm_Xtrct_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(841, 497);
            //Initialize connection string
            iniConnStr();
            //Initialize value of profile
            //retAccountStatus();
            tx_myEval.Text = dtp_myFrmEval.Value.ToString("MMMM dd, yyyy");
            fil_Date = dtp_myFrmEval.Value.ToString("yyyy-MM-dd");
            tx_EndMyEval.Text = dtp_myEndEval.Value.ToString("MMMM dd, yyyy");
            fil_eDate = dtp_myEndEval.Value.ToString("yyyy-MM-dd");
            retFullname();
            //shwDataAll();
        }
        private void iniConnStr()
        {
            Connection op_con = new Connection();
            myConStr = op_con.connectString;
        }
        
        
        /*private void retAccountStatus()
        {
            cb_Prof.Items.Clear();
            MySqlConnection myConn = new MySqlConnection(myConStr);
            StringBuilder strCmd = new StringBuilder();
            strCmd.Append("SELECT DISTINCT account FROM task_desc_table;");
            MySqlCommand exeCmd = new MySqlCommand(strCmd.ToString(), myConn);
            myConn.Open();
            MySqlDataReader readCmd = exeCmd.ExecuteReader();
            cb_Prof.Items.Add("");
            while (readCmd.Read())
            {
                cb_Prof.Items.Add(readCmd.GetString(0));
            }
            myConn.Close();
        }*/
        /*private void retProfStatus()
        {
            MySqlConnection myConn = new MySqlConnection(myConStr);
            StringBuilder strCmd = new StringBuilder();
            strCmd.Append("SELECT DISTINCT profile FROM task_desc_table WHERE account = '" + cb_Prof.SelectedItem.ToString() + "';");
            MySqlCommand exeCmd = new MySqlCommand(strCmd.ToString(), myConn);
            myConn.Open();
            MySqlDataReader readCmd = exeCmd.ExecuteReader();
            cb_Categ.Items.Add("");
            while (readCmd.Read())
            {
                cb_Categ.Items.Add(readCmd.GetString(0));
            }
            myConn.Close();

        }

        private void retCategStatus()
        {
            cb_SubCateg.Items.Clear();
            MySqlConnection myConn = new MySqlConnection(myConStr);
            StringBuilder strCmd = new StringBuilder();
            strCmd.Append("SELECT DISTINCT task_desc_id, category FROM task_desc_table WHERE account = '" + cb_Prof.SelectedItem.ToString() + "' AND profile = '" + cb_Categ.SelectedItem.ToString() + "';");
            MySqlCommand exeCmd = new MySqlCommand(strCmd.ToString(), myConn);
            myConn.Open();
            MySqlDataReader readCmd = exeCmd.ExecuteReader();
            cb_SubCateg.Items.Add(new frm_Xtrct.ComboBoxItem("", -1));
            while (readCmd.Read())
            {
                cb_SubCateg.Items.Add(new frm_Xtrct.ComboBoxItem(readCmd.GetString(1), Int32.Parse(readCmd.GetString(0))));
            }
            myConn.Close();

        }*/
        private void retFullname()
        {

            names.Items.Clear();
            MySqlConnection myConn = new MySqlConnection(myConStr);
            StringBuilder strCmd = new StringBuilder();
            strCmd.Append("SELECT DISTINCT fullname FROM accounts;");
            MySqlCommand exeCmd = new MySqlCommand(strCmd.ToString(), myConn);
            myConn.Open();
            MySqlDataReader readCmd = exeCmd.ExecuteReader();
            names.Items.Add("");
            while (readCmd.Read())
            {
                names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
                names.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                names.AutoCompleteSource = AutoCompleteSource.ListItems;
                names.Items.Add(readCmd.GetString(0));
            }
            myConn.Close();
        }

        private void names_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            retFullname();

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

        /*private void shwDataAll()
            {
                shwBICView();
            }
        */
        private void cb_Prof_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dtp_myEval_ValueChanged(object sender, EventArgs e)
        {
            tx_myEval.Text = dtp_myFrmEval.Value.ToString("MMMM dd, yyyy");
            fil_Date = dtp_myFrmEval.Value.ToString("yyyy-MM-dd 00:00:00");
        }

       

        /* TESTING GROUND **************************

        private void shwBICView()
        {
            ArrayList arr = new ArrayList();
            MySqlConnection myConn = new MySqlConnection(myConStr);
            StringBuilder strCmd = new StringBuilder();
            MySqlCommand exeCmd = new MySqlCommand(strCmd.ToString(), myConn);
            MySqlCommand queryEmpID = myConn.CreateCommand();
            queryEmpID.CommandText = "SELECT a_n_id FROM task_motion WHERE month_created = 'January' ORDER BY a_n_id;";
            myConn.Open();
            MySqlDataReader readerQuery = queryEmpID.ExecuteReader();
            string values;
            while (readerQuery.Read())
            {
                values = readerQuery[0].ToString();
                arr.Add(values);
            }
            myConn.Close();

            for (int x = 0; x < arr.Count; x++)
                {
                    report1.CommandText = "SELECT fullname AS NAME, " +
                        "(SELECT COUNT(REQ_POOL.REQUEST_REQ_ID) FROM REQ_POOL LEFT JOIN EMP_TABLE ON REQ_POOL.employee_EMP_ID=EMP_TABLE.EMP_ID WHERE EMP_TABLE.EMP_ID = '" + 
                        arr[x].ToString() + "' AND REQ_POOL.REQ_STATUS = 'Completed' AND REQ_POOL.DATE_ASSIGNED " + dateSelection + 
                        
                       ") AS COMPLETE, EMP_Workstream_Team FROM EMP_TABLE WHERE EMP_ID = '" + arr[x].ToString() + "';";
                    myConn.Open();
                    MySqlDataReader reader = report1.ExecuteReader();
                    reader.Read();
                }

            col1 = reader[0].ToString(); //col1  
            col2 = reader[8].ToString(); //col2
            col3 = reader[6].ToString(); //col3 
            i++;
            myConn.Close();
            //... 
        }

        // TESTING GROUND ************************** */

        /* private void shwBICView()
        {
            MySqlConnection myConn = new MySqlConnection(myConStr);
            StringBuilder strCmd = new StringBuilder();
            strCmd.Append("SELECT a_n_id AS 'NT LOGIN', (SELECT COUNT(a_n_id) FROM task_motion WHERE ) AS BIC FROM task_motion;");
            System.Data.DataTable dtAnalystProg = new System.Data.DataTable();
            MySqlDataAdapter mysqlAnalystProgAdapter = new MySqlDataAdapter(strCmd.ToString(), myConn);
            MySqlCommandBuilder mysqlBuildAnalystProg = new MySqlCommandBuilder(mysqlAnalystProgAdapter);
            mysqlAnalystProgAdapter.Fill(dtAnalystProg);
            BindingSource bindSourceAnalystProg = new BindingSource();
            bindSourceAnalystProg.DataSource = dtAnalystProg;
            dg_bic_view.DataSource = bindSourceAnalystProg;
            dg_bic_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }*/
        private void but_filter_Click(object sender, EventArgs e)
        {
            disLogs(names.Text, cb_Prof.Text, cb_Categ.Text, cb_SubCateg.Text, fil_Date, fil_eDate);
        }

        private void disLogs(string fName, string fProf, string fCateg, string fSCateg, string fDate, string eDate)
        {
            this.MaximumSize = new Size(1444, 770);
            fName = fName.Replace(" ", "%");
            fProf = fProf.Replace(" ", "%");
            fCateg = fCateg.Replace(" ", "%");
            fSCateg = fSCateg.Replace(" ", "%");
            MySqlConnection myConn = new MySqlConnection(myConStr);
            StringBuilder strCmd = new StringBuilder();
            strCmd.Append("SELECT tic.ticket_num AS 'REFERENCE ID', ac.fullname AS 'ANALYST NAME', tic.escalation_type AS 'ESCALATION TYPE', tic.status AS 'STATUS', tic.validity AS 'VALIDITY', tic.validity_justification AS 'VALIDITY JUSTIFICATION', tic.entry_date AS 'ENTRY DATE', tic.feedback_type AS 'FEEDBACK TYPE', tic.case_type AS 'CASE TYPE', tic.username AS 'USERNAME', tic.service AS 'SERVICE', tic.country AS 'COUNTRY', tic.readname AS 'RIGNAME', tic.region AS 'REGION', tic.case_createddate AS 'CASE CREATED DATE', tic.title AS 'TITLE', tic.task_desk AS 'DESCRIPTION', tic.feedback AS 'FEEDBACK', tic.handlers_log AS 'HANDLERS LOG', tic.category AS 'CATEGORY', tic.workgroup AS 'WORKGROUP', tic.last_followup AS 'LAST FOLLOW-UP', tic.hp_delivery AS 'HP DELIVERY', tic.responsible_person AS 'RESPONSIBLE PERSON', tic.closure_date AS 'CLOSURE DATE', tic.current_workgroup AS 'CURRENT WORKGROUP', tic.next_action AS 'NEXT ACTION', tic.end_time AS 'END TIME', tic.dtr_tracked AS 'DATE AND TIME TRACKED', tic.utc_created AS 'SHIFT DATE TRACKED', tic.duration AS 'DURATION' FROM task_motion2 tic " +
                "LEFT JOIN accounts ac ON ac.n_id = tic.a_n_id " +
                "WHERE ac.fullname LIKE '%" + fName + "%' " +
                "AND tic.escalation_type LIKE '%" + fProf + "%' " +
                "AND tic.status LIKE '%" + fCateg + "%' " +
                "AND tic.case_type LIKE '%" + fSCateg + "%' " +
                "AND tic.utc_created BETWEEN '" + fDate + "' AND '" + eDate + "' ORDER BY tic.utc_created;");
            System.Data.DataTable dtAnalystProg = new System.Data.DataTable();
            MySqlDataAdapter mysqlAnalystProgAdapter = new MySqlDataAdapter(strCmd.ToString(), myConn);
            MySqlCommandBuilder mysqlBuildAnalystProg = new MySqlCommandBuilder(mysqlAnalystProgAdapter);
            mysqlAnalystProgAdapter.Fill(dtAnalystProg);
            BindingSource bindSourceAnalystProg = new BindingSource();
            bindSourceAnalystProg.DataSource = dtAnalystProg;
            dgv_Logs.DataSource = bindSourceAnalystProg;
            dgv_Logs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void delete()
        {
         

                            
                            MySqlConnection connection = new MySqlConnection(this.myConStr);
                            StringBuilder stringBuilder = new StringBuilder();
                            //string a = dgv_Logs.SelectedRows[0].Cells[0].Value.ToString();
                            stringBuilder.Append("DELETE FROM task_motion WHERE ticket_num = '" + reference.Text + "'");
                     
                            MySqlCommand mySqlCommand = new MySqlCommand(stringBuilder.ToString(), connection);
                            connection.Open();
                            mySqlCommand.ExecuteNonQuery();
                           
                        
                   
                    
       
                
                  
            }
       

        private void delete_record()
        {

         for (int i = 0; i < dgv_Logs.Rows.Count; i++)
                    {
 
                        DataGridViewRow dr = dgv_Logs.Rows[i];
                        if (dr.Selected == true)
                        {
                            dgv_Logs.Rows.RemoveAt(i);
                    MySqlConnection connection = new MySqlConnection(this.myConStr);
                    StringBuilder stringBuilder = new StringBuilder();
                   // string a = dgv_Logs.SelectedRows[0].Cells[0].Value.ToString();
                   // dgv_Logs.Rows.RemoveAt(dgv_Logs.CurrentRow.Index);
                    stringBuilder.Append("DELETE FROM task_motion WHERE task_id =" + i + "");
                    MySqlCommand mySqlCommand = new MySqlCommand(stringBuilder.ToString(), connection);
                    connection.Open();
                    mySqlCommand.ExecuteNonQuery();
                            // da.Update(ds, "task_motion");
                   // dgv_Logs.Rows.RemoveAt(dgv_Logs.SelectedRows[0].Index);
                    MessageBox.Show("deleted");
                }
         }
            

                  
                
            
        

}
        private void but_xtract_Click(object sender, EventArgs e)
        {
            if (dgv_Logs.Rows.Count > 0)
            {
                xtrToExcel();
            }
            else
            {
                MessageBox.Show("There are no records to be extracted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void xtrToExcel()
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            int i = 0;
            int j = 0;
            int yColumns = 0;
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = xlWorkBook.Sheets["sheet1"];
            // insert column names
            for (i = 0; (i
                        <= (dgv_Logs.Columns.Count - 1)); i++)
            {
                xlWorkSheet.Cells[1, (i + 1)].value = dgv_Logs.Columns[i].HeaderText.ToString();
                yColumns++;
            }
            // insert the actual data
            for (i = 1; (i <= dgv_Logs.RowCount); i++)
            {
                for (j = 0; (j
                            <= (dgv_Logs.ColumnCount - 1)); j++)
                {
                    xlWorkSheet.Cells[(i + 1), (j + 1)] = dgv_Logs[j, (i - 1)].Value.ToString();
                }
            }
            xlWorkSheet.Cells.Select();
            xlWorkSheet.Columns.AutoFit();
            xlWorkSheet.Rows.AutoFit();
            ((Microsoft.Office.Interop.Excel.Range)(xlWorkSheet.Cells[1, yColumns])).AutoFilter(1);
            MessageBox.Show("Extracted to Excel Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            xlApp.Visible = true;
            releaseObject(xlApp);
            releaseObject(xlWorkBook);
            releaseObject(xlWorkSheet);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void dtp_myEndEval_ValueChanged(object sender, EventArgs e)
        {
            tx_EndMyEval.Text = dtp_myEndEval.Value.ToString("MMMM dd, yyyy");
            fil_eDate = dtp_myEndEval.Value.ToString("yyyy-MM-dd 00:00:00");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            delete();
            MessageBox.Show("Record Deleted");
        }

        private void reference_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Logs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void names_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_SubCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Prof_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cb_Categ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tab_Records_Click(object sender, EventArgs e)
        {

        }


    }
}
