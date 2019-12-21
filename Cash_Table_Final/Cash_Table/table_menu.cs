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

    public partial class table_menu : Form
    {
        List<bool> second_opening;
        List<table> List;
        Dictionary<string, int> Menu = new Dictionary<string, int>();
        int i;
        public table_menu(ref List<table> List, int Name, ref List<bool> second_opening)
        {
            InitializeComponent();
            this.second_opening = second_opening;
            this.List = List;
            i = Name;
            TimePicker.CustomFormat = "HH mm";
            if (second_opening[Name])
            {
                Guests.Text = "";
                for (int i1 = 0; i1 < List[i].Booking_time.Count; i1++)
                {
                    if (List[i].Booking_time.ElementAt(i1).Value != "")
                    {
                        Guests.Text += List[i].Booking_time.ElementAt(i1).Value + " " + List[i].Booking_time.ElementAt(i1).Key.ToShortTimeString() + "\r\n";
                    }
                }
                
            }
            Menu.Add("Картофель фри", 150);
            Menu.Add("Греческий салат", 200);
            Menu.Add("Чай", 140);
            Menu.Add("Чизкейк", 400);
            for (int i = 0; i < Menu.Count; i++)
            {
                listBox1.Items.Add(Menu.ElementAt(i).Key);
            }
            Rubbles.Text = List[i].Check.ToString();
        }



        private void table_menu_Load(object sender, EventArgs e)
        {

        }

        
        private DateTime RoundUp(DateTime dt, TimeSpan d)
        {
            return new DateTime(((dt.Ticks + d.Ticks - 1) / d.Ticks) * d.Ticks);
        }
        private void Book_button_Click_1(object sender, EventArgs e)
        {
            if (TimePicker.Value < DateTime.Parse("08:59:59") | (TimePicker.Value > DateTime.Parse("22:01:00")))
            {
                MessageBox.Show("Ресторан в это время не работает");
            }
            else
            {
                if (List[i].ifAvailable(RoundUp(TimePicker.Value.Subtract(new TimeSpan(0, 2, 0)), TimeSpan.FromMinutes(15))))
                {
                    List[i].Booking_time[RoundUp(TimePicker.Value.Subtract(new TimeSpan(0, 2, 0)), TimeSpan.FromMinutes(15))] = Name_input.Text;
                    Guests.Text += "\r\n" + List[i].Booking_time[RoundUp(TimePicker.Value.Subtract(new TimeSpan(0, 2, 0)), TimeSpan.FromMinutes(15))] + "  " + RoundUp(TimePicker.Value.Subtract(new TimeSpan(0, 2, 0)), TimeSpan.FromMinutes(15)).ToShortTimeString();
                    second_opening[i] = true;
                }
                else MessageBox.Show("Выберите другое время");
                
                
            }
            
            
            
            
        }
        

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Taken_Click(object sender, EventArgs e)
        {
            List[i].Avaivability = false;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            List[i].Avaivability = true;
            List[i].Check = 0;
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            List[i].Check += Menu[listBox1.SelectedItem.ToString()];
            Rubbles.Text = List[i].Check.ToString();
        }
    }
}
