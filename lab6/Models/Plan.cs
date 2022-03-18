using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Models
{
    public class Plan
    {
        public string Name { get; private set; }
        public string Todo { get; private set; }
        public DateTime Date { get; private set; }

        public Plan(string name, string todo, DateTime date)
        {
            Name = name;
            Todo = todo;
            Date = date;
        }

        public override string ToString()
        {
            return Name + " " + Todo + " " + Date.ToString();
        }
    }
}
