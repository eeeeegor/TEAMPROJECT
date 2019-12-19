using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Table
{
    public class Entered_text
    {
        private bool auth = false;

        string Value = "";
        public void Add_Digit(string text)
        {
            Value += text;
        }
        public void Clear_Digit()
        {
            if (Value != "")
            {
                Value = Value.Remove(Value.Length - 1, 1);
            }
        }
        public string Get()
        {
            return Value;
        }
        public void Set(string name)
        {
            Value = name;
        }
    }
}
