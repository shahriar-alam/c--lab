using System;
using System.Collections.Generic;
namespace Institute
{
    class Teacher
    {
        string name;
        int f = 0;
        List<Courses> course = new List<Courses>();

        public void AddCourse(Courses c)
        {
            course.Add(c);
        }
        public string ToString()
        {
            string output = "";
            output = "Teacher: Name=" + Name + "; Courses=[";
            foreach (Courses i in course)
            {
                if (f != 0)
                    output = output + ", ";
                output = output + i.Name;
                f++;
            }
            output = output + "]";
            return output;
        }
        public string Name
        {
            set{this.name = value;}
            get{return this.name;}
        }

    }
}
