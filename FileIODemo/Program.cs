using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"\Users\Bharat\Desktop\bridzelabz\empwagecompute\AddressBook2\FileIODemo\FileIODemo\Example.txt";
            //    FileExists();
           // ReadAllLines();
            //Program.ReadAllText();
            // CopyFile(path);
            // DeleteFile();
            ReadingDataUsingStreamReader( path);

        }
        public static void FileExists()
        {
            String path = @"\Users\Bharat\Desktop\bridzelabz\empwagecompute\AddressBook2\FileIODemo\FileIODemo\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();            
        }
        public static void ReadAllLines()
        {
            String path= @"\Users\Bharat\Desktop\bridzelabz\empwagecompute\AddressBook2\FileIODemo\FileIODemo\Example.txt";
            String[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.ReadKey();
        }
        public static void ReadAllText()
        {
            String path = @"\Users\Bharat\Desktop\bridzelabz\empwagecompute\AddressBook2\FileIODemo\FileIODemo\Example.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.ReadKey();
        }
        public static void CopyFile(String path)
        {
            string destination = @"\Users\Bharat\Desktop\bridzelabz\empwagecompute\AddressBook2\FileIODemo\FileIODemo\Sample.txt"; 
            if (File.Exists(path))
            {
                File.Copy(path, destination);
            }
        }
        public static void DeleteFile()
        {
            string destination = @"\Users\Bharat\Desktop\bridzelabz\empwagecompute\AddressBook2\FileIODemo\FileIODemo\Sample.txt";
            if (File.Exists(destination))
            {
                File.Delete( destination);
            }
        }
        public static void ReadingDataUsingStreamReader(string path)
        {
            StreamReader sr = File.OpenText(path);
            string line="";
            while ((line= sr.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }

    }
}
