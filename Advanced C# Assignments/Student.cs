using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__Assignments
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}";
        }
    }
}
