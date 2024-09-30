using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcultorTask1
{
    public partial class Form1 : Form
    {
        String[] arr = new string[10];
        int var1;
        int var2;
        int var_sign= 0 ;
        int var_Sign2 = 0;
        int count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TXtDisplay.Text += "4";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TXtDisplay.Text += "7";


        }

        private void button9_Click(object sender, EventArgs e)
        {
            TXtDisplay.Text += "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            var_Sign2=var_sign;

            var_sign = 1;
            

            AddMothods x = new AddMothods();
            int result = 0;

            if (count == 0)
            {
                var1 = Convert.ToInt32(TXtDisplay.Text);
            }
            else
            {
                result = x.calculte_Math(var1, Convert.ToInt32(TXtDisplay.Text), var_Sign2);
                var1 = result;

            }
            TXtDisplay.Text = "";
            //var1 = result;

            count++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //var1 = Convert.ToInt32(TXtDisplay.Text);
            AddMothods x = new AddMothods();
            var_Sign2=var_sign;

            var_sign = 3;
            int result = 0;

            if (count == 0)
            {
                var1 = Convert.ToInt32(TXtDisplay.Text);
            }
            else
            {
                result = x.calculte_Math(var1, Convert.ToInt32(TXtDisplay.Text), var_sign);
                var1 = result;

            }
            TXtDisplay.Text = "";

            //var_sign = 3;
            count++;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btn_14_Click(object sender, EventArgs e)
        {
           // var2 = Convert.ToInt32(TXtDisplay.Text);
            int Result = 0;
            /*if (var_sign == 1)
            {
                Result = var1 + var2;
            }else if(var_sign == 2) 
            {
                Result=var2 - var1;
            }else if(var_sign == 3) 
            {
               Result = var1 * var2;
            }else if (var_sign == 4)
            {
                Result=(var2 /var1);
            }*/
            AddMothods x = new AddMothods();

            Result = x.calculte_Math(var1, Convert.ToInt32(TXtDisplay.Text), var_sign);
            Console.WriteLine(Result);

            TXtDisplay.Text=Result.ToString();

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            TXtDisplay.Text += "2";
        }

        private void btn_1_Click_1(object sender, EventArgs e)
        {
            TXtDisplay.Text += "1";


        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            TXtDisplay.Text += "3";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            TXtDisplay.Text += "5";

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            TXtDisplay.Text += "6";

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            TXtDisplay.Text += "8";

        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            //var1 = Convert.ToInt32(TXtDisplay.Text);
            //TXtDisplay.Text = "";
            var_Sign2=var_sign;
            var_sign = 2;
            AddMothods x = new AddMothods();
            int result = 0;

            if (count == 0)
            {
                var1 = Convert.ToInt32(TXtDisplay.Text);
            }
            else
            {
                result = x.calculte_Math(var1, Convert.ToInt32(TXtDisplay.Text), var_Sign2);
                var1 = result;

            }
            TXtDisplay.Text = "";

            count++;

        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            var_Sign2=var_sign;
            var_sign = 4;
            AddMothods x= new AddMothods();
            int result = 0;

            if (count == 0)
            {
                var1 = Convert.ToInt32(TXtDisplay.Text);
            }
            else
            {
                result = x.calculte_Math(var1, Convert.ToInt32(TXtDisplay.Text), var_Sign2);
                var1 = result;

            }
            // var1 = Convert.ToInt32(TXtDisplay.Text);
            TXtDisplay.Text = "";
            //var_sign = 4;
            count++;
        }
    }
}
