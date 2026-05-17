namespace MedicineOrderingSystem
{
    partial class Form_Report_Search
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
            this.txt_SearchParam = new System.Windows.Forms.TextBox();
            this.btn_LoadReport = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Patient ID:";
            // 
            // txt_SearchParam
            // 
            this.txt_SearchParam.Location = new System.Drawing.Point(129, 6);
            this.txt_SearchParam.Name = "txt_SearchParam";
            this.txt_SearchParam.Size = new System.Drawing.Size(100, 22);
            this.txt_SearchParam.TabIndex = 1;
            // 
            // btn_LoadReport
            // 
            this.btn_LoadReport.Location = new System.Drawing.Point(92, 34);
            this.btn_LoadReport.Name = "btn_LoadReport";
            this.btn_LoadReport.Size = new System.Drawing.Size(174, 23);
            this.btn_LoadReport.TabIndex = 2;
            this.btn_LoadReport.Text = "Generate Report";
            this.btn_LoadReport.UseVisualStyleBackColor = true;
            this.btn_LoadReport.Click += new System.EventHandler(this.btn_LoadReport_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-2, 63);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(944, 501);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // Form_Report_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 568);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btn_LoadReport);
            this.Controls.Add(this.txt_SearchParam);
            this.Controls.Add(this.label1);
            this.Name = "Form_Report_Search";
            this.Text = "Form_Report_PatientOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SearchParam;
        private System.Windows.Forms.Button btn_LoadReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}