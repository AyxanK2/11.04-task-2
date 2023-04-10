using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._04_task_2
{
    internal class Student 
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public Student(string name, string lastName, string studentNumber)
         {
            _id++;
            Id = _id;
            Name = name;
            LastName = lastName;
            StudentNumber = studentNumber;
        }
        public override string ToString()
        {
            return $"{Id}:{Name} {LastName}";
        }
    }
}
