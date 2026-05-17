namespace MedicineOrderingSystem
{
    partial class Form_PatientRegistration
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
            this.txt_SearchPhone = new System.Windows.Forms.TextBox();
            this.btn_LoadPatients = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_SavePatients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Patient by Phone:";
            // 
            // txt_SearchPhone
            // 
            this.txt_SearchPhone.Location = new System.Drawing.Point(204, 32);
            this.txt_SearchPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SearchPhone.Name = "txt_SearchPhone";
            this.txt_SearchPhone.Size = new System.Drawing.Size(132, 22);
            this.txt_SearchPhone.TabIndex = 1;
            // 
            // btn_LoadPatients
            // 
            this.btn_LoadPatients.Location = new System.Drawing.Point(203, 62);
            this.btn_LoadPatients.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LoadPatients.Name = "btn_LoadPatients";
            this.btn_LoadPatients.Size = new System.Drawing.Size(133, 28);
            this.btn_LoadPatients.TabIndex = 2;
            this.btn_LoadPatients.Text = "Load Patients";
            this.btn_LoadPatients.UseVisualStyleBackColor = true;
            this.btn_LoadPatients.Click += new System.EventHandler(this.btn_LoadPatients_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(735, 249);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_SavePatients
            // 
            this.btn_SavePatients.Location = new System.Drawing.Point(484, 355);
            this.btn_SavePatients.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SavePatients.Name = "btn_SavePatients";
            this.btn_SavePatients.Size = new System.Drawing.Size(264, 28);
            this.btn_SavePatients.TabIndex = 4;
            this.btn_SavePatients.Text = "Save All Changes to Database";
            this.btn_SavePatients.UseVisualStyleBackColor = true;
            this.btn_SavePatients.Click += new System.EventHandler(this.btn_SavePatients_Click);
            // 
            // Form_PatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_SavePatients);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_LoadPatients);
            this.Controls.Add(this.txt_SearchPhone);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_PatientRegistration";
            this.Text = "Form_PatientRegistration";
            this.Load += new System.EventHandler(this.Form_PatientRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SearchPhone;
        private System.Windows.Forms.Button btn_LoadPatients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_SavePatients;
    }
}