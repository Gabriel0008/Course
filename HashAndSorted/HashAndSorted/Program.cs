using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashAndSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> students = new HashSet<int>();
            Console.Write("How many students for course A? ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i< number; i++)
            {
                students.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("How many students for course B? ");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                students.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("How many students for course C? ");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                students.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Total students: " + students.Count);


        }
    }
}
