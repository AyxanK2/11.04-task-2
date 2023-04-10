using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._04_task_2
{
    internal class Group
    {
        private int _id;
        public int id { get; set; }
        public string Name { get; set; }

        public Group(int id, string name)
        {
            _id++;
            id = _id;
            Name = name;          
        }

        Student[] students = { };
        public void Add(Student student)
        {
            Array.Resize(ref students,students.Length + 1 );
            students[students.Length - 1] = student;
            foreach (Student s in students)
            {
                if (s.StudentNumber == student.StudentNumber)
                {
                    Console.WriteLine("Bu tələbə artıq mövcuddur.");
                    return;
                }
                continue;
            }
        }
        public void GetNames()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
        public void Update(string id, Student NewStudent)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].StudentNumber == id)
                {
                    students[i] = NewStudent;
                    break;
                }
                else
                    Console.WriteLine("Belə bir tələbə yoxdur.");
            }  
        }
        public void GetUpdate()
        {
            foreach (Student newstudent in students)
            {
                Console.WriteLine(newstudent);
            }
        }
        public void Delete(string id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].StudentNumber == id)
                {
                    students[i] = null;
                    break;
                }
            }
        }
        public void GetDelete()
        {
            foreach(Student delete in students)
            {
                Console.WriteLine(delete);
            }
        }
        internal void Add(string Name)
        {
            Console.WriteLine(Name);
        }
        public void Get()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"ad {student.Name} Soyad {student.LastName} number {student.StudentNumber}");
            }
        }
        public void GetGet()
        {
            foreach (Student get in students)
            {
                Console.WriteLine(get);
            }
        }
        public void Search(string search)
        {
            foreach (Student student in students)
            {
                if (student.Name.Contains(search) || student.LastName.Contains(search) || student.StudentNumber.Contains(search))
                {
                    Console.WriteLine($"ad {student.Name} Soyad {student.LastName} number {student.StudentNumber}");
                }
                else
                    Console.WriteLine("Axtarışa uyğun nəticə tapılmadı.");
            }
        }
        public void GetSearch()
        {
            foreach (Student search in students)
            {
                Console.WriteLine(search);
            }
        }    
    }
}
