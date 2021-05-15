namespace Pishgam_Invoice
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.stiReport_Invoice = new Stimulsoft.Report.StiReport();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stiReport_Invoice
            // 
            this.stiReport_Invoice.CookieContainer = null;
            this.stiReport_Invoice.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport_Invoice.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport_Invoice.ReportAlias = "Report";
            this.stiReport_Invoice.ReportGuid = "d33205b97c554aa984cfe93bb9a90ca7";
            this.stiReport_Invoice.ReportImage = null;
            this.stiReport_Invoice.ReportName = "Report";
            this.stiReport_Invoice.ReportSource = resources.GetString("stiReport_Invoice.ReportSource");
            this.stiReport_Invoice.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport_Invoice.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport_Invoice.UseProgressInThread = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "اطلاعات مشتریان";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "اطلاعات شرکت";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(564, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "فاکتور جدید";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnServices
            // 
            this.btnServices.Location = new System.Drawing.Point(564, 117);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(161, 29);
            this.btnServices.TabIndex = 7;
            this.btnServices.Text = "سرویس ها";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 402);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Vazir FD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Stimulsoft.Report.StiReport stiReport_Invoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnServices;
    }
}

