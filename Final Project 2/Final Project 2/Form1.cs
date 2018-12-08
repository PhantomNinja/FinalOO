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
        Auto_Item Auto = new Auto_Item();
        Hardware_Item Hardware = new Hardware_Item();
        Clothes_Item Clothes = new Clothes_Item();
        
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
            Auto.InStock = 2;
            Farm.Add(new Farm_Item());
            this.StoreName1.Text = Auto.InStock.ToString();
        }

        private void UpdateB_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

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
