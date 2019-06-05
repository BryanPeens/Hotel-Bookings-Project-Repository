namespace Project2
{
    partial class frmBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooking));
            this.imgBanner = new System.Windows.Forms.Panel();
            this.strgrdSuite = new System.Windows.Forms.DataGridView();
            this.btbtnSetBooking = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSuite = new System.Windows.Forms.Panel();
            this.mmDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.strgrdSuite)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBanner
            // 
            this.imgBanner.BackColor = System.Drawing.SystemColors.Highlight;
            this.imgBanner.Location = new System.Drawing.Point(3, 2);
            this.imgBanner.Name = "imgBanner";
            this.imgBanner.Size = new System.Drawing.Size(697, 133);
            this.imgBanner.TabIndex = 0;
            // 
            // strgrdSuite
            // 
            this.strgrdSuite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.strgrdSuite.Location = new System.Drawing.Point(3, 141);
            this.strgrdSuite.Name = "strgrdSuite";
            this.strgrdSuite.ReadOnly = true;
            this.strgrdSuite.Size = new System.Drawing.Size(697, 206);
            this.strgrdSuite.TabIndex = 1;
            this.strgrdSuite.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.strgrdSuite_CellClick);
            this.strgrdSuite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.strgrdSuite_CellContentClick);
            this.strgrdSuite.SelectionChanged += new System.EventHandler(this.strgrdSuite_SelectionChanged);
            // 
            // btbtnSetBooking
            // 
            this.btbtnSetBooking.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btbtnSetBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbtnSetBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btbtnSetBooking.Location = new System.Drawing.Point(470, 610);
            this.btbtnSetBooking.Name = "btbtnSetBooking";
            this.btbtnSetBooking.Size = new System.Drawing.Size(99, 23);
            this.btbtnSetBooking.TabIndex = 4;
            this.btbtnSetBooking.Text = "Set Booking";
            this.btbtnSetBooking.UseVisualStyleBackColor = false;
            this.btbtnSetBooking.Click += new System.EventHandler(this.btnSetBooking_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(586, 610);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlSuite
            // 
            this.pnlSuite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSuite.BackgroundImage")));
            this.pnlSuite.Location = new System.Drawing.Point(355, 353);
            this.pnlSuite.Name = "pnlSuite";
            this.pnlSuite.Size = new System.Drawing.Size(335, 238);
            this.pnlSuite.TabIndex = 3;
            this.pnlSuite.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // mmDescription
            // 
            this.mmDescription.Location = new System.Drawing.Point(12, 353);
            this.mmDescription.Multiline = true;
            this.mmDescription.Name = "mmDescription";
            this.mmDescription.Size = new System.Drawing.Size(321, 161);
            this.mmDescription.TabIndex = 6;
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(702, 652);
            this.Controls.Add(this.mmDescription);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btbtnSetBooking);
            this.Controls.Add(this.pnlSuite);
            this.Controls.Add(this.strgrdSuite);
            this.Controls.Add(this.imgBanner);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frmBooking";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.strgrdSuite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel imgBanner;
        private System.Windows.Forms.DataGridView strgrdSuite;
        private System.Windows.Forms.Button btbtnSetBooking;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlSuite;
        private System.Windows.Forms.TextBox mmDescription;
    }
}