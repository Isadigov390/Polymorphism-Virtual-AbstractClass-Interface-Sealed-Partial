using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task.Classes
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        public bool CheckName(string name)
        {
            if (char.IsUpper(name[0]) && name.Length>=3 && name.Length<=30 )
            {
                return true;
            }
            return false;
        }
        public bool CheckSurname(string surname)
        {
            if (char.IsUpper(surname[0]) && surname.Length >= 3 && surname.Length <= 35)
            {
                return true;
            }
            return false;
        }
    }
}
