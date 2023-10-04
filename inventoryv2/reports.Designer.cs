namespace inventoryv2
{
    partial class reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stockReportGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.total_qty = new System.Windows.Forms.Label();
            this.total_amount = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.export_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 121);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(212, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Demo Tool Shop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(924, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(350, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Report";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Sienna;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 31);
            this.panel2.TabIndex = 12;
            // 
            // stockReportGrid
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stockReportGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.stockReportGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.stockReportGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockReportGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockReportGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.stockReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockReportGrid.DoubleBuffered = true;
            this.stockReportGrid.EnableHeadersVisualStyles = false;
            this.stockReportGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.stockReportGrid.HeaderForeColor = System.Drawing.Color.White;
            this.stockReportGrid.Location = new System.Drawing.Point(22, 182);
            this.stockReportGrid.Margin = new System.Windows.Forms.Padding(2);
            this.stockReportGrid.Name = "stockReportGrid";
            this.stockReportGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stockReportGrid.RowHeadersWidth = 100;
            this.stockReportGrid.RowTemplate.Height = 24;
            this.stockReportGrid.Size = new System.Drawing.Size(872, 347);
            this.stockReportGrid.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total Amount (LKR)";
            // 
            // total_qty
            // 
            this.total_qty.AutoSize = true;
            this.total_qty.Location = new System.Drawing.Point(131, 535);
            this.total_qty.Name = "total_qty";
            this.total_qty.Size = new System.Drawing.Size(13, 13);
            this.total_qty.TabIndex = 24;
            this.total_qty.Text = "0";
            // 
            // total_amount
            // 
            this.total_amount.AutoSize = true;
            this.total_amount.Location = new System.Drawing.Point(131, 569);
            this.total_amount.Name = "total_amount";
            this.total_amount.Size = new System.Drawing.Size(13, 13);
            this.total_amount.TabIndex = 24;
            this.total_amount.Text = "0";
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.LightCoral;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(22, 131);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(88, 38);
            this.home.TabIndex = 25;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // export_btn
            // 
            this.export_btn.BackColor = System.Drawing.Color.LightCoral;
            this.export_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_btn.Location = new System.Drawing.Point(806, 131);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(88, 38);
            this.export_btn.TabIndex = 26;
            this.export_btn.Text = "Export";
            this.export_btn.UseVisualStyleBackColor = false;
            this.export_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 635);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.home);
            this.Controls.Add(this.total_amount);
            this.Controls.Add(this.total_qty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stockReportGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "reports";
            this.Text = "reports";
            this.Load += new System.EventHandler(this.reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid stockReportGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total_qty;
        private System.Windows.Forms.Label total_amount;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button export_btn;
    }
}