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
        private string or_password = "4321";
        main_menu parent;
        public Form1(main_menu _main)
        {
            InitializeComponent();
            parent = _main;
            parent.Enabled = false;
            parent.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (password.Value == or_password)
            {
                parent.Enabled = true;
                parent.Show();
                this.Close();
            }
            else
            {
                label1.Left = this.Width / 2 - 200;
                label1.Text = "Неверный пароль";
                label2.Text = "";
                password.Value = "";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            password.Value += "1";
            label2.Text = password.Value;
        }

        private void two_Click(object sender, EventArgs e)
        {
            password.Value += "2";
            label2.Text = password.Value;
        }

        private void three_Click(object sender, EventArgs e)
        {
            password.Value += "3";
            label2.Text = password.Value;
        }

        private void four_Click(object sender, EventArgs e)
        {
            password.Value += "4";
            label2.Text = password.Value;
        }

        private void five_Click(object sender, EventArgs e)
        {
            password.Value += "5";
            label2.Text = password.Value;
        }

        private void six_Click(object sender, EventArgs e)
        {
            password.Value += "6";
            label2.Text = password.Value;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            password.Value += "7";
            label2.Text = password.Value;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            password.Value += "8";
            label2.Text = password.Value;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            password.Value += "9";
            label2.Text = password.Value;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            password.Value += "0";
            label2.Text = password.Value;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            password.Remove();
            label2.Text = password.Value;
        }
    }
}
