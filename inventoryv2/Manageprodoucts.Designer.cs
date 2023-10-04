namespace inventoryv2
{
    partial class Manageprodoucts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtProductPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProductQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProductName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProductID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProductDescription = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 121);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(929, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(260, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "Demo Tool Shop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(316, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Prodoucts";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Sienna;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 630);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 31);
            this.panel2.TabIndex = 12;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtProductPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductPrice.HintText = "";
            this.txtProductPrice.isPassword = false;
            this.txtProductPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductPrice.LineIdleColor = System.Drawing.Color.IndianRed;
            this.txtProductPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductPrice.LineThickness = 4;
            this.txtProductPrice.Location = new System.Drawing.Point(27, 299);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(245, 36);
            this.txtProductPrice.TabIndex = 16;
            this.txtProductPrice.Text = "ProductPrice";
            this.txtProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProductQty
            // 
            this.txtProductQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductQty.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtProductQty.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductQty.HintText = "";
            this.txtProductQty.isPassword = false;
            this.txtProductQty.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductQty.LineIdleColor = System.Drawing.Color.IndianRed;
            this.txtProductQty.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductQty.LineThickness = 4;
            this.txtProductQty.Location = new System.Drawing.Point(27, 250);
            this.txtProductQty.Margin = new System.Windows.Forms.Padding(5);
            this.txtProductQty.Name = "txtProductQty";
            this.txtProductQty.Size = new System.Drawing.Size(245, 39);
            this.txtProductQty.TabIndex = 15;
            this.txtProductQty.Text = "ProductQty";
            this.txtProductQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProductName
            // 
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtProductName.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductName.HintText = "";
            this.txtProductName.isPassword = false;
            this.txtProductName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductName.LineIdleColor = System.Drawing.Color.IndianRed;
            this.txtProductName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductName.LineThickness = 4;
            this.txtProductName.Location = new System.Drawing.Point(27, 200);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(245, 40);
            this.txtProductName.TabIndex = 14;
            this.txtProductName.Text = "ProductName";
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProductID
            // 
            this.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtProductID.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductID.HintText = "";
            this.txtProductID.isPassword = false;
            this.txtProductID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductID.LineIdleColor = System.Drawing.Color.IndianRed;
            this.txtProductID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductID.LineThickness = 4;
            this.txtProductID.Location = new System.Drawing.Point(27, 147);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(5);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(245, 43);
            this.txtProductID.TabIndex = 13;
            this.txtProductID.Text = "ProdouctID";
            this.txtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductID.OnValueChanged += new System.EventHandler(this.ProdouctID_OnValueChanged);
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDescription.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtProductDescription.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductDescription.HintText = "";
            this.txtProductDescription.isPassword = false;
            this.txtProductDescription.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductDescription.LineIdleColor = System.Drawing.Color.IndianRed;
            this.txtProductDescription.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductDescription.LineThickness = 4;
            this.txtProductDescription.Location = new System.Drawing.Point(27, 353);
            this.txtProductDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(245, 36);
            this.txtProductDescription.TabIndex = 17;
            this.txtProductDescription.Text = "Description";
            this.txtProductDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 409);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 35);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "Prodouct Category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(104, 538);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 38);
            this.button4.TabIndex = 22;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(197, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 38);
            this.button3.TabIndex = 21;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(104, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(398, 184);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(526, 413);
            this.bunifuCustomDataGrid1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(556, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 36);
            this.label3.TabIndex = 24;
            this.label3.Text = "Prooduct List";
            // 
            // Manageprodoucts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductQty);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manageprodoucts";
            this.Text = "Manageprodoucts";
            this.Load += new System.EventHandler(this.Manageprodoucts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductQty;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductDescription;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Label label3;
    }
}