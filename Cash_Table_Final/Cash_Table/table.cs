using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Table
{
    public class table
    {
        public table(int N, int N_s, Dictionary<DateTime, string> Booking_time)
        {
            Name = N;
            N_seats = N_s;
            Avaivability = true;
            this.Booking_time = Booking_time;
            for (int hours = 9; hours < 22; hours++)
            {
                for (int minutes = 0; minutes <= 45; minutes+=15)
                {
                    Booking_time.Add(DateTime.Parse(hours.ToString() + ":" + minutes.ToString()), "");
                }
            }
                
                
            }
        

        public int Name { get; set; }
        public int N_seats { get; set; }
        public bool Avaivability { get; set; }
        
        public int Check { get; set; }
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

        public Dictionary<DateTime, string> Booking_time { get; set; }

        private DateTime RoundUp(DateTime dt, TimeSpan d)
        {
            return new DateTime(((dt.Ticks + d.Ticks - 1) / d.Ticks) * d.Ticks);
        }

        public bool ifAvailable(DateTime chosen)
        {
            DateTime checkdata;
            int check = 0;
            chosen = RoundUp(chosen, TimeSpan.FromMinutes(15));
            {
                for (int i = 0; i < 8; i++)
                {
                    if (Booking_time.ElementAt(SearchByKey(Booking_time, chosen) + i).Value == "")
                    {
                        check++;
                    }
                }
                
                if (check == 8) return true;
                else return false ;
            }
            
        }
    }
}
