using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_Zhirova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            //cod reads from P
            string strP = textBox_P.Text;
            //convert text to number
            //16 becouse we use HEX
            int intP = Convert.ToInt32(strP, 16);
            string strKey = textBox_Key.Text;
            int intKey = Convert.ToInt32(strKey, 16);
            //perform XOR operation
            int intC = intP ^ intKey;
            //convert result into a text string
            string strC = Convert.ToString(intC, 16);
            //display it
            textBox_C.Text = strC;

            //code for binary form
            string str_Bin_P = Convert.ToString(Convert.ToInt64(strP, 16), 2);
            string str_Bin_Key = Convert.ToString(Convert.ToInt64(strKey, 16), 2);
            string str_Bin_C = Convert.ToString(Convert.ToInt64(strC, 16), 2);
            label_Bin_P.Text = str_Bin_P;
            label_Bin_Key.Text = str_Bin_Key;
            label_Bin_C.Text = str_Bin_C;

            //code for hexadecimal form
            string str_Hex_P = Convert.ToString(Convert.ToInt64(strP, 16), 16);
            string str_Hex_Key = Convert.ToString(Convert.ToInt64(strKey, 16), 16);
            string str_Hex_C = Convert.ToString(Convert.ToInt64(strC, 16), 16);
            label_Hex_P.Text = str_Hex_P;
            label_Hex_Key.Text = str_Hex_Key;
            label_Hex_C.Text = str_Hex_C;

            //code for decimal form
            string str_Dec_P = Convert.ToString(Convert.ToInt64(strP, 16), 10);
            string str_Dec_Key = Convert.ToString(Convert.ToInt64(strKey, 16), 10);
            string str_Dec_C = Convert.ToString(Convert.ToInt64(strC, 16), 10);
            label_Dec_P.Text = str_Dec_P;
            label_Dec_Key.Text = str_Dec_Key;
            label_Dec_C.Text = str_Dec_C;

            textBox_PP.Text = textBox_P.Text;
            textBox_KKey.Text = textBox_Key.Text;
            textBox_CC.Text = textBox_C.Text;
        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";

            textBox_PP.Text = "";
            textBox_KKey.Text = "";
            textBox_CC.Text = "";

            label_Bin_P.Text = "";
            label_Bin_Key.Text = "";
            label_Bin_C.Text = "";

            label_Hex_P.Text = "";
            label_Hex_Key.Text = "";
            label_Hex_C.Text = "";

            label_Dec_P.Text = "";
            label_Dec_Key.Text = "";
            label_Dec_C.Text = "";

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
