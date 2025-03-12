using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1002
{
    public class program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double Pi = 3.14159;
            double B = Pi * (r * r);
            double A = Math.Round(B, 4);
            Console.WriteLine($"A={A:F4}");
        }
    }
}
