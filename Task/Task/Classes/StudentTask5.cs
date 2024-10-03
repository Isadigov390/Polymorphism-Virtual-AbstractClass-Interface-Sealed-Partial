using System.Text.RegularExpressions;

namespace Task.Classes
{
    internal  class StudentTask5
    {
        public StudentTask5(string fullname, string groupNo, int age)
        {
            Fullname = fullname;
            GroupNo = groupNo;
            Age = age;
        }

        public string Fullname { get; set; }
        public string GroupNo { get; set; }
        public int Age { get; set; }
        public static bool CheckGroupNo(string groupNo)
        {
            return Regex.IsMatch(groupNo, @"^[A-Z]\d{3}$");
        }   
        public static bool CheckFullName(string fullName)
        {
            return Regex.IsMatch(fullName, @"^[A-Z][a-z]+ [A-Z][a-z]+$");
        }
    }
}
