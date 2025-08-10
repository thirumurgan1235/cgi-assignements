using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mainPath = "demo";
            string demo1Path = Path.Combine(mainPath, "demo1");
            string demo2Path = Path.Combine(mainPath, "demo2");
            Directory.CreateDirectory(mainPath);
            Console.WriteLine("Directory 'demo' created.");
            Directory.CreateDirectory(demo1Path);
            Directory.CreateDirectory(demo2Path);
            Console.WriteLine("Directories 'demo1' and 'demo2' created.");
            string file1 = Path.Combine(mainPath, "file1.txt");
            File.WriteAllText(file1, "This is file1 created using File class.");
            string file2 = Path.Combine(mainPath, "file2.txt");
            FileInfo fi = new FileInfo(file2);
            using (StreamWriter sw = fi.CreateText())
            {
                sw.WriteLine("This is file2 created using FileInfo class.");
            }

            Console.WriteLine("Files created and written successfully.");
            string destFile = Path.Combine(demo2Path, "file1_copy.txt");
            File.Copy(file1, destFile, true);
            Console.WriteLine("file1 copied to demo2 folder.");
            Console.WriteLine("\nDirectories inside 'demo':");
            foreach (string dir in Directory.GetDirectories(mainPath))
            {
                Console.WriteLine($"{dir} | Created On: {Directory.GetCreationTime(dir)}");
            }

            Console.WriteLine("\nFiles inside 'demo':");
            foreach (string file in Directory.GetFiles(mainPath))
            {
                Console.WriteLine($"{file} | Created On: {File.GetCreationTime(file)}");
            }
            foreach (string file in Directory.GetFiles(mainPath))
            {
                File.Delete(file);
                Console.WriteLine($"Deleted file: {file}");
            }
            foreach (string file in Directory.GetFiles(demo2Path))
            {
                File.Delete(file);
                Console.WriteLine($"Deleted file: {file}");
            }
            Directory.Delete(demo1Path);
            Directory.Delete(demo2Path);
            Directory.Delete(mainPath);
            Console.WriteLine("All directories deleted.");
        }
    }
    }

