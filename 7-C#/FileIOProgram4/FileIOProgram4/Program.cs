using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIOProgram4
{
    [Serializable]
    public class employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
    }
    class Serializer
    {
        public void BinarySerialize(object data, string filePath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath)) File.Delete(filePath);
            fileStream = File.Create(filePath);
            bf.Serialize(fileStream, data);
            fileStream.Close();
        }
        public object BinaryDeserialize(string filePath)
        {
            object obj = null;
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = bf.Deserialize(fileStream);
                fileStream.Close();
            }
            return obj;
        }
    }
    internal class Serialize
    {
        static void Main(string[] args)
        {
            string dir = @"C:\Rohit2\FileIO\Write";
            string srcFilepath = @"C:\Rohit2\FileIO\Write\myFile.txt";
            Directory.CreateDirectory(dir);
            employee emp1 = new employee
            {
                EmpId = Convert.ToInt32(Console.ReadLine()),
                EmpName = Console.ReadLine(),
                EmpSalary = Convert.ToDouble(Console.ReadLine())
            };
            Serializer se = new Serializer();
            se.BinarySerialize(emp1, srcFilepath);
            Console.WriteLine("Serialize done");
            emp1 = se.BinaryDeserialize(srcFilepath) as employee;
            Console.WriteLine(emp1.EmpId);
            Console.WriteLine(emp1.EmpName);
            Console.WriteLine(emp1.EmpSalary);
            Console.WriteLine("Deserialize done");
            Console.ReadKey();
        }
    }
}