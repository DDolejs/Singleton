using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        public Dictionary<string, Person> persons = new Dictionary<string, Person>();
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        Singleton()
        {
            persons.Add("010213/0812", new Person("John", "Doe", "020620/0269", new DateTime(2002, 6, 20)));
            persons.Add("010213/0812", new Person("Jane", "Doe", "020621/0270", new DateTime(2002, 6, 21)));
            ;
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }
}
