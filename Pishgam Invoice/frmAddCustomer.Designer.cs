namespace Pishgam_Invoice
{
    partial class frmAddCustomer
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
            this.txtEconomicCode = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomers_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomers_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomers_EconomicCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomers_RegisterCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomers_Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEconomicCode
            // 
            this.txtEconomicCode.Location = new System.Drawing.Point(12, 12);
            this.txtEconomicCode.Name = "txtEconomicCode";
            this.txtEconomicCode.Size = new System.Drawing.Size(757, 28);
            this.txtEconomicCode.TabIndex = 12;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCustomers_ID,
            this.dgvCustomers_Name,
            this.dgvCustomers_EconomicCode,
            this.dgvCustomers_RegisterCode,
            this.dgvCustomers_Province});
            this.dgvCustomers.Location = new System.Drawing.Point(12, 46);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCustomers.Size = new System.Drawing.Size(830, 338);
            this.dgvCustomers.TabIndex = 13;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 390);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(106, 28);
            this.btnRegister.TabIndex = 25;
            this.btnRegister.Text = "تایید";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "انصراف";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(775, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "نام مشتری:";
            // 
            // dgvCustomers_ID
            // 
            this.dgvCustomers_ID.DataPropertyName = "ID";
            this.dgvCustomers_ID.HeaderText = "شناسه";
            this.dgvCustomers_ID.Name = "dgvCustomers_ID";
            this.dgvCustomers_ID.Width = 50;
            // 
            // dgvCustomers_Name
            // 
            this.dgvCustomers_Name.DataPropertyName = "Name";
            this.dgvCustomers_Name.HeaderText = "نام";
            this.dgvCustomers_Name.Name = "dgvCustomers_Name";
            this.dgvCustomers_Name.Width = 300;
            // 
            // dgvCustomers_EconomicCode
            // 
            this.dgvCustomers_EconomicCode.DataPropertyName = "EconomicCode";
            this.dgvCustomers_EconomicCode.HeaderText = "کداقتصادی";
            this.dgvCustomers_EconomicCode.Name = "dgvCustomers_EconomicCode";
            // 
            // dgvCustomers_RegisterCode
            // 
            this.dgvCustomers_RegisterCode.DataPropertyName = "RegisterCode";
            this.dgvCustomers_RegisterCode.HeaderText = "شماره ثبت";
            this.dgvCustomers_RegisterCode.Name = "dgvCustomers_RegisterCode";
            // 
            // dgvCustomers_Province
            // 
            this.dgvCustomers_Province.DataPropertyName = "Province";
            this.dgvCustomers_Province.HeaderText = "استان";
            this.dgvCustomers_Province.Name = "dgvCustomers_Province";
            // 
            // frmAddCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(858, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.txtEconomicCode);
            this.Font = new System.Drawing.Font("Vazir FD", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCustomer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب مشتری";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEconomicCode;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomers_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomers_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomers_EconomicCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomers_RegisterCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomers_Province;
    }
}