namespace MedicineOrderingSystem
{
    partial class Form_DriverManagement
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
            this.Location_label = new System.Windows.Forms.Label();
            this.txt_SearchLocation = new System.Windows.Forms.TextBox();
            this.btn_LoadDrivers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_SaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Location_label
            // 
            this.Location_label.AutoSize = true;
            this.Location_label.Location = new System.Drawing.Point(29, 36);
            this.Location_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Location_label.Name = "Location_label";
            this.Location_label.Size = new System.Drawing.Size(146, 17);
            this.Location_label.TabIndex = 0;
            this.Location_label.Text = "Enter Driver Location:";
            // 
            // txt_SearchLocation
            // 
            this.txt_SearchLocation.Location = new System.Drawing.Point(204, 32);
            this.txt_SearchLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SearchLocation.Name = "txt_SearchLocation";
            this.txt_SearchLocation.Size = new System.Drawing.Size(132, 22);
            this.txt_SearchLocation.TabIndex = 1;
            // 
            // btn_LoadDrivers
            // 
            this.btn_LoadDrivers.Location = new System.Drawing.Point(203, 62);
            this.btn_LoadDrivers.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LoadDrivers.Name = "btn_LoadDrivers";
            this.btn_LoadDrivers.Size = new System.Drawing.Size(133, 33);
            this.btn_LoadDrivers.TabIndex = 2;
            this.btn_LoadDrivers.Text = "Load Drivers ";
            this.btn_LoadDrivers.UseVisualStyleBackColor = true;
            this.btn_LoadDrivers.Click += new System.EventHandler(this.btn_LoadDrivers_Click);
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
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Location = new System.Drawing.Point(484, 355);
            this.btn_SaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(208, 28);
            this.btn_SaveChanges.TabIndex = 4;
            this.btn_SaveChanges.Text = "Save Changes to Database";
            this.btn_SaveChanges.UseVisualStyleBackColor = true;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // Form_DriverManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_SaveChanges);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_LoadDrivers);
            this.Controls.Add(this.txt_SearchLocation);
            this.Controls.Add(this.Location_label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_DriverManagement";
            this.Text = "Form_DriverManagement";
            this.Load += new System.EventHandler(this.Form_DriverManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Location_label;
        private System.Windows.Forms.TextBox txt_SearchLocation;
        private System.Windows.Forms.Button btn_LoadDrivers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_SaveChanges;
    }
}