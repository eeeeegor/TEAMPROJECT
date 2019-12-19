using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Table
{
    public partial class Form1 : Form
    {
        Entered_text password = new Entered_text();
        main_menu Menu = new main_menu();

        private string or_password = "4321";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (password.Get() == or_password)
            {
                this.Close();
            }
            else
            {
                label1.Left = this.Width / 2 - 200;
                label1.Text = "Неверный пароль";
                label2.Text = "";
                password.Set("");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            password.Add_Digit("1");
            label2.Text = password.Get();
        }

        private void two_Click(object sender, EventArgs e)
        {
            password.Add_Digit("2");
            label2.Text = password.Get();
        }

        private void three_Click(object sender, EventArgs e)
        {
            password.Add_Digit("3");
            label2.Text = password.Get();
        }

        private void four_Click(object sender, EventArgs e)
        {
            password.Add_Digit("4");
            label2.Text = password.Get();
        }

        private void five_Click(object sender, EventArgs e)
        {
            password.Add_Digit("5");
            label2.Text = password.Get();
        }

        private void six_Click(object sender, EventArgs e)
        {
            password.Add_Digit("6");
            label2.Text = password.Get();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            password.Add_Digit("7");
            label2.Text = password.Get();
        }

        private void eight_Click(object sender, EventArgs e)
        {
            password.Add_Digit("8");
            label2.Text = password.Get();
        }

        private void nine_Click(object sender, EventArgs e)
        {
            password.Add_Digit("9");
            label2.Text = password.Get();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            password.Add_Digit("0");
            label2.Text = password.Get();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            password.Clear_Digit();
            label2.Text = password.Get();
        }
    }
}
