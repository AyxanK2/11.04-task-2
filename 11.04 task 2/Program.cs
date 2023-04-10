namespace _11._04_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group  Qrup = new Group(1,"ayxan");
            Group Qrup2 = new Group(5, "malik");
            //Console.WriteLine(Qrup.Delete(1));
            Qrup.Add("Ayxan");
            Qrup.Add("Malik");
            Qrup.GetNames();
            Qrup.Search("Ayxannn");
            Qrup.GetSearch();
            Qrup.Get();
            Qrup.GetGet();
            //Qrup.Update(1, Ayxan);
            Qrup.GetUpdate();
            ////Qrup.Delete();
            Student student1 = new Student("Ayxan","Karimli","1");
            Student student2 = new Student("Malik", "Aliyev", "2");
            Student student3 = new Student("Ramin", "Bebirli", "3");
            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student3.ToString());
            //Console.WriteLine(student.StudentNumber = "n1");
            //Console.WriteLine(student.Name = "Ayxan");
            //Console.WriteLine(student.LastName = "Karimli");
            //Console.WriteLine(student.Id = 1);
        }
    }
}