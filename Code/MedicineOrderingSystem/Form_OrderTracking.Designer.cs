namespace MedicineOrderingSystem
{
    partial class Form_OrderTracking
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
            this.btn_TrackOrder = new System.Windows.Forms.Button();
            this.txt_OrderID = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.txt_DriverID = new System.Windows.Forms.TextBox();
            this.txt_Lat = new System.Windows.Forms.TextBox();
            this.txt_Lng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_DisplayOrderDetails = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_OrderDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_TrackOrder
            // 
            this.btn_TrackOrder.Location = new System.Drawing.Point(12, 40);
            this.btn_TrackOrder.Name = "btn_TrackOrder";
            this.btn_TrackOrder.Size = new System.Drawing.Size(147, 23);
            this.btn_TrackOrder.TabIndex = 0;
            this.btn_TrackOrder.Text = "Track Order";
            this.btn_TrackOrder.UseVisualStyleBackColor = true;
            this.btn_TrackOrder.Click += new System.EventHandler(this.btn_TrackOrder_Click);
            // 
            // txt_OrderID
            // 
            this.txt_OrderID.Location = new System.Drawing.Point(112, 9);
            this.txt_OrderID.Name = "txt_OrderID";
            this.txt_OrderID.Size = new System.Drawing.Size(100, 22);
            this.txt_OrderID.TabIndex = 1;
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(96, 69);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(100, 22);
            this.txt_Status.TabIndex = 2;
            // 
            // txt_DriverID
            // 
            this.txt_DriverID.Location = new System.Drawing.Point(96, 105);
            this.txt_DriverID.Name = "txt_DriverID";
            this.txt_DriverID.Size = new System.Drawing.Size(100, 22);
            this.txt_DriverID.TabIndex = 3;
            // 
            // txt_Lat
            // 
            this.txt_Lat.Location = new System.Drawing.Point(96, 146);
            this.txt_Lat.Name = "txt_Lat";
            this.txt_Lat.Size = new System.Drawing.Size(100, 22);
            this.txt_Lat.TabIndex = 4;
            // 
            // txt_Lng
            // 
            this.txt_Lng.Location = new System.Drawing.Point(96, 189);
            this.txt_Lng.Name = "txt_Lng";
            this.txt_Lng.Size = new System.Drawing.Size(100, 22);
            this.txt_Lng.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Driver ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Latitude:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Longitude:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter Order ID:";
            // 
            // btn_DisplayOrderDetails
            // 
            this.btn_DisplayOrderDetails.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_DisplayOrderDetails.Location = new System.Drawing.Point(177, 40);
            this.btn_DisplayOrderDetails.Name = "btn_DisplayOrderDetails";
            this.btn_DisplayOrderDetails.Size = new System.Drawing.Size(147, 23);
            this.btn_DisplayOrderDetails.TabIndex = 13;
            this.btn_DisplayOrderDetails.Text = "Display Order Details";
            this.btn_DisplayOrderDetails.UseVisualStyleBackColor = true;
            this.btn_DisplayOrderDetails.Click += new System.EventHandler(this.btn_DisplayOrderDetails_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Order Details:";
            // 
            // txt_OrderDetails
            // 
            this.txt_OrderDetails.Location = new System.Drawing.Point(310, 72);
            this.txt_OrderDetails.Multiline = true;
            this.txt_OrderDetails.Name = "txt_OrderDetails";
            this.txt_OrderDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_OrderDetails.Size = new System.Drawing.Size(478, 134);
            this.txt_OrderDetails.TabIndex = 16;
            // 
            // Form_OrderTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_OrderDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_DisplayOrderDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Lng);
            this.Controls.Add(this.txt_Lat);
            this.Controls.Add(this.txt_DriverID);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_OrderID);
            this.Controls.Add(this.btn_TrackOrder);
            this.Name = "Form_OrderTracking";
            this.Text = "Form_OrderTracking";
            this.Load += new System.EventHandler(this.Form_OrderTracking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TrackOrder;
        private System.Windows.Forms.TextBox txt_OrderID;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox txt_DriverID;
        private System.Windows.Forms.TextBox txt_Lat;
        private System.Windows.Forms.TextBox txt_Lng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_DisplayOrderDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_OrderDetails;
    }
}