using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        private int _groupId;
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(string name,string surname)
        {
            _groupId++;
            GroupId = _groupId;
            Name = name;
            Surname = surname;
        }
    }
}
