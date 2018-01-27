using System;

namespace Lab1
{
    class Student
    {
        string name;
        string id;
        string department;
        float cgpa;

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetId(string id)
        {
            this.id = id;
        }
        public void SetDepartment(string department)
        {
            this.department = department;
        }
        public void SetCGPA(float cgpa)
        {
            this.cgpa = cgpa;
        }
        public string GetName()
        {
            return name;
        }
        public string GetId()
        {
            return id;
        }
        public string GetDepartment()
        {
            return department;
        }
        public float GetCGPA()
        {
            return cgpa;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: "+GetName());
            Console.WriteLine("ID: "+GetId());
            Console.WriteLine("Department: "+GetDepartment());
            Console.WriteLine("CGPA: "+GetCGPA());
        }
    }
}
