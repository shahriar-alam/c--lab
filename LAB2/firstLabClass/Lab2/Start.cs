using System;

namespace Lab2
{
    class Start
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            int a;
            Console.Write("X: ");
            a=Convert.ToInt32(Console.ReadLine());
            t.SetX(a);
            Console.Write("Y: ");
            a = Convert.ToInt32(Console.ReadLine());
            t.SetY(a);
            Console.Write("Z: ");
            a = Convert.ToInt32(Console.ReadLine());
            t.SetZ(a);

            t.ShowInfo();
            t.TestTriangle();
            
        }
    }
}
