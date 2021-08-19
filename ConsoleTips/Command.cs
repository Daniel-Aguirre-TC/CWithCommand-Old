using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTips
{
    public class Command
    {
        public string name;
        public string desc;
        public Command(string Name, string Desc)
        {
            name = Name;
            desc = Desc;
        }
    }
}
