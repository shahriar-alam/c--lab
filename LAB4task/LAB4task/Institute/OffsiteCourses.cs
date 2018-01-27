using System;
namespace Institute
{
    class OffsiteCourses:Courses
    {
        string town;
        int f = 0;

        public string Town
        {
            set { this.town = value; }
            get { return this.town; }
        }
        public string ToString()
        {
            string output = "";
            output = "CampusCourse: Name=" + Name;
            if (this.GetTeacher() == null)
                output = output + " Teacher= " + GetTeacher() + ";";
            output = output + " Topics= [";
            foreach (string i in topic)
            {
                if (f != 0)
                    output = output + ", ";
                output = output + i;
                f++;
            }
            output = output + "]";
            if(Town == null)
                output = output + " Town=" + Town;
            return output;
        }
    }
}
