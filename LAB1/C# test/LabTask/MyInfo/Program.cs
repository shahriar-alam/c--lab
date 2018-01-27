
namespace MyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, id, dob, blood, department;
            double cgpa;
            System.Console.Write("Name: ");
            name = System.Console.ReadLine();
            System.Console.Write("\nID: ");
            id = System.Console.ReadLine();
            System.Console.Write("\nCGPA: ");
            cgpa = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("\nDOB: ");
            dob = System.Console.ReadLine();
            System.Console.WriteLine("\nBlood Group: ");
            blood = System.Console.ReadLine();
            System.Console.WriteLine("\nDepartment: ");
            department = System.Console.ReadLine();
            System.Console.WriteLine("Name: "+name+"\nID: "+id+"\nCGPA: "+cgpa+"\nDOB: "+dob+"\nBlood: "+blood+"\nDepartment: "+department);
        }
    }
}
