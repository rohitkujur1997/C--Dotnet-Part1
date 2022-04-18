using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIOProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir = @"C:\Rohit\FileIO";
            string subdir1 = @"C:\Rohit\FileIO\Write";
            string subdir2 = @"C:\Rohit\FileIO\Read";
            string srcFilepath = @"C:\Rohit\FileIO\Write\myFile.txt";
            string desFilepath = @"C:\Rohit\FileIO\Read\myFile.txt";
            Directory.CreateDirectory(dir);
            Directory.CreateDirectory(subdir1);
            Directory.CreateDirectory(subdir2);

            DirectoryInfo ds = new DirectoryInfo(subdir2);
            //create file and write
            FileStream fs = File.Create(srcFilepath);
            string[] lines = { "Rohit Kujur", "kujur.rohit95@gmail.com", "Mumbai" };
            StreamWriter sw = new StreamWriter(fs);
            foreach (string s in lines)
            {
                sw.WriteLine(s);
            }
            sw.Close();
            // read and write on console
            string[] line = File.ReadAllLines(srcFilepath);
            foreach (string s in line)
            {
                Console.WriteLine(s);
            }
            File.Copy(srcFilepath, desFilepath, true);
            Console.ReadLine();
        }
    }
}