﻿
namespace Task.Classes
{
    internal abstract class Student
    {
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public abstract void DoHomework();
    }
}
