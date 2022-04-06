using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Folder = Path.Combine(@"C:\Users\User\Desktop", "Ap", "C#", "code.txt");
            string Folder1 = Path.Combine(@"C:\Users\User\Desktop", "Ap", "Python", "code.txt");
            string Folder2 = Path.Combine(@"C:\Users\User\Desktop", "Ap", "Go", "code.txt");
            //string folder = @"C:\Users\User\Desktop";
            //Directory.CreateDirectory(Folder);
            //Directory.CreateDirectory(Folder1);
            //Directory.CreateDirectory(Folder2);

            //File.Create(Folder);
            //File.Create(Folder1);
            //File.Create(Folder2);

            //if (File.Exists(Folder2))
            //{
            //    File.Delete(Folder2);
            //}
            //else
            //{
            //    Console.WriteLine("there is no such txt");
            //}

            //using (StreamWriter streamWriter = new StreamWriter(Folder))
            //{
            //    streamWriter.WriteLine("var p1 = new Point(0, 0),var p2 = new Point(10, 20)");
 
            //} 
            //using (StreamWriter streamWriter = new StreamWriter(Folder1))
            //{
            //    streamWriter.WriteLine("my_list = [1, 2, 3, 4, 5]");
 
            //} 
            //using (StreamWriter streamWriter = new StreamWriter(Folder2))
            //{
            //    streamWriter.WriteLine("for i := 0; i < b.N; i++ {fund.Withdraw(1)");
        
 
            //}
            using (StreamReader streamReader = new StreamReader(Folder1))
            {
               string fl= streamReader.ReadToEnd();
                Console.WriteLine(fl);
            }

        }
    }
}
