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

namespace Cash_Table
{
    public partial class main_menu : Form
    {
        List<table> tables_list = new List<table>();
        List<Control> table_tag_buttons = new List<Control>();
        public main_menu()
        {
            InitializeComponent();
            this.Time.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Time.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        private void LockWindow()
        {
            Form1 password = new Form1(this);
            password.ShowDialog();
        }

        private void Avail_check()
        {
            for (int i = 0; i < tables_list.Count; i++)
            {
                if (tables_list[i].Avaivability == true)
                { 
                            
                }
            }        
        }
       

        private void main_menu_Load(object sender, EventArgs e)
        {
            Dictionary<DateTime, string> Booking_time = new Dictionary<DateTime, string>();
            tables_list.Add(new table(1, 4, Booking_time));
            tables_list.Add(new table(2, 8, Booking_time));
            tables_list.Add(new table(3, 2, Booking_time));
            tables_list.Add(new table(4, 6, Booking_time));
            tables_list.Add(new table(5, 2, Booking_time));
            tables_list.Add(new table(6, 2, Booking_time));
            tables_list.Add(new table(7, 4, Booking_time));
            tables_list.Add(new table(8, 12, Booking_time));
            tables_list.Add(new table(9, 4, Booking_time));
            tables_list.Add(new table(10, 4, Booking_time));
            tables_list.Add(new table(11, 6, Booking_time));
            tables_list.Add(new table(12, 6, Booking_time));
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].Tag != null)
                {
                    if (this.Controls[i].Tag.ToString() == "table_tag")
                    {
                        table_tag_buttons.Add(this.Controls[i]);
   
                    }
                }
            }

            for (int i = 0; i < table_tag_buttons.Count; i++)
            {
                if (Convert.ToInt32(table_tag_buttons[i].Text) - 1 != i)
                {
                    Control a = table_tag_buttons[Convert.ToInt32(table_tag_buttons[i].Text) - 1];
                    string text = table_tag_buttons[i].Text;

                    table_tag_buttons[Convert.ToInt32(table_tag_buttons[i].Text) - 1] = table_tag_buttons[i];
                    table_tag_buttons[i] = a;

                }
                table_tag_buttons[i].Text = "xyi" + i.ToString();
            }

        }

        private void ToLock_Click(object sender, EventArgs e)
        {
            LockWindow();
        }

        private void table_1_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(tables_list, 0);
            table_Menu.ShowDialog();
        }

        private void table_2_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(tables_list, 1);
            table_Menu.ShowDialog();
        }

        private void table_3_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(tables_list, 2);
            table_Menu.ShowDialog();
        }

        private void table_4_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(tables_list, 3);
            table_Menu.ShowDialog();
        }

        private void table_5_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(tables_list, 4);
            table_Menu.ShowDialog();
        }

        private void table_6_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(tables_list, 5);
            table_Menu.ShowDialog();
        }

        private void table_7_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(tables_list, 6);
            table_Menu.ShowDialog();
        }

        private void table_8_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(tables_list, 7);
            table_Menu.ShowDialog();
        }

        private void table_9_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(tables_list, 8);
            table_Menu.ShowDialog();
        }

        private void table_10_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(tables_list, 9);
            table_Menu.ShowDialog();
        }

        private void table_11_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(tables_list, 10);
            table_Menu.ShowDialog();
        }

        private void table_12_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(tables_list, 11);
            table_Menu.ShowDialog();
        }
    }
}
