using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Forms_Files1
{
    internal class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }

        public string ToString()
        {
            return $"Name: {Name}, SurName: {Surname}, EMail: {EMail}, Phone: {Phone};";
        }
    }
}
