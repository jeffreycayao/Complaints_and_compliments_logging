namespace AON_Ticket_Tracker
{
    partial class frm_Xtrct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Xtrct));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Prof = new System.Windows.Forms.ComboBox();
            this.reference = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.names = new System.Windows.Forms.ComboBox();
            this.tx_EndMyEval = new System.Windows.Forms.TextBox();
            this.dtp_myEndEval = new System.Windows.Forms.DateTimePicker();
            this.lbl_todate = new System.Windows.Forms.Label();
            this.cb_Categ = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_SubCateg = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_myEval = new System.Windows.Forms.TextBox();
            this.dtp_myFrmEval = new System.Windows.Forms.DateTimePicker();
            this.lbl_fromdate = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.but_filter = new System.Windows.Forms.Button();
            this.but_xtract = new System.Windows.Forms.Button();
            this.dgv_Logs = new System.Windows.Forms.DataGridView();
            this.tab_extract = new System.Windows.Forms.TabControl();
            this.tab_Records = new System.Windows.Forms.TabPage();
            this.dg_bic_view = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Logs)).BeginInit();
            this.tab_extract.SuspendLayout();
            this.tab_Records.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bic_view)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.cb_Prof);
            this.groupBox1.Controls.Add(this.reference);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.names);
            this.groupBox1.Controls.Add(this.tx_EndMyEval);
            this.groupBox1.Controls.Add(this.dtp_myEndEval);
            this.groupBox1.Controls.Add(this.lbl_todate);
            this.groupBox1.Controls.Add(this.cb_Categ);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_SubCateg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tx_myEval);
            this.groupBox1.Controls.Add(this.dtp_myFrmEval);
            this.groupBox1.Controls.Add(this.lbl_fromdate);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.but_filter);
            this.groupBox1.Controls.Add(this.but_xtract);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Records";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_Prof
            // 
            this.cb_Prof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Prof.FormattingEnabled = true;
            this.cb_Prof.Items.AddRange(new object[] {
            "",
            "Global CCMS",
            "Internal CCMS"});
            this.cb_Prof.Location = new System.Drawing.Point(337, 18);
            this.cb_Prof.Name = "cb_Prof";
            this.cb_Prof.Size = new System.Drawing.Size(150, 22);
            this.cb_Prof.TabIndex = 45;
            this.cb_Prof.SelectedIndexChanged += new System.EventHandler(this.cb_Prof_SelectedIndexChanged_1);
            // 
            // reference
            // 
            this.reference.Location = new System.Drawing.Point(801, 25);
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(100, 21);
            this.reference.TabIndex = 44;
            this.reference.Visible = false;
            this.reference.TextChanged += new System.EventHandler(this.reference_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(663, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 25);
            this.button1.TabIndex = 43;
            this.button1.Text = "Delete Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // names
            // 
            this.names.FormattingEnabled = true;
            this.names.Location = new System.Drawing.Point(52, 24);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(150, 22);
            this.names.TabIndex = 42;
            this.names.SelectedIndexChanged += new System.EventHandler(this.names_SelectedIndexChanged);
            // 
            // tx_EndMyEval
            // 
            this.tx_EndMyEval.Location = new System.Drawing.Point(52, 81);
            this.tx_EndMyEval.Name = "tx_EndMyEval";
            this.tx_EndMyEval.Size = new System.Drawing.Size(120, 21);
            this.tx_EndMyEval.TabIndex = 41;
            // 
            // dtp_myEndEval
            // 
            this.dtp_myEndEval.CustomFormat = "yyyy-MM-dd";
            this.dtp_myEndEval.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_myEndEval.Location = new System.Drawing.Point(52, 81);
            this.dtp_myEndEval.Name = "dtp_myEndEval";
            this.dtp_myEndEval.Size = new System.Drawing.Size(150, 21);
            this.dtp_myEndEval.TabIndex = 40;
            this.dtp_myEndEval.ValueChanged += new System.EventHandler(this.dtp_myEndEval_ValueChanged);
            // 
            // lbl_todate
            // 
            this.lbl_todate.AutoSize = true;
            this.lbl_todate.Location = new System.Drawing.Point(6, 85);
            this.lbl_todate.Name = "lbl_todate";
            this.lbl_todate.Size = new System.Drawing.Size(21, 14);
            this.lbl_todate.TabIndex = 39;
            this.lbl_todate.Text = "To:";
            // 
            // cb_Categ
            // 
            this.cb_Categ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Categ.FormattingEnabled = true;
            this.cb_Categ.Items.AddRange(new object[] {
            "",
            "In Progress",
            "Closed"});
            this.cb_Categ.Location = new System.Drawing.Point(337, 50);
            this.cb_Categ.Name = "cb_Categ";
            this.cb_Categ.Size = new System.Drawing.Size(150, 22);
            this.cb_Categ.TabIndex = 38;
            this.cb_Categ.SelectedIndexChanged += new System.EventHandler(this.cb_Categ_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 14);
            this.label5.TabIndex = 37;
            this.label5.Text = "Status:";
            // 
            // cb_SubCateg
            // 
            this.cb_SubCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SubCateg.FormattingEnabled = true;
            this.cb_SubCateg.Items.AddRange(new object[] {
            "",
            "Incident",
            "Request"});
            this.cb_SubCateg.Location = new System.Drawing.Point(337, 81);
            this.cb_SubCateg.Name = "cb_SubCateg";
            this.cb_SubCateg.Size = new System.Drawing.Size(150, 22);
            this.cb_SubCateg.TabIndex = 36;
            this.cb_SubCateg.SelectedIndexChanged += new System.EventHandler(this.cb_SubCateg_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 35;
            this.label4.Text = "Case Type:";
            // 
            // tx_myEval
            // 
            this.tx_myEval.Location = new System.Drawing.Point(52, 52);
            this.tx_myEval.Name = "tx_myEval";
            this.tx_myEval.Size = new System.Drawing.Size(120, 21);
            this.tx_myEval.TabIndex = 34;
            // 
            // dtp_myFrmEval
            // 
            this.dtp_myFrmEval.CustomFormat = "yyyy-MM-dd";
            this.dtp_myFrmEval.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_myFrmEval.Location = new System.Drawing.Point(52, 52);
            this.dtp_myFrmEval.Name = "dtp_myFrmEval";
            this.dtp_myFrmEval.Size = new System.Drawing.Size(150, 21);
            this.dtp_myFrmEval.TabIndex = 33;
            this.dtp_myFrmEval.ValueChanged += new System.EventHandler(this.dtp_myEval_ValueChanged);
            // 
            // lbl_fromdate
            // 
            this.lbl_fromdate.AutoSize = true;
            this.lbl_fromdate.Location = new System.Drawing.Point(6, 55);
            this.lbl_fromdate.Name = "lbl_fromdate";
            this.lbl_fromdate.Size = new System.Drawing.Size(36, 14);
            this.lbl_fromdate.TabIndex = 32;
            this.lbl_fromdate.Text = "From:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(223, 26);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 14);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "Escalation Type:";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 14);
            this.Label1.TabIndex = 28;
            this.Label1.Text = "Name:";
            // 
            // but_filter
            // 
            this.but_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_filter.BackColor = System.Drawing.Color.White;
            this.but_filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_filter.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_filter.ForeColor = System.Drawing.Color.Black;
            this.but_filter.Location = new System.Drawing.Point(663, 97);
            this.but_filter.Name = "but_filter";
            this.but_filter.Size = new System.Drawing.Size(109, 25);
            this.but_filter.TabIndex = 27;
            this.but_filter.Text = "Show Records";
            this.but_filter.UseVisualStyleBackColor = false;
            this.but_filter.Click += new System.EventHandler(this.but_filter_Click);
            // 
            // but_xtract
            // 
            this.but_xtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_xtract.BackColor = System.Drawing.Color.White;
            this.but_xtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_xtract.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_xtract.ForeColor = System.Drawing.Color.Black;
            this.but_xtract.Location = new System.Drawing.Point(801, 97);
            this.but_xtract.Name = "but_xtract";
            this.but_xtract.Size = new System.Drawing.Size(109, 25);
            this.but_xtract.TabIndex = 15;
            this.but_xtract.Text = "Extract Records";
            this.but_xtract.UseVisualStyleBackColor = false;
            this.but_xtract.Click += new System.EventHandler(this.but_xtract_Click);
            // 
            // dgv_Logs
            // 
            this.dgv_Logs.AllowUserToAddRows = false;
            this.dgv_Logs.AllowUserToDeleteRows = false;
            this.dgv_Logs.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_Logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Logs.Location = new System.Drawing.Point(3, 3);
            this.dgv_Logs.Name = "dgv_Logs";
            this.dgv_Logs.RowHeadersVisible = false;
            this.dgv_Logs.Size = new System.Drawing.Size(902, 255);
            this.dgv_Logs.TabIndex = 1;
            this.dgv_Logs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Logs_CellContentClick);
            // 
            // tab_extract
            // 
            this.tab_extract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_extract.Controls.Add(this.tab_Records);
            this.tab_extract.ItemSize = new System.Drawing.Size(62, 23);
            this.tab_extract.Location = new System.Drawing.Point(13, 148);
            this.tab_extract.Name = "tab_extract";
            this.tab_extract.SelectedIndex = 0;
            this.tab_extract.Size = new System.Drawing.Size(916, 292);
            this.tab_extract.TabIndex = 2;
            // 
            // tab_Records
            // 
            this.tab_Records.Controls.Add(this.dgv_Logs);
            this.tab_Records.Location = new System.Drawing.Point(4, 27);
            this.tab_Records.Name = "tab_Records";
            this.tab_Records.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Records.Size = new System.Drawing.Size(908, 261);
            this.tab_Records.TabIndex = 0;
            this.tab_Records.Text = "Records";
            this.tab_Records.UseVisualStyleBackColor = true;
            this.tab_Records.Click += new System.EventHandler(this.tab_Records_Click);
            // 
            // dg_bic_view
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_bic_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_bic_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_bic_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_bic_view.Location = new System.Drawing.Point(6, 6);
            this.dg_bic_view.Name = "dg_bic_view";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_bic_view.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_bic_view.Size = new System.Drawing.Size(780, 256);
            this.dg_bic_view.TabIndex = 0;
            // 
            // frm_Xtrct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(941, 446);
            this.Controls.Add(this.tab_extract);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("HP Simplified", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Xtrct";
            this.Text = "CCMS Offline Tracker v1.0";
            this.Load += new System.EventHandler(this.frm_Xtrct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Logs)).EndInit();
            this.tab_extract.ResumeLayout(false);
            this.tab_Records.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_bic_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Logs;
        internal System.Windows.Forms.Button but_xtract;
        internal System.Windows.Forms.ComboBox cb_Categ;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cb_SubCateg;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox tx_myEval;
        internal System.Windows.Forms.DateTimePicker dtp_myFrmEval;
        internal System.Windows.Forms.Label lbl_fromdate;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button but_filter;
        internal System.Windows.Forms.TextBox tx_EndMyEval;
        internal System.Windows.Forms.DateTimePicker dtp_myEndEval;
        internal System.Windows.Forms.Label lbl_todate;
        private System.Windows.Forms.TabControl tab_extract;
        private System.Windows.Forms.TabPage tab_Records;
       // private System.Windows.Forms.TabPage tab_BIC;
        private System.Windows.Forms.DataGridView dg_bic_view;
        private System.Windows.Forms.ComboBox names;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox reference;
        private System.Windows.Forms.ComboBox cb_Prof;
    }
}