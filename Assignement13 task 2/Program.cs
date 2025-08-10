using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement13_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "myfile.txt";
            int choice = 0;

            do
            {
                Console.WriteLine("\n--- File Operations Menu ---");
                Console.WriteLine("1. Create a new file");
                Console.WriteLine("2. Add contents to the file (overwrite)");
                Console.WriteLine("3. Append contents to the file");
                Console.WriteLine("4. Display contents one by one");
                Console.WriteLine("5. Display all contents together");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                try
                {
                    switch (choice)
                    {
                        case 1:
                            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                            {
                                Console.WriteLine("New file created successfully.");
                            }
                            break;

                        case 2:
                            using (StreamWriter sw = new StreamWriter(filePath, false))
                            {
                                Console.Write("Enter content to add: ");
                                string content = Console.ReadLine();
                                sw.WriteLine(content);
                                Console.WriteLine("Content written to file.");
                            }
                            break;

                        case 3:
                            using (StreamWriter sw = new StreamWriter(filePath, true))
                            {
                                Console.Write("Enter content to append: ");
                                string content = Console.ReadLine();
                                sw.WriteLine(content);
                                Console.WriteLine("Content appended to file.");
                            }
                            break;

                        case 4:
                            using (StreamReader sr = new StreamReader(filePath))
                            {
                                string line;
                                Console.WriteLine("\n--- File Contents (One by One) ---");
                                while ((line = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(line);
                                    Console.ReadKey(); // Wait for key press before showing next line
                                }
                            }
                            break;

                        case 5:
                            using (StreamReader sr = new StreamReader(filePath))
                            {
                                Console.WriteLine("\n--- Full File Content ---");
                                string content = sr.ReadToEnd();
                                Console.WriteLine(content);
                            }
                            break;

                        case 6:
                            Console.WriteLine("Exiting program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Error: File does not exist. Please create the file first.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

            } while (choice != 6);
        }
    }
}
