using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }



        private void button15_Click_1(object sender, EventArgs e)
        {

        }
       
        int seans1 = 0;
        int seansqiymet = 0;
        int yer = 0;

        private void button15_Click(object sender, EventArgs e)
        {
            seans1++;
            seansqiymet = seansqiymet + 7;
            
            textBox2.Text = seansqiymet.ToString();
            if (seans1 == 30)
            {
                button15.Enabled = false;
                
            }


        }

        private void button24_Click(object sender, EventArgs e)
        {
            seans1--;
            seansqiymet = seansqiymet - 7;
            
            textBox2.Text = seansqiymet.ToString();
        
          if (seans1 <= 0)
            {
                button15.Enabled = true;
            }
      
        }      

    private void button16_Click(object sender, EventArgs e)
        {
            seans1++;
            seansqiymet = seansqiymet + 7;
            
            textBox3.Text = seansqiymet.ToString();
            if (seans1 == 25)
            {
                button16.Enabled = false;

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            seans1--;
            seansqiymet = seansqiymet - 7;
           
            textBox3.Text = seansqiymet.ToString();
            if (seans1 <= 25)
            {
                button16.Enabled = true;
                if (seans1 == 0)
                {
                    button16.Enabled = false;
                }
                
            }
           
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            seans1++;
            seansqiymet = seansqiymet + 8;
           
            textBox6.Text = seansqiymet.ToString();
            if (seans1 == 20)
            {
                button20.Enabled = false;
                if (seans1 >= 0)
                {
                    button20.Enabled = true;
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            seans1--;
            seansqiymet = seansqiymet - 9;
            
            textBox6.Text = seansqiymet.ToString();
            if (seans1 == 0)
            {
                button25.Enabled = true;
               
            }
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            seans1--;
            seansqiymet = seansqiymet - 7;
           
            textBox3.Text = seansqiymet.ToString();
            if (seans1 == 0)
            {
                button19.Enabled = true;
                if (seans1 == 0)
                {
                    button19.Enabled = false;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            seans1++;
            seansqiymet = seansqiymet + 9;
            textBox1.Text = seansqiymet.ToString();
            if (seans1 == 20)
            {
                button18.Enabled = false;
                if (seans1 >= 0)
                {
                    button18.Enabled = true;
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            seans1--;
            seansqiymet = seansqiymet - 9;
            textBox1.Text = seansqiymet.ToString();
            if (seans1 >= 0)
            {
                button18.Enabled = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            seans1++;
            seansqiymet = seansqiymet + 15;
            textBox4.Text = seansqiymet.ToString();
            if (seans1 == 15)
            {
                button17.Enabled = false;
                if (seans1 == 0)
                {
                    button25.Enabled = true;
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            seans1--;
            seansqiymet = seansqiymet - 15;
            textBox4.Text = seansqiymet.ToString();
            if (seans1 >= 0)
            {
                button27.Enabled = true;
                
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            seans1++;
            seansqiymet = seansqiymet + 10;
            textBox5.Text = seansqiymet.ToString();
            if (seans1 == 45)
            {
                button28.Enabled = false;
                if (seans1 >= 0)
                {
                    button28.Enabled = true;
                }
                
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            seans1--;
            seansqiymet = seansqiymet - 10;
            textBox5.Text = seansqiymet.ToString();
            if (seans1 >=0)
            {
                button29.Enabled = true;
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

           
            for (int i = 0; i < 30; i++)
            {
                button15.Enabled = true;
                if (yer == 30)
                { 
                    button15.Enabled = false;
                }
            }
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < 30; i++)
            {
                if (yer == 30)
                {
                    button15.Enabled = true ;
                }
                else
                {
                    button15.Enabled = false;
                }
            }
            int tb2 = Convert.ToInt32(textBox2.Text);
            textBox8.Text = Convert.ToString(tb2 / 7);
            
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
            {
                if (yer == 25)
                {
                    button16.Enabled = true;
                }
                else
                {
                    button16.Enabled = false;
                }
            }
            int tb14 = Convert.ToInt32(textBox14.Text);
            textBox3.Text = Convert.ToString(tb14 / 7);     
        }
    }
}
