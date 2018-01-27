using System;
using System.Collections.Generic;
namespace Institute
{
    class LocalCourses:Courses
    {
        string labNumber;
        int f = 0;

        public string LabNumber
        {
            set { this.labNumber = value; }
            get { return this.labNumber; }
        }
        public string ToString()
        {
            string output = "";
            output = "CampusCourse: Name=" + Name; 
            if(this.GetTeacher() == null)
                output = output+" Teacher= " + GetTeacher() + ";";
            output = output+" Topics= [";
            foreach(string i in topic)
            {
                if (f != 0)
                    output = output + ", ";
                output = output + i;
                f++;
            }
            output = output + "]";
            if(LabNumber != null)
                output = output+" LAB="+LabNumber;
            return output;
        }
    }
}
