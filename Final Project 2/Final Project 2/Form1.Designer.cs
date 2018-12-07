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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.SLY1.Location = new System.Drawing.Point(551, 76);
            this.SLY1.Name = "SLY1";
            this.SLY1.Size = new System.Drawing.Size(83, 20);
            this.SLY1.TabIndex = 2;
            this.SLY1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // SLYD
            // 
            this.SLYD.Location = new System.Drawing.Point(551, 41);
            this.SLYD.Name = "SLYD";
            this.SLYD.ReadOnly = true;
            this.SLYD.Size = new System.Drawing.Size(83, 20);
            this.SLYD.TabIndex = 3;
            this.SLYD.Text = "Sold Last Year";
            // 
            // STY1
            // 
            this.STY1.Location = new System.Drawing.Point(454, 76);
            this.STY1.Name = "STY1";
            this.STY1.Size = new System.Drawing.Size(91, 20);
            this.STY1.TabIndex = 4;
            // 
            // STYD
            // 
            this.STYD.Location = new System.Drawing.Point(454, 41);
            this.STYD.Name = "STYD";
            this.STYD.ReadOnly = true;
            this.STYD.Size = new System.Drawing.Size(91, 20);
            this.STYD.TabIndex = 5;
            this.STYD.Text = "Sold This Year";
            // 
            // Stock1
            // 
            this.Stock1.Location = new System.Drawing.Point(384, 76);
            this.Stock1.Name = "Stock1";
            this.Stock1.Size = new System.Drawing.Size(64, 20);
            this.Stock1.TabIndex = 6;
            // 
            // StockD
            // 
            this.StockD.Location = new System.Drawing.Point(384, 41);
            this.StockD.Name = "StockD";
            this.StockD.ReadOnly = true;
            this.StockD.Size = new System.Drawing.Size(64, 20);
            this.StockD.TabIndex = 7;
            this.StockD.Text = "In Store";
            // 
            // Price1
            // 
            this.Price1.Location = new System.Drawing.Point(314, 76);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(64, 20);
            this.Price1.TabIndex = 8;
            // 
            // PriceD
            // 
            this.PriceD.Location = new System.Drawing.Point(314, 41);
            this.PriceD.Name = "PriceD";
            this.PriceD.ReadOnly = true;
            this.PriceD.Size = new System.Drawing.Size(64, 20);
            this.PriceD.TabIndex = 9;
            this.PriceD.Text = "Price";
            this.PriceD.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox9_MaskInputRejected);
            // 
            // Loc1
            // 
            this.Loc1.Location = new System.Drawing.Point(244, 76);
            this.Loc1.Name = "Loc1";
            this.Loc1.Size = new System.Drawing.Size(64, 20);
            this.Loc1.TabIndex = 10;
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(174, 76);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(64, 20);
            this.Name1.TabIndex = 11;
            // 
            // LocD
            // 
            this.LocD.Location = new System.Drawing.Point(244, 41);
            this.LocD.Name = "LocD";
            this.LocD.ReadOnly = true;
            this.LocD.Size = new System.Drawing.Size(64, 20);
            this.LocD.TabIndex = 12;
            this.LocD.Text = "Location";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(478, 10);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(640, 9);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 14;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // UpdateB
            // 
            this.UpdateB.Location = new System.Drawing.Point(559, 9);
            this.UpdateB.Name = "UpdateB";
            this.UpdateB.Size = new System.Drawing.Size(75, 23);
            this.UpdateB.TabIndex = 15;
            this.UpdateB.Text = "Update";
            this.UpdateB.UseVisualStyleBackColor = true;
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
            // 
            // StoreName1
            // 
            this.StoreName1.Location = new System.Drawing.Point(12, 76);
            this.StoreName1.Name = "StoreName1";
            this.StoreName1.Size = new System.Drawing.Size(64, 20);
            this.StoreName1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 245);
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
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
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
    }
}

