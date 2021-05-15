namespace Pishgam_Invoice
{
    partial class frmServices
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
            this.txtService = new System.Windows.Forms.TextBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.dgvServices_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServices_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServices_Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام سرویس:";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(12, 12);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(774, 28);
            this.txtService.TabIndex = 1;
            // 
            // dgvServices
            // 
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvServices_ID,
            this.dgvServices_Name,
            this.dgvServices_Fee});
            this.dgvServices.Location = new System.Drawing.Point(12, 46);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvServices.Size = new System.Drawing.Size(849, 414);
            this.dgvServices.TabIndex = 2;
            // 
            // dgvServices_ID
            // 
            this.dgvServices_ID.DataPropertyName = "ID";
            this.dgvServices_ID.HeaderText = "ID";
            this.dgvServices_ID.Name = "dgvServices_ID";
            this.dgvServices_ID.Visible = false;
            // 
            // dgvServices_Name
            // 
            this.dgvServices_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvServices_Name.DataPropertyName = "Name";
            this.dgvServices_Name.HeaderText = "نام سرویس";
            this.dgvServices_Name.Name = "dgvServices_Name";
            // 
            // dgvServices_Fee
            // 
            this.dgvServices_Fee.DataPropertyName = "Fee";
            this.dgvServices_Fee.HeaderText = "قیمت";
            this.dgvServices_Fee.Name = "dgvServices_Fee";
            this.dgvServices_Fee.Width = 200;
            // 
            // frmServices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(877, 472);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Vazir FD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServices";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سرویس ها";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvServices_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvServices_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvServices_Fee;
    }
}