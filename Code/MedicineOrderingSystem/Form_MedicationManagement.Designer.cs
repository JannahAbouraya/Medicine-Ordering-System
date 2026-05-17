namespace MedicineOrderingSystem
{
    partial class Form_MedicationManagement
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
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.cmb_SearchMed = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_NewMedName = new System.Windows.Forms.TextBox();
            this.txt_NewPrice = new System.Windows.Forms.TextBox();
            this.txt_NewReqPres = new System.Windows.Forms.TextBox();
            this.txt_NewStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            this.label1.Tag = "";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(69, 62);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 22);
            this.txt_Price.TabIndex = 3;
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(123, 94);
            this.txt_Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(100, 22);
            this.txt_Stock.TabIndex = 4;
            // 
            // cmb_SearchMed
            // 
            this.cmb_SearchMed.AccessibleName = "";
            this.cmb_SearchMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchMed.FormattingEnabled = true;
            this.cmb_SearchMed.Location = new System.Drawing.Point(188, 34);
            this.cmb_SearchMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_SearchMed.Name = "cmb_SearchMed";
            this.cmb_SearchMed.Size = new System.Drawing.Size(121, 24);
            this.cmb_SearchMed.TabIndex = 5;
            this.cmb_SearchMed.Tag = "";
            this.cmb_SearchMed.SelectedIndexChanged += new System.EventHandler(this.cmb_medicationSearch_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choose Medicine Name:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(123, 315);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(153, 23);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add New Medication";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_NewMedName
            // 
            this.txt_NewMedName.Location = new System.Drawing.Point(155, 202);
            this.txt_NewMedName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NewMedName.Name = "txt_NewMedName";
            this.txt_NewMedName.Size = new System.Drawing.Size(100, 22);
            this.txt_NewMedName.TabIndex = 10;
            // 
            // txt_NewPrice
            // 
            this.txt_NewPrice.Location = new System.Drawing.Point(155, 230);
            this.txt_NewPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NewPrice.Name = "txt_NewPrice";
            this.txt_NewPrice.Size = new System.Drawing.Size(100, 22);
            this.txt_NewPrice.TabIndex = 11;
            // 
            // txt_NewReqPres
            // 
            this.txt_NewReqPres.Location = new System.Drawing.Point(155, 258);
            this.txt_NewReqPres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NewReqPres.Name = "txt_NewReqPres";
            this.txt_NewReqPres.Size = new System.Drawing.Size(100, 22);
            this.txt_NewReqPres.TabIndex = 12;
            // 
            // txt_NewStock
            // 
            this.txt_NewStock.Location = new System.Drawing.Point(155, 289);
            this.txt_NewStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NewStock.Name = "txt_NewStock";
            this.txt_NewStock.Size = new System.Drawing.Size(100, 22);
            this.txt_NewStock.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = " Medication Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Requires Prescription?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Stock Quantity:";
            // 
            // Form_MedicationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NewStock);
            this.Controls.Add(this.txt_NewReqPres);
            this.Controls.Add(this.txt_NewPrice);
            this.Controls.Add(this.txt_NewMedName);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_SearchMed);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_MedicationManagement";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_MedicationManagement_FormClosing);
            this.Load += new System.EventHandler(this.Form_MedicationManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.ComboBox cmb_SearchMed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_NewMedName;
        private System.Windows.Forms.TextBox txt_NewPrice;
        private System.Windows.Forms.TextBox txt_NewReqPres;
        private System.Windows.Forms.TextBox txt_NewStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

