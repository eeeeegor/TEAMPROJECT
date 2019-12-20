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
        List<table> List;
        int i;
        public table_menu(List<table> List, int Name)
        {
            InitializeComponent();
            this.List = List;
            i = Name;
            TimePicker.CustomFormat = "HH mm";
        }

        

        private void table_menu_Load(object sender, EventArgs e)
        {
            
        }

        private void Book_button_Click_1(object sender, EventArgs e)
        {
            if (List[i].ifAvailable(TimePicker.Value))
            {
                List[i].Booking_time.Add(TimePicker.Value, Name_input.Text);
                MessageBox.Show("Stolik zabronirovan na: " + TimePicker.Value.ToString());
                Guests.Text += List[i].Booking_time.ElementAt(0);
            }
            else
            {
                MessageBox.Show("Столик забронировать нельзя");
            }
            
        }
        

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
