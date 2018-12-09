namespace Final_Project_2
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
            this.UPCE = new System.Windows.Forms.TextBox();
            this.NameD = new System.Windows.Forms.MaskedTextBox();
            this.SLY1 = new System.Windows.Forms.MaskedTextBox();
            this.SLYD = new System.Windows.Forms.MaskedTextBox();
            this.STY1 = new System.Windows.Forms.MaskedTextBox();
            this.STYD = new System.Windows.Forms.MaskedTextBox();
            this.Stock1 = new System.Windows.Forms.MaskedTextBox();
            this.StockD = new System.Windows.Forms.MaskedTextBox();
            this.Price1 = new System.Windows.Forms.MaskedTextBox();
            this.PriceD = new System.Windows.Forms.MaskedTextBox();
            this.Loc1 = new System.Windows.Forms.MaskedTextBox();
            this.Name1 = new System.Windows.Forms.MaskedTextBox();
            this.LocD = new System.Windows.Forms.MaskedTextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.UpdateB = new System.Windows.Forms.Button();
            this.StoreNameD = new System.Windows.Forms.MaskedTextBox();
            this.StoreLocD = new System.Windows.Forms.MaskedTextBox();
            this.StoreLoc1 = new System.Windows.Forms.MaskedTextBox();
            this.StoreName1 = new System.Windows.Forms.MaskedTextBox();
            this.DepartmentD = new System.Windows.Forms.TextBox();
            this.Department1 = new System.Windows.Forms.TextBox();
            this.AddStock = new System.Windows.Forms.Button();
            this.Sold = new System.Windows.Forms.Button();
            this.NewYear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UPCE
            // 
            this.UPCE.Location = new System.Drawing.Point(12, 12);
            this.UPCE.Name = "UPCE";
            this.UPCE.Size = new System.Drawing.Size(363, 20);
            this.UPCE.TabIndex = 0;
            this.UPCE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NameD
            // 
            this.NameD.Location = new System.Drawing.Point(174, 41);
            this.NameD.Name = "NameD";
            this.NameD.ReadOnly = true;
            this.NameD.Size = new System.Drawing.Size(64, 20);
            this.NameD.TabIndex = 1;
            this.NameD.Text = "Name";
            this.NameD.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.NameD_MaskInputRejected);
            // 
            // SLY1
            // 
            this.SLY1.Location = new System.Drawing.Point(618, 76);
            this.SLY1.Name = "SLY1";
            this.SLY1.Size = new System.Drawing.Size(83, 20);
            this.SLY1.TabIndex = 2;
            this.SLY1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // SLYD
            // 
            this.SLYD.Location = new System.Drawing.Point(618, 41);
            this.SLYD.Name = "SLYD";
            this.SLYD.ReadOnly = true;
            this.SLYD.Size = new System.Drawing.Size(83, 20);
            this.SLYD.TabIndex = 3;
            this.SLYD.Text = "Sold Last Year";
            // 
            // STY1
            // 
            this.STY1.Location = new System.Drawing.Point(521, 76);
            this.STY1.Name = "STY1";
            this.STY1.Size = new System.Drawing.Size(91, 20);
            this.STY1.TabIndex = 4;
            this.STY1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.STY1_MaskInputRejected);
            // 
            // STYD
            // 
            this.STYD.Location = new System.Drawing.Point(521, 41);
            this.STYD.Name = "STYD";
            this.STYD.ReadOnly = true;
            this.STYD.Size = new System.Drawing.Size(91, 20);
            this.STYD.TabIndex = 5;
            this.STYD.Text = "Sold This Year";
            // 
            // Stock1
            // 
            this.Stock1.Location = new System.Drawing.Point(451, 76);
            this.Stock1.Name = "Stock1";
            this.Stock1.Size = new System.Drawing.Size(64, 20);
            this.Stock1.TabIndex = 6;
            this.Stock1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Stock1_MaskInputRejected);
            // 
            // StockD
            // 
            this.StockD.Location = new System.Drawing.Point(451, 41);
            this.StockD.Name = "StockD";
            this.StockD.ReadOnly = true;
            this.StockD.Size = new System.Drawing.Size(64, 20);
            this.StockD.TabIndex = 7;
            this.StockD.Text = "In Store";
            // 
            // Price1
            // 
            this.Price1.Location = new System.Drawing.Point(381, 76);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(64, 20);
            this.Price1.TabIndex = 8;
            this.Price1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Price1_MaskInputRejected);
            // 
            // PriceD
            // 
            this.PriceD.Location = new System.Drawing.Point(381, 41);
            this.PriceD.Name = "PriceD";
            this.PriceD.ReadOnly = true;
            this.PriceD.Size = new System.Drawing.Size(64, 20);
            this.PriceD.TabIndex = 9;
            this.PriceD.Text = "Price";
            this.PriceD.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox9_MaskInputRejected);
            // 
            // Loc1
            // 
            this.Loc1.Location = new System.Drawing.Point(311, 76);
            this.Loc1.Name = "Loc1";
            this.Loc1.Size = new System.Drawing.Size(64, 20);
            this.Loc1.TabIndex = 10;
            this.Loc1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Loc1_MaskInputRejected);
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(174, 76);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(64, 20);
            this.Name1.TabIndex = 11;
            this.Name1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Name1_MaskInputRejected);
            // 
            // LocD
            // 
            this.LocD.Location = new System.Drawing.Point(311, 41);
            this.LocD.Name = "LocD";
            this.LocD.ReadOnly = true;
            this.LocD.Size = new System.Drawing.Size(64, 20);
            this.LocD.TabIndex = 12;
            this.LocD.Text = "Location";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Red;
            this.Add.Location = new System.Drawing.Point(380, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 23);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Red;
            this.Search.Location = new System.Drawing.Point(543, 10);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 14;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // UpdateB
            // 
            this.UpdateB.BackColor = System.Drawing.Color.Red;
            this.UpdateB.Location = new System.Drawing.Point(462, 12);
            this.UpdateB.Name = "UpdateB";
            this.UpdateB.Size = new System.Drawing.Size(75, 23);
            this.UpdateB.TabIndex = 15;
            this.UpdateB.Text = "Update";
            this.UpdateB.UseVisualStyleBackColor = false;
            this.UpdateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // StoreNameD
            // 
            this.StoreNameD.Location = new System.Drawing.Point(12, 41);
            this.StoreNameD.Name = "StoreNameD";
            this.StoreNameD.ReadOnly = true;
            this.StoreNameD.Size = new System.Drawing.Size(64, 20);
            this.StoreNameD.TabIndex = 16;
            this.StoreNameD.Text = "Store Name";
            // 
            // StoreLocD
            // 
            this.StoreLocD.Location = new System.Drawing.Point(82, 41);
            this.StoreLocD.Name = "StoreLocD";
            this.StoreLocD.ReadOnly = true;
            this.StoreLocD.Size = new System.Drawing.Size(86, 20);
            this.StoreLocD.TabIndex = 17;
            this.StoreLocD.Text = "Store Location";
            // 
            // StoreLoc1
            // 
            this.StoreLoc1.Location = new System.Drawing.Point(82, 76);
            this.StoreLoc1.Name = "StoreLoc1";
            this.StoreLoc1.Size = new System.Drawing.Size(86, 20);
            this.StoreLoc1.TabIndex = 18;
            this.StoreLoc1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.StoreLoc1_MaskInputRejected);
            // 
            // StoreName1
            // 
            this.StoreName1.Location = new System.Drawing.Point(12, 76);
            this.StoreName1.Name = "StoreName1";
            this.StoreName1.Size = new System.Drawing.Size(64, 20);
            this.StoreName1.TabIndex = 19;
            this.StoreName1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.StoreName1_MaskInputRejected);
            // 
            // DepartmentD
            // 
            this.DepartmentD.Location = new System.Drawing.Point(244, 41);
            this.DepartmentD.Name = "DepartmentD";
            this.DepartmentD.ReadOnly = true;
            this.DepartmentD.Size = new System.Drawing.Size(61, 20);
            this.DepartmentD.TabIndex = 20;
            this.DepartmentD.Text = "Department";
            // 
            // Department1
            // 
            this.Department1.Location = new System.Drawing.Point(244, 76);
            this.Department1.Name = "Department1";
            this.Department1.Size = new System.Drawing.Size(61, 20);
            this.Department1.TabIndex = 21;
            // 
            // AddStock
            // 
            this.AddStock.BackColor = System.Drawing.Color.Red;
            this.AddStock.Location = new System.Drawing.Point(626, 10);
            this.AddStock.Name = "AddStock";
            this.AddStock.Size = new System.Drawing.Size(75, 23);
            this.AddStock.TabIndex = 22;
            this.AddStock.Text = "Add Stock";
            this.AddStock.UseVisualStyleBackColor = false;
            this.AddStock.Click += new System.EventHandler(this.AddStock_Click);
            // 
            // Sold
            // 
            this.Sold.BackColor = System.Drawing.Color.Red;
            this.Sold.Location = new System.Drawing.Point(707, 9);
            this.Sold.Name = "Sold";
            this.Sold.Size = new System.Drawing.Size(75, 23);
            this.Sold.TabIndex = 23;
            this.Sold.Text = "Sold Stock";
            this.Sold.UseVisualStyleBackColor = false;
            this.Sold.Click += new System.EventHandler(this.Sold_Click);
            // 
            // NewYear
            // 
            this.NewYear.Location = new System.Drawing.Point(788, 9);
            this.NewYear.Name = "NewYear";
            this.NewYear.Size = new System.Drawing.Size(75, 23);
            this.NewYear.TabIndex = 24;
            this.NewYear.Text = "New Year";
            this.NewYear.UseVisualStyleBackColor = true;
            this.NewYear.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 160);
            this.Controls.Add(this.NewYear);
            this.Controls.Add(this.Sold);
            this.Controls.Add(this.AddStock);
            this.Controls.Add(this.Department1);
            this.Controls.Add(this.DepartmentD);
            this.Controls.Add(this.StoreName1);
            this.Controls.Add(this.StoreLoc1);
            this.Controls.Add(this.StoreLocD);
            this.Controls.Add(this.StoreNameD);
            this.Controls.Add(this.UpdateB);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.LocD);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.Loc1);
            this.Controls.Add(this.PriceD);
            this.Controls.Add(this.Price1);
            this.Controls.Add(this.StockD);
            this.Controls.Add(this.Stock1);
            this.Controls.Add(this.STYD);
            this.Controls.Add(this.STY1);
            this.Controls.Add(this.SLYD);
            this.Controls.Add(this.SLY1);
            this.Controls.Add(this.NameD);
            this.Controls.Add(this.UPCE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UPCE;
        private System.Windows.Forms.MaskedTextBox NameD;
        private System.Windows.Forms.MaskedTextBox SLY1;
        private System.Windows.Forms.MaskedTextBox SLYD;
        private System.Windows.Forms.MaskedTextBox STY1;
        private System.Windows.Forms.MaskedTextBox STYD;
        private System.Windows.Forms.MaskedTextBox Stock1;
        private System.Windows.Forms.MaskedTextBox StockD;
        private System.Windows.Forms.MaskedTextBox Price1;
        private System.Windows.Forms.MaskedTextBox PriceD;
        private System.Windows.Forms.MaskedTextBox Loc1;
        private System.Windows.Forms.MaskedTextBox Name1;
        private System.Windows.Forms.MaskedTextBox LocD;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button UpdateB;
        private System.Windows.Forms.MaskedTextBox StoreNameD;
        private System.Windows.Forms.MaskedTextBox StoreLocD;
        private System.Windows.Forms.MaskedTextBox StoreLoc1;
        private System.Windows.Forms.MaskedTextBox StoreName1;
        private System.Windows.Forms.TextBox DepartmentD;
        private System.Windows.Forms.TextBox Department1;
        private System.Windows.Forms.Button AddStock;
        private System.Windows.Forms.Button Sold;
        private System.Windows.Forms.Button NewYear;
    }
}

