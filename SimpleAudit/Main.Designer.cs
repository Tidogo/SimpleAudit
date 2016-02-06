namespace SimpleAudit
{
    partial class Main
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
            this.cbo_Degrees = new System.Windows.Forms.ComboBox();
            this.btn_Populate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MinGenCredits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbo_ProgClasses = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MinDegClasses = new System.Windows.Forms.TextBox();
            this.btn_Audit = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbo_GenClassList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbo_Degrees
            // 
            this.cbo_Degrees.FormattingEnabled = true;
            this.cbo_Degrees.Location = new System.Drawing.Point(12, 28);
            this.cbo_Degrees.Name = "cbo_Degrees";
            this.cbo_Degrees.Size = new System.Drawing.Size(236, 21);
            this.cbo_Degrees.TabIndex = 0;
            // 
            // btn_Populate
            // 
            this.btn_Populate.Location = new System.Drawing.Point(257, 26);
            this.btn_Populate.Name = "btn_Populate";
            this.btn_Populate.Size = new System.Drawing.Size(92, 23);
            this.btn_Populate.TabIndex = 1;
            this.btn_Populate.Text = "Populate";
            this.btn_Populate.UseVisualStyleBackColor = true;
            this.btn_Populate.Click += new System.EventHandler(this.btn_Populate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minimum General Credits";
            // 
            // txt_MinGenCredits
            // 
            this.txt_MinGenCredits.Location = new System.Drawing.Point(376, 103);
            this.txt_MinGenCredits.Name = "txt_MinGenCredits";
            this.txt_MinGenCredits.Size = new System.Drawing.Size(34, 20);
            this.txt_MinGenCredits.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "General Education Classes:";
            // 
            // lbo_ProgClasses
            // 
            this.lbo_ProgClasses.FormattingEnabled = true;
            this.lbo_ProgClasses.Location = new System.Drawing.Point(12, 322);
            this.lbo_ProgClasses.Name = "lbo_ProgClasses";
            this.lbo_ProgClasses.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbo_ProgClasses.Size = new System.Drawing.Size(236, 303);
            this.lbo_ProgClasses.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Program Classes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Minimum Core Credits";
            // 
            // txt_MinDegClasses
            // 
            this.txt_MinDegClasses.Location = new System.Drawing.Point(368, 330);
            this.txt_MinDegClasses.Name = "txt_MinDegClasses";
            this.txt_MinDegClasses.Size = new System.Drawing.Size(32, 20);
            this.txt_MinDegClasses.TabIndex = 11;
            // 
            // btn_Audit
            // 
            this.btn_Audit.Location = new System.Drawing.Point(484, 461);
            this.btn_Audit.Name = "btn_Audit";
            this.btn_Audit.Size = new System.Drawing.Size(82, 42);
            this.btn_Audit.TabIndex = 14;
            this.btn_Audit.Text = "Audit";
            this.btn_Audit.UseVisualStyleBackColor = true;
            this.btn_Audit.Click += new System.EventHandler(this.btn_Audit_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(484, 522);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(82, 42);
            this.btn_Help.TabIndex = 15;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(484, 583);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 42);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pick a Degree";
            // 
            // lbo_GenClassList
            // 
            this.lbo_GenClassList.FormattingEnabled = true;
            this.lbo_GenClassList.Location = new System.Drawing.Point(15, 96);
            this.lbo_GenClassList.Name = "lbo_GenClassList";
            this.lbo_GenClassList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbo_GenClassList.Size = new System.Drawing.Size(233, 199);
            this.lbo_GenClassList.TabIndex = 18;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 637);
            this.Controls.Add(this.lbo_GenClassList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Audit);
            this.Controls.Add(this.txt_MinDegClasses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbo_ProgClasses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MinGenCredits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Populate);
            this.Controls.Add(this.cbo_Degrees);
            this.Name = "Main";
            this.Text = "Simple Audit";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Degrees;
        private System.Windows.Forms.Button btn_Populate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MinGenCredits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbo_ProgClasses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MinDegClasses;
        private System.Windows.Forms.Button btn_Audit;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbo_GenClassList;
    }
}

