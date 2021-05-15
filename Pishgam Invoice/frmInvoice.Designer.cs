namespace Pishgam_Invoice
{
    partial class frmInvoice
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEconomicCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNewInvoice = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFinalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام مشتری:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(647, 28);
            this.textBox1.TabIndex = 1;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(12, 46);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(43, 28);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "...";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(714, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "شماره فاکتور:";
            // 
            // txtEconomicCode
            // 
            this.txtEconomicCode.Location = new System.Drawing.Point(549, 12);
            this.txtEconomicCode.Name = "txtEconomicCode";
            this.txtEconomicCode.Size = new System.Drawing.Size(159, 28);
            this.txtEconomicCode.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "لیست کالا یا خدمات ارائه شده:";
            // 
            // dgvNewInvoice
            // 
            this.dgvNewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvName,
            this.dgvNumber,
            this.dgvFee,
            this.dgvFinalFee});
            this.dgvNewInvoice.Location = new System.Drawing.Point(12, 119);
            this.dgvNewInvoice.Name = "dgvNewInvoice";
            this.dgvNewInvoice.Size = new System.Drawing.Size(776, 202);
            this.dgvNewInvoice.TabIndex = 14;
            this.dgvNewInvoice.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvNewInvoice_CellBeginEdit);
            this.dgvNewInvoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewInvoice_CellDoubleClick);
            this.dgvNewInvoice.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewInvoice_CellValueChanged);
            // 
            // dgvID
            // 
            this.dgvID.HeaderText = "شناسه";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Width = 50;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "نام کالا یا خدمات";
            this.dgvName.Name = "dgvName";
            // 
            // dgvNumber
            // 
            this.dgvNumber.HeaderText = "تعداد / مقدار";
            this.dgvNumber.Name = "dgvNumber";
            this.dgvNumber.Width = 120;
            // 
            // dgvFee
            // 
            this.dgvFee.HeaderText = "قیمت";
            this.dgvFee.Name = "dgvFee";
            // 
            // dgvFinalFee
            // 
            this.dgvFinalFee.HeaderText = "قیمت کل";
            this.dgvFinalFee.Name = "dgvFinalFee";
            this.dgvFinalFee.ReadOnly = true;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 440);
            this.Controls.Add(this.dgvNewInvoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEconomicCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Vazir FD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEconomicCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNewInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFinalFee;
    }
}