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
        }
        public int Name { get; set; }
        public int N_seats { get; set; }
        public bool Avaivability { get; set; }

        public Dictionary<DateTime, string> Booking_time { get; set; }
        
        public bool ifAvailable(DateTime chosen)
        {
            {
                bool count = false;
                for (int i = 0; i < Booking_time.Count; i++)
                {

                    if ((chosen.AddHours(1) < Booking_time.ElementAt(i).Key) & (chosen > Booking_time.ElementAt(i).Key.AddHours(1)))
                    {
                        count = true;
                    }
                }

                if (count | Booking_time.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
    }
}
