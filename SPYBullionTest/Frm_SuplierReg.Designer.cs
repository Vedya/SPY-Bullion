namespace SPYBullionTest
{
    partial class Frm_SuplierReg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SuplierReg));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Reg = new System.Windows.Forms.Button();
            this.text_Contact = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textSupName = new System.Windows.Forms.TextBox();
            this.text_TIN = new System.Windows.Forms.TextBox();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_SupName = new System.Windows.Forms.Label();
            this.lbl_TinNo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 301);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage1.BackgroundImage = global::SPYBullionTest.Properties.Resources._1MedGold_png_320x480;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.btn_Cancel);
            this.tabPage1.Controls.Add(this.Btn_Reg);
            this.tabPage1.Controls.Add(this.text_Contact);
            this.tabPage1.Controls.Add(this.textAddress);
            this.tabPage1.Controls.Add(this.textSupName);
            this.tabPage1.Controls.Add(this.text_TIN);
            this.tabPage1.Controls.Add(this.lbl_Contact);
            this.tabPage1.Controls.Add(this.lbl_Address);
            this.tabPage1.Controls.Add(this.lbl_SupName);
            this.tabPage1.Controls.Add(this.lbl_TinNo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(500, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Supplier";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.BackgroundImage")));
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancel.Location = new System.Drawing.Point(274, 206);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Btn_Reg
            // 
            this.Btn_Reg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Reg.BackgroundImage")));
            this.Btn_Reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Reg.Location = new System.Drawing.Point(182, 206);
            this.Btn_Reg.Name = "Btn_Reg";
            this.Btn_Reg.Size = new System.Drawing.Size(75, 23);
            this.Btn_Reg.TabIndex = 8;
            this.Btn_Reg.Text = "Register";
            this.Btn_Reg.UseVisualStyleBackColor = true;
            this.Btn_Reg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Reg_MouseUp);
            // 
            // text_Contact
            // 
            this.text_Contact.BackColor = System.Drawing.Color.LemonChiffon;
            this.text_Contact.Location = new System.Drawing.Point(182, 165);
            this.text_Contact.Name = "text_Contact";
            this.text_Contact.Size = new System.Drawing.Size(167, 20);
            this.text_Contact.TabIndex = 7;
            // 
            // textAddress
            // 
            this.textAddress.BackColor = System.Drawing.Color.LemonChiffon;
            this.textAddress.Location = new System.Drawing.Point(182, 84);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(167, 65);
            this.textAddress.TabIndex = 6;
            // 
            // textSupName
            // 
            this.textSupName.BackColor = System.Drawing.Color.LemonChiffon;
            this.textSupName.Location = new System.Drawing.Point(182, 46);
            this.textSupName.Name = "textSupName";
            this.textSupName.Size = new System.Drawing.Size(167, 20);
            this.textSupName.TabIndex = 5;
            // 
            // text_TIN
            // 
            this.text_TIN.BackColor = System.Drawing.Color.LemonChiffon;
            this.text_TIN.Location = new System.Drawing.Point(182, 22);
            this.text_TIN.Name = "text_TIN";
            this.text_TIN.Size = new System.Drawing.Size(167, 20);
            this.text_TIN.TabIndex = 4;
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact.Location = new System.Drawing.Point(52, 161);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(93, 17);
            this.lbl_Contact.TabIndex = 3;
            this.lbl_Contact.Text = "Contact No.";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(52, 80);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(67, 17);
            this.lbl_Address.TabIndex = 2;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_SupName
            // 
            this.lbl_SupName.AutoSize = true;
            this.lbl_SupName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupName.Location = new System.Drawing.Point(52, 49);
            this.lbl_SupName.Name = "lbl_SupName";
            this.lbl_SupName.Size = new System.Drawing.Size(124, 17);
            this.lbl_SupName.TabIndex = 1;
            this.lbl_SupName.Text = "Supplier Name :";
            // 
            // lbl_TinNo
            // 
            this.lbl_TinNo.AutoSize = true;
            this.lbl_TinNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TinNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TinNo.Location = new System.Drawing.Point(52, 21);
            this.lbl_TinNo.Name = "lbl_TinNo";
            this.lbl_TinNo.Size = new System.Drawing.Size(68, 17);
            this.lbl_TinNo.TabIndex = 0;
            this.lbl_TinNo.Text = "TIN No :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage2.BackgroundImage = global::SPYBullionTest.Properties.Resources._1MedGold_png_320x480;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(500, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Existing Suppliers";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(357, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(213, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(66, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView6.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column7,
            this.Column8,
            this.TINNumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView6.Location = new System.Drawing.Point(3, 0);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersVisible = false;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.Size = new System.Drawing.Size(497, 192);
            this.dataGridView6.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Address";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Contact";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // TINNumber
            // 
            this.TINNumber.HeaderText = "TIN Number";
            this.TINNumber.Name = "TINNumber";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Frm_SuplierReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 304);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_SuplierReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SuplierReg";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button Btn_Reg;
        private System.Windows.Forms.TextBox text_Contact;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textSupName;
        private System.Windows.Forms.TextBox text_TIN;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_SupName;
        private System.Windows.Forms.Label lbl_TinNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINNumber;
        private System.Windows.Forms.Button button3;
    }
}