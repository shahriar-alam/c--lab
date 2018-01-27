using System;

namespace Lab1
{
    class Start1
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.SetName("Shahriar");
            s.SetId("15-30130-2");
            s.SetDepartment("CSE");
            s.SetCGPA(2.99f);

            s.ShowInfo();


        }
    }
}
