using System;

namespace Lab2
{
    class Triangle
    {
        int x, y, z;

        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void SetZ(int z)
        {
            this.z = z;
        }
        public void ShowInfo()
        {
            Console.WriteLine("X: " + x + "\nY: " + y + "\nZ: " + z);
        }
        public void TestTriangle()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("Equilateral");
            }
            else if (x != y && y != z && x != z)
            {
                Console.WriteLine("Scalene");
            }
            else
            {
                Console.WriteLine("Isosceles");
            }
        }
    }
}
