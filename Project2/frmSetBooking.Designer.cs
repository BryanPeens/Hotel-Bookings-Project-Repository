namespace Project2
{
    partial class frmSetBooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTextChange = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cspnedtnumPatrons = new System.Windows.Forms.NumericUpDown();
            this.cspnedtNumdays = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtSurname = new System.Windows.Forms.TextBox();
            this.edtID = new System.Windows.Forms.TextBox();
            this.edtTelNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btbtnApply = new System.Windows.Forms.Button();
            this.btbtnSaveQ = new System.Windows.Forms.Button();
            this.chcklstbxOptions = new System.Windows.Forms.CheckedListBox();
            this.mmAddress = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cspnedtnumPatrons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cspnedtNumdays)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblTextChange);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 108);
            this.panel1.TabIndex = 0;
            // 
            // lblTextChange
            // 
            this.lblTextChange.AutoSize = true;
            this.lblTextChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextChange.ForeColor = System.Drawing.Color.Purple;
            this.lblTextChange.Location = new System.Drawing.Point(156, 22);
            this.lblTextChange.Name = "lblTextChange";
            this.lblTextChange.Size = new System.Drawing.Size(393, 55);
            this.lblTextChange.TabIndex = 0;
            this.lblTextChange.Text = "Suite Name Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telephone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number Of Patrons";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(514, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address";
            // 
            // cspnedtnumPatrons
            // 
            this.cspnedtnumPatrons.Location = new System.Drawing.Point(277, 245);
            this.cspnedtnumPatrons.Name = "cspnedtnumPatrons";
            this.cspnedtnumPatrons.Size = new System.Drawing.Size(149, 21);
            this.cspnedtnumPatrons.TabIndex = 7;
            // 
            // cspnedtNumdays
            // 
            this.cspnedtNumdays.Location = new System.Drawing.Point(35, 318);
            this.cspnedtNumdays.Name = "cspnedtNumdays";
            this.cspnedtNumdays.Size = new System.Drawing.Size(147, 21);
            this.cspnedtNumdays.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Number Of days";
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(35, 178);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(147, 21);
            this.edtName.TabIndex = 11;
            // 
            // edtSurname
            // 
            this.edtSurname.Location = new System.Drawing.Point(277, 178);
            this.edtSurname.Name = "edtSurname";
            this.edtSurname.Size = new System.Drawing.Size(149, 21);
            this.edtSurname.TabIndex = 12;
            // 
            // edtID
            // 
            this.edtID.Location = new System.Drawing.Point(518, 178);
            this.edtID.Name = "edtID";
            this.edtID.Size = new System.Drawing.Size(147, 21);
            this.edtID.TabIndex = 13;
            // 
            // edtTelNumber
            // 
            this.edtTelNumber.Location = new System.Drawing.Point(35, 245);
            this.edtTelNumber.Name = "edtTelNumber";
            this.edtTelNumber.Size = new System.Drawing.Size(147, 21);
            this.edtTelNumber.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Options";
            // 
            // btbtnApply
            // 
            this.btbtnApply.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbtnApply.Location = new System.Drawing.Point(412, 500);
            this.btbtnApply.Name = "btbtnApply";
            this.btbtnApply.Size = new System.Drawing.Size(106, 36);
            this.btbtnApply.TabIndex = 21;
            this.btbtnApply.Text = "Apply";
            this.btbtnApply.UseVisualStyleBackColor = true;
            this.btbtnApply.Click += new System.EventHandler(this.btbtnApply_Click);
            // 
            // btbtnSaveQ
            // 
            this.btbtnSaveQ.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbtnSaveQ.Location = new System.Drawing.Point(574, 500);
            this.btbtnSaveQ.Name = "btbtnSaveQ";
            this.btbtnSaveQ.Size = new System.Drawing.Size(132, 36);
            this.btbtnSaveQ.TabIndex = 22;
            this.btbtnSaveQ.Text = "Save Quota";
            this.btbtnSaveQ.UseVisualStyleBackColor = true;
            this.btbtnSaveQ.Click += new System.EventHandler(this.btbtnSaveQ_Click);
            // 
            // chcklstbxOptions
            // 
            this.chcklstbxOptions.FormattingEnabled = true;
            this.chcklstbxOptions.Location = new System.Drawing.Point(35, 398);
            this.chcklstbxOptions.Name = "chcklstbxOptions";
            this.chcklstbxOptions.Size = new System.Drawing.Size(197, 116);
            this.chcklstbxOptions.TabIndex = 23;
            // 
            // mmAddress
            // 
            this.mmAddress.Location = new System.Drawing.Point(518, 245);
            this.mmAddress.Multiline = true;
            this.mmAddress.Name = "mmAddress";
            this.mmAddress.Size = new System.Drawing.Size(147, 94);
            this.mmAddress.TabIndex = 24;
            this.mmAddress.Text = "mmAddress";
            // 
            // frmSetBooking
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(734, 565);
            this.Controls.Add(this.mmAddress);
            this.Controls.Add(this.chcklstbxOptions);
            this.Controls.Add(this.btbtnSaveQ);
            this.Controls.Add(this.btbtnApply);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.edtTelNumber);
            this.Controls.Add(this.edtID);
            this.Controls.Add(this.edtSurname);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cspnedtNumdays);
            this.Controls.Add(this.cspnedtnumPatrons);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSetBooking";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cspnedtnumPatrons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cspnedtNumdays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTextChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown cspnedtnumPatrons;
        private System.Windows.Forms.NumericUpDown cspnedtNumdays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.TextBox edtSurname;
        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.TextBox edtTelNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btbtnApply;
        private System.Windows.Forms.Button btbtnSaveQ;
        private System.Windows.Forms.CheckedListBox chcklstbxOptions;
        private System.Windows.Forms.TextBox mmAddress;
    }
}