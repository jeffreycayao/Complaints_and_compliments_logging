namespace AON_Ticket_Tracker
{
    partial class frm_AdNw
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_EM_New_RsdBy = new System.Windows.Forms.Label();
            this.tx_EM_New_RsdBy = new System.Windows.Forms.TextBox();
            this.tx_EM_New_CntctEml = new System.Windows.Forms.TextBox();
            this.lbl_EM_New_CntctEml = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send back to Main Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_EM_New_RsdBy
            // 
            this.lbl_EM_New_RsdBy.AutoSize = true;
            this.lbl_EM_New_RsdBy.Font = new System.Drawing.Font("HP Simplified", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EM_New_RsdBy.Location = new System.Drawing.Point(12, 14);
            this.lbl_EM_New_RsdBy.Name = "lbl_EM_New_RsdBy";
            this.lbl_EM_New_RsdBy.Size = new System.Drawing.Size(58, 18);
            this.lbl_EM_New_RsdBy.TabIndex = 1;
            this.lbl_EM_New_RsdBy.Text = "Raised By:";
            // 
            // tx_EM_New_RsdBy
            // 
            this.tx_EM_New_RsdBy.Font = new System.Drawing.Font("HP Simplified", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_EM_New_RsdBy.Location = new System.Drawing.Point(76, 12);
            this.tx_EM_New_RsdBy.Name = "tx_EM_New_RsdBy";
            this.tx_EM_New_RsdBy.Size = new System.Drawing.Size(100, 22);
            this.tx_EM_New_RsdBy.TabIndex = 2;
            // 
            // tx_EM_New_CntctEml
            // 
            this.tx_EM_New_CntctEml.Font = new System.Drawing.Font("HP Simplified", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_EM_New_CntctEml.Location = new System.Drawing.Point(76, 40);
            this.tx_EM_New_CntctEml.Name = "tx_EM_New_CntctEml";
            this.tx_EM_New_CntctEml.Size = new System.Drawing.Size(100, 22);
            this.tx_EM_New_CntctEml.TabIndex = 4;
            // 
            // lbl_EM_New_CntctEml
            // 
            this.lbl_EM_New_CntctEml.AutoSize = true;
            this.lbl_EM_New_CntctEml.Font = new System.Drawing.Font("HP Simplified", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EM_New_CntctEml.Location = new System.Drawing.Point(12, 42);
            this.lbl_EM_New_CntctEml.Name = "lbl_EM_New_CntctEml";
            this.lbl_EM_New_CntctEml.Size = new System.Drawing.Size(58, 18);
            this.lbl_EM_New_CntctEml.TabIndex = 3;
            this.lbl_EM_New_CntctEml.Text = "Raised By:";
            // 
            // frm_AdNw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(373, 262);
            this.Controls.Add(this.tx_EM_New_CntctEml);
            this.Controls.Add(this.lbl_EM_New_CntctEml);
            this.Controls.Add(this.tx_EM_New_RsdBy);
            this.Controls.Add(this.lbl_EM_New_RsdBy);
            this.Controls.Add(this.button1);
            this.Name = "frm_AdNw";
            this.Text = "EM - New Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_EM_New_RsdBy;
        private System.Windows.Forms.TextBox tx_EM_New_RsdBy;
        private System.Windows.Forms.TextBox tx_EM_New_CntctEml;
        private System.Windows.Forms.Label lbl_EM_New_CntctEml;

    }
}