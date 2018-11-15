namespace Final_Project
{
    partial class Form1
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
            this.UPC = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.StoreName = new System.Windows.Forms.TextBox();
            this.Transfers = new System.Windows.Forms.TextBox();
            this.TotalSold = new System.Windows.Forms.TextBox();
            this.SoldLastYear = new System.Windows.Forms.TextBox();
            this.SoldThisYear = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.ItemNumber = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.TextBox();
            this.Location = new System.Windows.Forms.TextBox();
            this.Store1 = new System.Windows.Forms.TextBox();
            this.ItemNumber1 = new System.Windows.Forms.TextBox();
            this.Location1 = new System.Windows.Forms.TextBox();
            this.Department1 = new System.Windows.Forms.TextBox();
            this.Price1 = new System.Windows.Forms.TextBox();
            this.QIS1 = new System.Windows.Forms.TextBox();
            this.STY1 = new System.Windows.Forms.TextBox();
            this.SLY1 = new System.Windows.Forms.TextBox();
            this.TS1 = new System.Windows.Forms.TextBox();
            this.Transfers1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UPC
            // 
            this.UPC.Location = new System.Drawing.Point(12, 12);
            this.UPC.Name = "UPC";
            this.UPC.Size = new System.Drawing.Size(602, 20);
            this.UPC.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(620, 10);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(701, 9);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // StoreName
            // 
            this.StoreName.Location = new System.Drawing.Point(12, 48);
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            this.StoreName.Size = new System.Drawing.Size(101, 20);
            this.StoreName.TabIndex = 3;
            this.StoreName.Text = "Store Name";
            // 
            // Transfers
            // 
            this.Transfers.Location = new System.Drawing.Point(890, 48);
            this.Transfers.Name = "Transfers";
            this.Transfers.ReadOnly = true;
            this.Transfers.Size = new System.Drawing.Size(71, 20);
            this.Transfers.TabIndex = 4;
            this.Transfers.Text = "Transferring";
            // 
            // TotalSold
            // 
            this.TotalSold.Location = new System.Drawing.Point(758, 48);
            this.TotalSold.Name = "TotalSold";
            this.TotalSold.ReadOnly = true;
            this.TotalSold.Size = new System.Drawing.Size(126, 20);
            this.TotalSold.TabIndex = 5;
            this.TotalSold.Text = "Total Sold";
            // 
            // SoldLastYear
            // 
            this.SoldLastYear.Location = new System.Drawing.Point(668, 48);
            this.SoldLastYear.Name = "SoldLastYear";
            this.SoldLastYear.ReadOnly = true;
            this.SoldLastYear.Size = new System.Drawing.Size(84, 20);
            this.SoldLastYear.TabIndex = 6;
            this.SoldLastYear.Text = "Sold Last Year";
            // 
            // SoldThisYear
            // 
            this.SoldThisYear.Location = new System.Drawing.Point(569, 48);
            this.SoldThisYear.Name = "SoldThisYear";
            this.SoldThisYear.ReadOnly = true;
            this.SoldThisYear.Size = new System.Drawing.Size(90, 20);
            this.SoldThisYear.TabIndex = 7;
            this.SoldThisYear.Text = "Sold This Year";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(466, 48);
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Size = new System.Drawing.Size(97, 20);
            this.Quantity.TabIndex = 8;
            this.Quantity.Text = "Quantity In Store";
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // ItemNumber
            // 
            this.ItemNumber.Location = new System.Drawing.Point(119, 48);
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.ReadOnly = true;
            this.ItemNumber.Size = new System.Drawing.Size(93, 20);
            this.ItemNumber.TabIndex = 9;
            this.ItemNumber.Text = "Item Number";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(393, 48);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(67, 20);
            this.Price.TabIndex = 10;
            this.Price.Text = "Price";
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(295, 48);
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Size = new System.Drawing.Size(92, 20);
            this.Department.TabIndex = 11;
            this.Department.Text = "Department";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(218, 48);
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Size = new System.Drawing.Size(71, 20);
            this.Location.TabIndex = 12;
            this.Location.Text = "Location";
            // 
            // Store1
            // 
            this.Store1.Location = new System.Drawing.Point(12, 92);
            this.Store1.Name = "Store1";
            this.Store1.Size = new System.Drawing.Size(101, 20);
            this.Store1.TabIndex = 13;
            // 
            // ItemNumber1
            // 
            this.ItemNumber1.Location = new System.Drawing.Point(119, 92);
            this.ItemNumber1.Name = "ItemNumber1";
            this.ItemNumber1.Size = new System.Drawing.Size(93, 20);
            this.ItemNumber1.TabIndex = 14;
            this.ItemNumber1.TextChanged += new System.EventHandler(this.ItemNumber1_TextChanged);
            // 
            // Location1
            // 
            this.Location1.Location = new System.Drawing.Point(218, 92);
            this.Location1.Name = "Location1";
            this.Location1.Size = new System.Drawing.Size(71, 20);
            this.Location1.TabIndex = 15;
            // 
            // Department1
            // 
            this.Department1.Location = new System.Drawing.Point(295, 92);
            this.Department1.Name = "Department1";
            this.Department1.Size = new System.Drawing.Size(92, 20);
            this.Department1.TabIndex = 16;
            // 
            // Price1
            // 
            this.Price1.Location = new System.Drawing.Point(393, 92);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(67, 20);
            this.Price1.TabIndex = 17;
            // 
            // QIS1
            // 
            this.QIS1.Location = new System.Drawing.Point(466, 92);
            this.QIS1.Name = "QIS1";
            this.QIS1.Size = new System.Drawing.Size(97, 20);
            this.QIS1.TabIndex = 18;
            this.QIS1.TextChanged += new System.EventHandler(this.QIS1_TextChanged);
            // 
            // STY1
            // 
            this.STY1.Location = new System.Drawing.Point(569, 92);
            this.STY1.Name = "STY1";
            this.STY1.Size = new System.Drawing.Size(90, 20);
            this.STY1.TabIndex = 19;
            // 
            // SLY1
            // 
            this.SLY1.Location = new System.Drawing.Point(668, 92);
            this.SLY1.Name = "SLY1";
            this.SLY1.Size = new System.Drawing.Size(84, 20);
            this.SLY1.TabIndex = 20;
            // 
            // TS1
            // 
            this.TS1.Location = new System.Drawing.Point(758, 92);
            this.TS1.Name = "TS1";
            this.TS1.Size = new System.Drawing.Size(126, 20);
            this.TS1.TabIndex = 21;
            // 
            // Transfers1
            // 
            this.Transfers1.Location = new System.Drawing.Point(890, 92);
            this.Transfers1.Name = "Transfers1";
            this.Transfers1.Size = new System.Drawing.Size(71, 20);
            this.Transfers1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 830);
            this.Controls.Add(this.Transfers1);
            this.Controls.Add(this.TS1);
            this.Controls.Add(this.SLY1);
            this.Controls.Add(this.STY1);
            this.Controls.Add(this.QIS1);
            this.Controls.Add(this.Price1);
            this.Controls.Add(this.Department1);
            this.Controls.Add(this.Location1);
            this.Controls.Add(this.ItemNumber1);
            this.Controls.Add(this.Store1);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ItemNumber);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.SoldThisYear);
            this.Controls.Add(this.SoldLastYear);
            this.Controls.Add(this.TotalSold);
            this.Controls.Add(this.Transfers);
            this.Controls.Add(this.StoreName);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.UPC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UPC;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox StoreName;
        private System.Windows.Forms.TextBox Transfers;
        private System.Windows.Forms.TextBox TotalSold;
        private System.Windows.Forms.TextBox SoldLastYear;
        private System.Windows.Forms.TextBox SoldThisYear;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox ItemNumber;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.TextBox Store1;
        private System.Windows.Forms.TextBox ItemNumber1;
        private System.Windows.Forms.TextBox Location1;
        private System.Windows.Forms.TextBox Department1;
        private System.Windows.Forms.TextBox Price1;
        private System.Windows.Forms.TextBox QIS1;
        private System.Windows.Forms.TextBox STY1;
        private System.Windows.Forms.TextBox SLY1;
        private System.Windows.Forms.TextBox TS1;
        private System.Windows.Forms.TextBox Transfers1;
    }
}

