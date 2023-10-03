using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Cursos\Fazendo\C# POO\Curso\File\File\estoque.txt";
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            Directory.CreateDirectory(Path.GetDirectoryName(path) + @"\out");

            string destiny = Path.GetDirectoryName(path) + @"\out\summary.csv";
            

            
            try
            {
                using (StreamWriter dsw = File.AppendText(destiny)) {
                    while (!sr.EndOfStream)
                    {
                        string text = sr.ReadLine();
                        string[] splits = text.Split(',');
                        string name = splits[0];
                        double price = double.Parse(splits[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(splits[2]);
                        dsw.WriteLine(name + "," + (price * quantity).ToString("F2",CultureInfo.InvariantCulture));

                    } 
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error IO - " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error - " + e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }
        }


    }
}

