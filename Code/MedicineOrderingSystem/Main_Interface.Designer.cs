namespace MedicineOrderingSystem
{
    partial class Main_Interface
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
            System.Windows.Forms.Button btn_Rep_Orders;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Conn_Track = new System.Windows.Forms.Button();
            this.btn_Conn_Med = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Disconn_Drivers = new System.Windows.Forms.Button();
            this.btn_Disconn_Patients = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ReportRefills = new System.Windows.Forms.Button();
            btn_Rep_Orders = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Rep_Orders
            // 
            btn_Rep_Orders.Location = new System.Drawing.Point(6, 50);
            btn_Rep_Orders.Name = "btn_Rep_Orders";
            btn_Rep_Orders.Size = new System.Drawing.Size(211, 23);
            btn_Rep_Orders.TabIndex = 7;
            btn_Rep_Orders.Text = "View Orders Report";
            btn_Rep_Orders.UseVisualStyleBackColor = true;
            btn_Rep_Orders.Click += new System.EventHandler(this.btn_Rep_Orders_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Conn_Track);
            this.groupBox1.Controls.Add(this.btn_Conn_Med);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Live Operations (Connected Mode)";
            // 
            // btn_Conn_Track
            // 
            this.btn_Conn_Track.Location = new System.Drawing.Point(6, 50);
            this.btn_Conn_Track.Name = "btn_Conn_Track";
            this.btn_Conn_Track.Size = new System.Drawing.Size(177, 23);
            this.btn_Conn_Track.TabIndex = 3;
            this.btn_Conn_Track.Text = "Track Patient Orders";
            this.btn_Conn_Track.UseVisualStyleBackColor = true;
            this.btn_Conn_Track.Click += new System.EventHandler(this.btn_Conn_Track_Click);
            // 
            // btn_Conn_Med
            // 
            this.btn_Conn_Med.Location = new System.Drawing.Point(6, 21);
            this.btn_Conn_Med.Name = "btn_Conn_Med";
            this.btn_Conn_Med.Size = new System.Drawing.Size(177, 23);
            this.btn_Conn_Med.TabIndex = 2;
            this.btn_Conn_Med.Text = "Manage Medications";
            this.btn_Conn_Med.UseVisualStyleBackColor = true;
            this.btn_Conn_Med.Click += new System.EventHandler(this.btn_Conn_Med_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Disconn_Drivers);
            this.groupBox2.Controls.Add(this.btn_Disconn_Patients);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Offline Management (Disconnected Mode)";
            // 
            // btn_Disconn_Drivers
            // 
            this.btn_Disconn_Drivers.Location = new System.Drawing.Point(6, 50);
            this.btn_Disconn_Drivers.Name = "btn_Disconn_Drivers";
            this.btn_Disconn_Drivers.Size = new System.Drawing.Size(231, 23);
            this.btn_Disconn_Drivers.TabIndex = 5;
            this.btn_Disconn_Drivers.Text = "Load and Update Drivers (Offline)";
            this.btn_Disconn_Drivers.UseVisualStyleBackColor = true;
            this.btn_Disconn_Drivers.Click += new System.EventHandler(this.btn_Disconn_Drivers_Click);
            // 
            // btn_Disconn_Patients
            // 
            this.btn_Disconn_Patients.Location = new System.Drawing.Point(6, 21);
            this.btn_Disconn_Patients.Name = "btn_Disconn_Patients";
            this.btn_Disconn_Patients.Size = new System.Drawing.Size(231, 23);
            this.btn_Disconn_Patients.TabIndex = 4;
            this.btn_Disconn_Patients.Text = "Register Patients (Offline)";
            this.btn_Disconn_Patients.UseVisualStyleBackColor = true;
            this.btn_Disconn_Patients.Click += new System.EventHandler(this.btn_Disconn_Patients_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(btn_Rep_Orders);
            this.groupBox3.Controls.Add(this.btn_ReportRefills);
            this.groupBox3.Location = new System.Drawing.Point(12, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 87);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "System Reports (Crystal Reports)";
            // 
            // btn_ReportRefills
            // 
            this.btn_ReportRefills.Location = new System.Drawing.Point(0, 21);
            this.btn_ReportRefills.Name = "btn_ReportRefills";
            this.btn_ReportRefills.Size = new System.Drawing.Size(217, 23);
            this.btn_ReportRefills.TabIndex = 6;
            this.btn_ReportRefills.Text = "View Patient Refills Report";
            this.btn_ReportRefills.UseVisualStyleBackColor = true;
            this.btn_ReportRefills.Click += new System.EventHandler(this.btn_ReportRefills_Click);
            // 
            // Main_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main_Interface";
            this.Text = "Main_Interface";
            this.Load += new System.EventHandler(this.Main_Interface_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Conn_Track;
        private System.Windows.Forms.Button btn_Conn_Med;
        private System.Windows.Forms.Button btn_Disconn_Drivers;
        private System.Windows.Forms.Button btn_Disconn_Patients;
        private System.Windows.Forms.Button btn_ReportRefills;
    }
}