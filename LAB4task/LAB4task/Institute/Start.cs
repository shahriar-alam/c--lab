using System;
namespace Institute
{
    class Start
    {
        static void Main(string[] args)
        {
            LocalCourses c = new LocalCourses();
            Teacher t = new Teacher();
            c.Name = "OOP2";
            c.SetTeacher(t);
            c.LabNumber = "1";
            c.AddTopic("Using Classes and Objects");
            t.Name = "Victor Stany Rozario";
            t.AddCourse(c);
            Console.WriteLine(c.ToString());
            Console.WriteLine(t.ToString());

        }
    }
}
