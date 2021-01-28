using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Person
    {
        public Person(string name, string surname, string bnum, DateTime bdate)
        {
            Name = name;
            Surname = surname;
            Bnum = bnum;
            Bdate = bdate;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Bnum{ get; set; }
        public DateTime Bdate { get; set; }
    }
}
