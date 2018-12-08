﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Final_Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
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
            if(this.Department1.Text == "Auto")
            {
                Auto.Add(new Auto_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
            }
            else if (this.Department1.Text == "Farm")
            {
                Farm.Add(new Farm_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
            }
            else if (this.Department1.Text == "Clothes")
            {
                Clothes.Add(new Clothes_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
            }
            else if (this.Department1.Text == "Hardware")
            {
                Hardware.Add(new Hardware_Item(int.Parse(this.UPCE.Text), this.Loc1.Text, double.Parse(this.Price1.Text), int.Parse(this.Stock1.Text), this.Name1.Text, int.Parse(this.SLY1.Text), int.Parse(this.STY1.Text)));
            }
        }

        private void UpdateB_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            int q = 0;
            for (int i = 0; i < Auto.Count; i++)
            {
                this.StoreName1.Text = one.Name;
                this.StoreLoc1.Text = one.Location;
                if(Auto[i].Upc == int.Parse(this.UPCE.Text)) {
                    q = 1;
                    this.Name1.Text = Auto[i].Name;
                    this.Loc1.Text = Auto[i].PrintLocation();
                    this.Price1.Text = Auto[i].Price.ToString();
                    this.Stock1.Text = Auto[i].InStock.ToString();
                    this.STY1.Text = Auto[i].STY.ToString();
                    this.SLY1.Text = Auto[i].SLY.ToString();
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Farm.Count; i++)
                {
                    if (Farm[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        this.Name1.Text = Farm[i].Name;
                        this.Loc1.Text = Farm[i].PrintLocation();
                        this.Price1.Text = Farm[i].Price.ToString();
                        this.Stock1.Text = Farm[i].InStock.ToString();
                        this.STY1.Text = Farm[i].STY.ToString();
                        this.SLY1.Text = Farm[i].SLY.ToString();
                    }
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Farm.Count; i++)
                {
                    if (Clothes[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        this.Name1.Text = Clothes[i].Name;
                        this.Loc1.Text = Clothes[i].PrintLocation();
                        this.Price1.Text = Clothes[i].Price.ToString();
                        this.Stock1.Text = Clothes[i].InStock.ToString();
                        this.STY1.Text = Clothes[i].STY.ToString();
                        this.SLY1.Text = Clothes[i].SLY.ToString();
                    }
                }
            }
            if (q == 0)
            {
                for (int i = 0; i < Farm.Count; i++)
                {
                    if (Hardware[i].Upc == int.Parse(this.UPCE.Text))
                    {
                        q = 1;
                        this.Name1.Text = Hardware[i].Name;
                        this.Loc1.Text = Hardware[i].PrintLocation();
                        this.Price1.Text = Hardware[i].Price.ToString();
                        this.Stock1.Text = Hardware[i].InStock.ToString();
                        this.STY1.Text = Hardware[i].STY.ToString();
                        this.SLY1.Text = Hardware[i].SLY.ToString();
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
    }
}
