using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;

namespace Final_Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int track;
        string trackd;
        Store one = new Store();
        List<Farm_Item> Farm = new List<Farm_Item>();
        List<Auto_Item> Auto = new List<Auto_Item>();
        List<Hardware_Item> Hardware = new List<Hardware_Item>();
        List<Clothes_Item> Clothes = new List<Clothes_Item>();        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void NameD_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        { 
            int q = 0;
            if(this.Department1.Text == "Auto")
            {
                for(int i = 0; i < Auto.Count; i++)
                {
                    if(Auto[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                for (int i = 0; i < Farm.Count; i++)
                {
                    if (Farm[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                for (int i = 0; i < Clothes.Count; i++)
                {
                    if (Clothes[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                for (int i = 0; i < Hardware.Count; i++)
                {
                    if (Hardware[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                if (q == 0)
                {
                    Auto.Add(new Auto_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                    track = Auto[Auto.Count - 1].Upc;
                    trackd = "Auto";
                }
            }
            else if (this.Department1.Text == "Farm")
            {
                for(int i = 0; i < Farm.Count; i++)
                {
                    if(Farm[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                for (int i = 0; i < Auto.Count; i++)
                {
                    if (Auto[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                for (int i = 0; i < Clothes.Count; i++)
                {
                    if (Clothes[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                for (int i = 0; i < Hardware.Count; i++)
                {
                    if (Hardware[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                if (q == 0)
                {
                    Farm.Add(new Farm_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                    track = Farm[Farm.Count - 1].Upc;
                    trackd = "Farm";
                }
            }
            else if (this.Department1.Text == "Clothes")
            {
                for(int i = 0; i < Clothes.Count; i++)
                {
                    if (Clothes[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                for (int i = 0; i < Auto.Count; i++)
                {
                    if (Auto[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                for (int i = 0; i < Farm.Count; i++)
                {
                    if (Farm[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                for (int i = 0; i < Hardware.Count; i++)
                {
                    if (Hardware[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                if (q == 0)
                {
                    Clothes.Add(new Clothes_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                    track = Clothes[Clothes.Count - 1].Upc;
                    trackd = "Clothes";
                }
            }
            else if (this.Department1.Text == "Hardware")
            {
                for(int i = 0; i < Hardware.Count; i++)
                {
                    if (Hardware[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                for (int i = 0; i < Auto.Count; i++)
                {
                    if (Auto[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                for (int i = 0; i < Farm.Count; i++)
                {
                    if (Farm[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                for (int i = 0; i < Hardware.Count; i++)
                {
                    if (Hardware[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                    }
                }
                if (q == 0)
                {
                    Hardware.Add(new Hardware_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                    track = Hardware[Hardware.Count - 1].Upc;
                    trackd = "Hardware";
                }
            }
        }

        private void UpdateB_Click(object sender, EventArgs e)
        {
            if(trackd == "Auto")
            {
                for(int i = 0; i < Auto.Count; i++)
                    if(Auto[i].Upc == track)
                    {
                        if (this.Department1.Text == "Auto")
                        {
                            Auto[i].Upc = int.Parse(this.UPCE.Text);
                            Auto[i].Name = this.Name1.Text;
                            Auto[i].Location = this.Loc1.Text;
                            Auto[i].Price = double.Parse(this.Price1.Text);
                            Auto[i].InStock = int.Parse(this.Stock1.Text);
                            Auto[i].STY = int.Parse(this.STY1.Text);
                            Auto[i].SLY = int.Parse(this.SLY1.Text);
                        }
                        else if(this.Department1.Text == "Farm")
                        {
                            Auto.RemoveAt(i);
                            Farm.Add(new Farm_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                        }
                        else if(this.Department1.Text == "Clothes")
                        {
                            Auto.RemoveAt(i);
                            Clothes.Add(new Clothes_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                        }
                        else if(this.Department1.Text == "Hardware")
                        {
                            Auto.RemoveAt(i);
                            Hardware.Add(new Hardware_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                        }
                    }
            }
            if (trackd == "Farm")
            {
                for (int i = 0; i < Farm.Count; i++)
                    if (Farm[i].Upc == track)
                    {
                        if (this.Department1.Text == "Farm")
                        {
                            Farm[i].Upc = int.Parse(this.UPCE.Text);
                            Farm[i].Name = this.Name1.Text;
                            Farm[i].Location = this.Loc1.Text;
                            Farm[i].Price = double.Parse(this.Price1.Text);
                            Farm[i].InStock = int.Parse(this.Stock1.Text);
                            Farm[i].STY = int.Parse(this.STY1.Text);
                            Farm[i].SLY = int.Parse(this.SLY1.Text);
                        }
                        else if (this.Department1.Text == "Auto")
                        {
                            Farm.RemoveAt(i);
                            Auto.Add(new Auto_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                        }
                        else if (this.Department1.Text == "Clothes")
                        {
                            Farm.RemoveAt(i);
                            Clothes.Add(new Clothes_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                        }
                        else if (this.Department1.Text == "Hardware")
                        {
                            Farm.RemoveAt(i);
                            Hardware.Add(new Hardware_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                        }
                    }
            }
            if (trackd == "Clothes")
            {
                for (int i = 0; i < Clothes.Count; i++)
                    if (Clothes[i].Upc == track)
                    {
                        if (this.Department1.Text == "Clothes")
                        {
                            Clothes[i].Upc = int.Parse(this.UPCE.Text);
                            Clothes[i].Name = this.Name1.Text;
                            Clothes[i].Location = this.Loc1.Text;
                            Clothes[i].Price = double.Parse(this.Price1.Text);
                            Clothes[i].InStock = int.Parse(this.Stock1.Text);
                            Clothes[i].STY = int.Parse(this.STY1.Text);
                            Clothes[i].SLY = int.Parse(this.SLY1.Text);
                        }
                        else if (this.Department1.Text == "Farm")
                        {
                            Clothes.RemoveAt(i);
                            Farm.Add(new Farm_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                        }
                        else if (this.Department1.Text == "Auto")
                        {
                            Clothes.RemoveAt(i);
                            Auto.Add(new Auto_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                        }
                        else if (this.Department1.Text == "Hardware")
                        {
                            Clothes.RemoveAt(i);
                            Hardware.Add(new Hardware_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                        }
                    }
            }
            if (trackd == "Hardware")
            {
                for (int i = 0; i < Hardware.Count; i++)
                    if (Hardware[i].Upc == track)
                    {
                        if (this.Department1.Text == "Hardware")
                        {
                            Hardware[i].Upc = int.Parse(this.UPCE.Text);
                            Hardware[i].Name = this.Name1.Text;
                            Hardware[i].Location = this.Loc1.Text;
                            Hardware[i].Price = double.Parse(this.Price1.Text);
                            Hardware[i].InStock = int.Parse(this.Stock1.Text);
                            Hardware[i].STY = int.Parse(this.STY1.Text);
                            Hardware[i].SLY = int.Parse(this.SLY1.Text);
                        }
                        else if (this.Department1.Text == "Farm")
                        {
                            Hardware.RemoveAt(i);
                            Farm.Add(new Farm_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                        }
                        else if (this.Department1.Text == "Clothes")
                        {
                            Hardware.RemoveAt(i);
                            Clothes.Add(new Clothes_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                        }
                        else if (this.Department1.Text == "Auto")
                        {
                            Hardware.RemoveAt(i);
                            Auto.Add(new Auto_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
                        }
                    }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            int q = 0;
            for (int i = 0; i < Auto.Count; i++)
            {
                if(Auto[i].Upc == int.Parse(this.UPCE.Text)) {
                    q = 1;
                    track = Auto[i].Upc;
                    trackd = "Auto";
                    this.StoreName1.Text = one.Name;
                    this.StoreLoc1.Text = one.Location;
                    this.Name1.Text = Auto[i].Name;
                    this.Loc1.Text = Auto[i].PrintLocation();
                    this.Price1.Text = Auto[i].Price.ToString();
                    this.Stock1.Text = Auto[i].InStock.ToString();
                    this.STY1.Text = Auto[i].STY.ToString();
                    this.SLY1.Text = Auto[i].SLY.ToString();
                    this.Department1.Text = "Auto";
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Farm.Count; i++)
                {
                    if (Farm[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        track = Farm[i].Upc;
                        trackd = "Farm";
                        this.StoreName1.Text = one.Name;
                        this.StoreLoc1.Text = one.Location;
                        this.Name1.Text = Farm[i].Name;
                        this.Loc1.Text = Farm[i].PrintLocation();
                        this.Price1.Text = Farm[i].Price.ToString();
                        this.Stock1.Text = Farm[i].InStock.ToString();
                        this.STY1.Text = Farm[i].STY.ToString();
                        this.SLY1.Text = Farm[i].SLY.ToString();
                        this.Department1.Text = "Farm";
                    }
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Clothes.Count; i++)
                {
                    if (Clothes[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        track = Clothes[i].Upc;
                        trackd = "Clothes";
                        this.StoreName1.Text = one.Name;
                        this.StoreLoc1.Text = one.Location;
                        this.Name1.Text = Clothes[i].Name;
                        this.Loc1.Text = Clothes[i].PrintLocation();
                        this.Price1.Text = Clothes[i].Price.ToString();
                        this.Stock1.Text = Clothes[i].InStock.ToString();
                        this.STY1.Text = Clothes[i].STY.ToString();
                        this.SLY1.Text = Clothes[i].SLY.ToString();
                        this.Department1.Text = "Clothes";
                    }
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Hardware.Count; i++)
                {
                    if (Hardware[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        track = Hardware[i].Upc;
                        trackd = "Hardware";
                        this.StoreName1.Text = one.Name;
                        this.StoreLoc1.Text = one.Location;
                        this.Name1.Text = Hardware[i].Name;
                        this.Loc1.Text = Hardware[i].PrintLocation();
                        this.Price1.Text = Hardware[i].Price.ToString();
                        this.Stock1.Text = Hardware[i].InStock.ToString();
                        this.STY1.Text = Hardware[i].STY.ToString();
                        this.SLY1.Text = Hardware[i].SLY.ToString();
                        this.Department1.Text = "Hardware";
                    }
                }
            }
        }

        private void STY1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Stock1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Price1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Loc1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Name1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void StoreLoc1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void StoreName1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int q = 0;
            for (int i = 0; i < Auto.Count; i++)
            {
                if (Auto[i].Upc == int.Parse(this.UPCE.Text))
                {
                    q = 1;
                    track = i;
                    trackd = "Auto";
                    this.StoreName1.Text = one.Name;
                    this.StoreLoc1.Text = one.Location;
                    this.Name1.Text = Auto[i].Name;
                    this.Loc1.Text = Auto[i].PrintLocation();
                    this.Price1.Text = Auto[i].Price.ToString();
                    Auto[i].NewYear();
                    this.Stock1.Text = Auto[i].InStock.ToString();
                    this.STY1.Text = Auto[i].STY.ToString();
                    this.SLY1.Text = Auto[i].SLY.ToString();
                    this.Department1.Text = "Auto";
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Farm.Count; i++)
                {
                    if (Farm[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        track = i;
                        trackd = "Farm";
                        this.StoreName1.Text = one.Name;
                        this.StoreLoc1.Text = one.Location;
                        this.Name1.Text = Farm[i].Name;
                        this.Loc1.Text = Farm[i].PrintLocation();
                        this.Price1.Text = Farm[i].Price.ToString();
                        Farm[i].NewYear();
                        this.Stock1.Text = Farm[i].InStock.ToString();
                        this.STY1.Text = Farm[i].STY.ToString();
                        this.SLY1.Text = Farm[i].SLY.ToString();
                        this.Department1.Text = "Farm";
                    }
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Clothes.Count; i++)
                {
                    if (Clothes[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        track = i;
                        trackd = "Clothes";
                        this.StoreName1.Text = one.Name;
                        this.StoreLoc1.Text = one.Location;
                        this.Name1.Text = Clothes[i].Name;
                        this.Loc1.Text = Clothes[i].PrintLocation();
                        this.Price1.Text = Clothes[i].Price.ToString();
                        Clothes[i].NewYear();
                        this.Stock1.Text = Clothes[i].InStock.ToString();
                        this.STY1.Text = Clothes[i].STY.ToString();
                        this.SLY1.Text = Clothes[i].SLY.ToString();
                        this.Department1.Text = "Clothes";
                    }
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Hardware.Count; i++)
                {
                    if (Hardware[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        track = i;
                        trackd = "Hardware";
                        this.StoreName1.Text = one.Name;
                        this.StoreLoc1.Text = one.Location;
                        this.Name1.Text = Hardware[i].Name;
                        this.Loc1.Text = Hardware[i].PrintLocation();
                        this.Price1.Text = Hardware[i].Price.ToString();
                        Hardware[i].NewYear();
                        this.Stock1.Text = Hardware[i].InStock.ToString();
                        this.STY1.Text = Hardware[i].STY.ToString();
                        this.SLY1.Text = Hardware[i].SLY.ToString();
                        this.Department1.Text = "Hardware";
                    }
                }
            }
        }

        private void Sold_Click(object sender, EventArgs e)
        {
            int q = 0;
            for (int i = 0; i < Auto.Count; i++)
            {
                if (Auto[i].Upc == int.Parse(this.UPCE.Text))
                {
                    q = 1;
                    track = i;
                    trackd = "Auto";
                    this.StoreName1.Text = one.Name;
                    this.StoreLoc1.Text = one.Location;
                    this.Name1.Text = Auto[i].Name;
                    this.Loc1.Text = Auto[i].PrintLocation();
                    this.Price1.Text = Auto[i].Price.ToString();
                    Auto[i].UpdateStock(1);
                    this.Stock1.Text = Auto[i].InStock.ToString();
                    this.STY1.Text = Auto[i].STY.ToString();
                    this.SLY1.Text = Auto[i].SLY.ToString();
                    this.Department1.Text = "Auto";
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Farm.Count; i++)
                {
                    if (Farm[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        track = i;
                        trackd = "Farm";
                        this.StoreName1.Text = one.Name;
                        this.StoreLoc1.Text = one.Location;
                        this.Name1.Text = Farm[i].Name;
                        this.Loc1.Text = Farm[i].PrintLocation();
                        this.Price1.Text = Farm[i].Price.ToString();
                        Farm[i].UpdateStock(1);
                        this.Stock1.Text = Farm[i].InStock.ToString();
                        this.STY1.Text = Farm[i].STY.ToString();
                        this.SLY1.Text = Farm[i].SLY.ToString();
                        this.Department1.Text = "Farm";
                    }
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Clothes.Count; i++)
                {
                    if (Clothes[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        track = i;
                        trackd = "Clothes";
                        this.StoreName1.Text = one.Name;
                        this.StoreLoc1.Text = one.Location;
                        this.Name1.Text = Clothes[i].Name;
                        this.Loc1.Text = Clothes[i].PrintLocation();
                        this.Price1.Text = Clothes[i].Price.ToString();
                        Clothes[i].UpdateStock(1);
                        this.Stock1.Text = Clothes[i].InStock.ToString();
                        this.STY1.Text = Clothes[i].STY.ToString();
                        this.SLY1.Text = Clothes[i].SLY.ToString();
                        this.Department1.Text = "Clothes";
                    }
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Hardware.Count; i++)
                {
                    if (Hardware[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        track = i;
                        trackd = "Hardware";
                        this.StoreName1.Text = one.Name;
                        this.StoreLoc1.Text = one.Location;
                        this.Name1.Text = Hardware[i].Name;
                        this.Loc1.Text = Hardware[i].PrintLocation();
                        this.Price1.Text = Hardware[i].Price.ToString();
                        Hardware[i].UpdateStock(1);
                        this.Stock1.Text = Hardware[i].InStock.ToString();
                        this.STY1.Text = Hardware[i].STY.ToString();
                        this.SLY1.Text = Hardware[i].SLY.ToString();
                        this.Department1.Text = "Hardware";
                    }
                }
            }
        }

        private void AddStock_Click(object sender, EventArgs e)
        {
            int q = 0;
            for (int i = 0; i < Auto.Count; i++)
            {
                if (Auto[i].Upc == int.Parse(this.UPCE.Text))
                {
                    q = 1;
                    track = i;
                    trackd = "Auto";
                    this.StoreName1.Text = one.Name;
                    this.StoreLoc1.Text = one.Location;
                    this.Name1.Text = Auto[i].Name;
                    this.Loc1.Text = Auto[i].PrintLocation();
                    this.Price1.Text = Auto[i].Price.ToString();
                    Auto[i].InStock++;
                    this.Stock1.Text = Auto[i].InStock.ToString();
                    this.STY1.Text = Auto[i].STY.ToString();
                    this.SLY1.Text = Auto[i].SLY.ToString();
                    this.Department1.Text = "Auto";
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Farm.Count; i++)
                {
                    if (Farm[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        track = i;
                        trackd = "Farm";
                        this.StoreName1.Text = one.Name;
                        this.StoreLoc1.Text = one.Location;
                        this.Name1.Text = Farm[i].Name;
                        this.Loc1.Text = Farm[i].PrintLocation();
                        this.Price1.Text = Farm[i].Price.ToString();
                        Farm[i].InStock++;
                        this.Stock1.Text = Farm[i].InStock.ToString();
                        this.STY1.Text = Farm[i].STY.ToString();
                        this.SLY1.Text = Farm[i].SLY.ToString();
                        this.Department1.Text = "Farm";
                    }
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Clothes.Count; i++)
                {
                    if (Clothes[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        track = i;
                        trackd = "Clothes";
                        this.StoreName1.Text = one.Name;
                        this.StoreLoc1.Text = one.Location;
                        this.Name1.Text = Clothes[i].Name;
                        this.Loc1.Text = Clothes[i].PrintLocation();
                        this.Price1.Text = Clothes[i].Price.ToString();
                        Clothes[i].InStock++;
                        this.Stock1.Text = Clothes[i].InStock.ToString();
                        this.STY1.Text = Clothes[i].STY.ToString();
                        this.SLY1.Text = Clothes[i].SLY.ToString();
                        this.Department1.Text = "Clothes";
                    }
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Hardware.Count; i++)
                {
                    if (Hardware[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        track = i;
                        trackd = "Hardware";
                        this.StoreName1.Text = one.Name;
                        this.StoreLoc1.Text = one.Location;
                        this.Name1.Text = Hardware[i].Name;
                        this.Loc1.Text = Hardware[i].PrintLocation();
                        this.Price1.Text = Hardware[i].Price.ToString();
                        Hardware[i].InStock++;
                        this.Stock1.Text = Hardware[i].InStock.ToString();
                        this.STY1.Text = Hardware[i].STY.ToString();
                        this.SLY1.Text = Hardware[i].SLY.ToString();
                        this.Department1.Text = "Hardware";
                    }
                }
            }
        }
    }
}
