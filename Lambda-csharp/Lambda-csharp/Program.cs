using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Lambda_csharp.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Cursos\Fazendo\C# POO\Curso\Lambda-csharp\in.txt";
            List<Employee> employees = new List<Employee>();
            List<string> sortedByEmail = new List<string>();
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            using (StreamReader sr = new StreamReader(File.OpenRead(path)))
            {
                while (!sr.EndOfStream)
                {
                    
                    string[] vect = sr.ReadLine().Split(',');

                    string name = vect[0];
                    string email = vect[1];
                    double value = double.Parse(vect[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, value));
                    
                }
                sortedByEmail = employees.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email).ToList();
                


                foreach (string email in sortedByEmail)
                {
                    Console.WriteLine(email);
                }
                Console.Write("Sum of salary of people whose name starts with 'M': " +
                    employees.Where(p => p.Name[0] == 'M').Sum(p => p.Salary).ToString("F2",CultureInfo.InvariantCulture)+
                    "\n"
                    );
                

            }
        }
    }
}

