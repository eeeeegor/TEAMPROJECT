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
        List<bool> second_opening = new List<bool>();
        public main_menu()
        {
            InitializeComponent();
            this.Time.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
            for (int i = 0; i < 12; i++)
            {
                second_opening.Add(false);
            }
            progressBar1.Maximum = 12;
            progressBar1.Value = 0;
        }

        private void Update()
        {
            int _curr = 0;
            for (int i = 0; i < tables_list.Count; i++)
            {
                if (tables_list[i].Avaivability == false)
                {
                    _curr++;
                }
            }
            progressBar1.Value = _curr;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Time.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
            if (tables_list[0].Avaivability == false) table_1.BackColor = Color.Red; else if (!Avail_check(tables_list, 0)) table_1.BackColor = Color.Blue; else table_1.BackColor = Color.White;
            if (tables_list[1].Avaivability == false) table_2.BackColor = Color.Red; else if (!Avail_check(tables_list, 1)) table_2.BackColor = Color.Blue; else table_2.BackColor = Color.White;
            if (tables_list[2].Avaivability == false) table_3.BackColor = Color.Red; else if (!Avail_check(tables_list, 2)) table_3.BackColor = Color.Blue; else table_3.BackColor = Color.White;
            if (tables_list[3].Avaivability == false) table_4.BackColor = Color.Red; else if (!Avail_check(tables_list, 3)) table_4.BackColor = Color.Blue; else table_4.BackColor = Color.White;
            if (tables_list[4].Avaivability == false) table_5.BackColor = Color.Red; else if (!Avail_check(tables_list, 4)) table_5.BackColor = Color.Blue; else table_5.BackColor = Color.White;
            if (tables_list[5].Avaivability == false) table_6.BackColor = Color.Red; else if (!Avail_check(tables_list, 5)) table_6.BackColor = Color.Blue; else table_6.BackColor = Color.White;
            if (tables_list[6].Avaivability == false) table_7.BackColor = Color.Red; else if (!Avail_check(tables_list, 6)) table_6.BackColor = Color.Blue; else table_7.BackColor = Color.White;
            if (tables_list[7].Avaivability == false) table_8.BackColor = Color.Red; else if (!Avail_check(tables_list, 7)) table_6.BackColor = Color.Blue; else table_8.BackColor = Color.White;
            if (tables_list[8].Avaivability == false) table_9.BackColor = Color.Red; else if (!Avail_check(tables_list, 8)) table_6.BackColor = Color.Blue; else table_9.BackColor = Color.White;
            if (tables_list[9].Avaivability == false) table_10.BackColor = Color.Red; else if (!Avail_check(tables_list, 9)) table_6.BackColor = Color.Blue; else table_10.BackColor = Color.White;
            if (tables_list[10].Avaivability == false) table_11.BackColor = Color.Red; else if (!Avail_check(tables_list, 10)) table_6.BackColor = Color.Blue; else table_11.BackColor = Color.White;
            if (tables_list[11].Avaivability == false) table_12.BackColor = Color.Red; else if (!Avail_check(tables_list, 11)) table_6.BackColor = Color.Blue; else table_12.BackColor = Color.White;

            Update();

        }

        private void LockWindow()
        {
            Form1 password = new Form1(this);
            password.ShowDialog();
        }

        private bool Avail_check(List<table> tables, int N)
        { int per = 0;
            for (int i = 0; i < 8; i++)
            {
                if (tables[N].Booking_time.ElementAt(SearchByKey(tables[N].Booking_time, RoundUp(DateTime.Now, TimeSpan.FromMinutes(15))) + i).Value == "")
                {
                    per++;
                }
            }
                if (per == 8)
                {
                    return true;
                }
                else return false;
                            
        }

        private DateTime RoundUp(DateTime dt, TimeSpan d)
        {
            return new DateTime(((dt.Ticks + d.Ticks - 1) / d.Ticks) * d.Ticks);
        }

        private int SearchByKey(Dictionary<DateTime, string> dic, DateTime time)
        {
            int per = 0;
            for (int i = 0; i < dic.Count; i++)
            {
                if (dic.ElementAt(i).Key == time)
                {
                    per = i;
                    break;
                }

            }
            return per;
        }
        private void main_menu_Load(object sender, EventArgs e)
        {
            
            tables_list.Add(new table(1, 4, new Dictionary<DateTime, string>()));
            tables_list.Add(new table(2, 8, new Dictionary<DateTime, string>()));
            tables_list.Add(new table(3, 2, new Dictionary<DateTime, string>()));
            tables_list.Add(new table(4, 6, new Dictionary<DateTime, string>()));
            tables_list.Add(new table(5, 2, new Dictionary<DateTime, string>()));
            tables_list.Add(new table(6, 2, new Dictionary<DateTime, string>()));
            tables_list.Add(new table(7, 4, new Dictionary<DateTime, string>()));
            tables_list.Add(new table(8, 12, new Dictionary<DateTime, string>()));
            tables_list.Add(new table(9, 4, new Dictionary<DateTime, string>()));
            tables_list.Add(new table(10, 4, new Dictionary<DateTime, string>()));
            tables_list.Add(new table(11, 6, new Dictionary<DateTime, string>()));
            tables_list.Add(new table(12, 6, new Dictionary<DateTime, string>()));
            
        }

        private void ToLock_Click(object sender, EventArgs e)
        {
            LockWindow();
        }

        private void table_1_Click(object sender, EventArgs e)
        { 
            table_menu table_Menu = new table_menu(ref tables_list, 0, ref second_opening);
            table_Menu.ShowDialog();
        }

        private void table_2_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(ref tables_list, 1, ref second_opening);
            table_Menu.ShowDialog();
        }

        private void table_3_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(ref tables_list, 2, ref second_opening);
            table_Menu.ShowDialog();
        }

        private void table_4_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(ref tables_list, 3, ref second_opening);
            table_Menu.ShowDialog();
        }

        private void table_5_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(ref tables_list, 4, ref second_opening);
            table_Menu.ShowDialog();
        }

        private void table_6_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(ref tables_list, 5, ref second_opening);
            table_Menu.ShowDialog();
        }

        private void table_7_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(ref tables_list, 6, ref second_opening);
            table_Menu.ShowDialog();
        }

        private void table_8_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(ref tables_list, 7, ref second_opening);
            table_Menu.ShowDialog();
        }

        private void table_9_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(ref tables_list, 8, ref second_opening);
            table_Menu.ShowDialog();
        }

        private void table_10_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(ref tables_list, 9, ref second_opening);
            table_Menu.ShowDialog();
        }

        private void table_11_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(ref tables_list, 10, ref second_opening);
            table_Menu.ShowDialog();
        }

        private void table_12_Click(object sender, EventArgs e)
        {
            table_menu table_Menu = new table_menu(ref tables_list, 11, ref second_opening);
            table_Menu.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
