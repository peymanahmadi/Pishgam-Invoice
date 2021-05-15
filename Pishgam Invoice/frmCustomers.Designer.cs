namespace Pishgam_Invoice
{
    partial class frmCustomers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEconomicCode = new System.Windows.Forms.TextBox();
            this.txtRegiserCode = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economicCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ردیف:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام شخص حقیقی / حقوقی:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(681, 30);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(164, 28);
            this.txtID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(501, 28);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(800, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "شماره اقتصادی:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "شماره ثبت / شماره ملی:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "استان:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "کد پستی 10 رقمی:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "شهر:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(846, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "نشانی:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "شماره تلفن / نمابر:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtEconomicCode
            // 
            this.txtEconomicCode.Location = new System.Drawing.Point(619, 64);
            this.txtEconomicCode.Name = "txtEconomicCode";
            this.txtEconomicCode.Size = new System.Drawing.Size(175, 28);
            this.txtEconomicCode.TabIndex = 11;
            // 
            // txtRegiserCode
            // 
            this.txtRegiserCode.Location = new System.Drawing.Point(288, 64);
            this.txtRegiserCode.Name = "txtRegiserCode";
            this.txtRegiserCode.Size = new System.Drawing.Size(183, 28);
            this.txtRegiserCode.TabIndex = 12;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(12, 64);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(221, 28);
            this.txtProvince.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(830, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "شهرستان:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(619, 98);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(205, 28);
            this.txtState.TabIndex = 15;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(318, 98);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(183, 28);
            this.txtPostalCode.TabIndex = 16;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(12, 98);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(259, 28);
            this.txtCity.TabIndex = 17;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(288, 132);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(552, 28);
            this.txtAddress.TabIndex = 18;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 132);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(155, 28);
            this.txtPhoneNumber.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(785, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "جدید";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 28);
            this.button2.TabIndex = 21;
            this.button2.Text = "ویرایش";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(561, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 28);
            this.button3.TabIndex = 22;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(449, 166);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(106, 28);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "ثبت";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.economicCode,
            this.registerCode,
            this.province,
            this.state,
            this.postalCode,
            this.city,
            this.address,
            this.phoneNumber});
            this.dgvCustomers.Location = new System.Drawing.Point(12, 200);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(879, 231);
            this.dgvCustomers.TabIndex = 24;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "نام شرکت";
            this.name.Name = "name";
            // 
            // economicCode
            // 
            this.economicCode.DataPropertyName = "Economic Code";
            this.economicCode.HeaderText = "کد اقتصادی";
            this.economicCode.Name = "economicCode";
            // 
            // registerCode
            // 
            this.registerCode.DataPropertyName = "RegisterCode";
            this.registerCode.HeaderText = "شماره ثبت";
            this.registerCode.Name = "registerCode";
            // 
            // province
            // 
            this.province.DataPropertyName = "Province";
            this.province.HeaderText = "استان";
            this.province.Name = "province";
            // 
            // state
            // 
            this.state.DataPropertyName = "State";
            this.state.HeaderText = "شهرستان";
            this.state.Name = "state";
            // 
            // postalCode
            // 
            this.postalCode.DataPropertyName = "PostalCode";
            this.postalCode.HeaderText = "کد پستی";
            this.postalCode.Name = "postalCode";
            // 
            // city
            // 
            this.city.DataPropertyName = "City";
            this.city.HeaderText = "شهر";
            this.city.Name = "city";
            // 
            // address
            // 
            this.address.DataPropertyName = "Address";
            this.address.HeaderText = "آدرس";
            this.address.Name = "address";
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataPropertyName = "PhoneNumber";
            this.phoneNumber.HeaderText = "تلفن";
            this.phoneNumber.Name = "phoneNumber";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 443);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtRegiserCode);
            this.Controls.Add(this.txtEconomicCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Vazir FD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEconomicCode;
        private System.Windows.Forms.TextBox txtRegiserCode;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn economicCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn province;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
    }
}