using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAndSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"D:\Cursos\Fazendo\C# POO\Curso\DictionaryAndSorted\in.txt";
                Dictionary<string, int> candidates = new Dictionary<string, int>();
                using (StreamReader sr = new StreamReader(File.OpenRead(path)))
                {
                    while (!sr.EndOfStream)
                    {
                        
                        string[] vect = sr.ReadLine().Split(',');
                        string name = vect[0];
                        int number = int.Parse(vect[1]);

                        if (candidates.ContainsKey(name))
                        {
                            candidates[name] += number;
                        }
                        else
                        {
                            candidates.Add(name, number);
                        }


                    }
                }
                foreach(var c in candidates)
                {
                   Console.Write(c.Key + ": "+ c.Value);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: "+ e.Message);
            }
        }
    }
}
