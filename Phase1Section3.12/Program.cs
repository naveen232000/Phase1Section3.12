using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._12
{
    internal class Program
    {
        public static void FileFun()
        {
            string dir = Directory.GetCurrentDirectory();
            dir = dir + "\\file1.txt";
            Console.WriteLine(dir);
            if (File.Exists(dir))
            {
                Console.WriteLine("File exists\n");
                Console.WriteLine("Do with File:\nRead => 1\nDelete => 2");
                string c=Console.ReadLine();
                switch (c)
                {
                    case "1":
                        {
                            ReadFil();
                            break;
                        }
                    case "2":
                        {
                            deleteFil();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("File does not exist\n");
                Console.WriteLine("Creating New file\n");
                StreamWriter Newfil=new StreamWriter(dir);
                Console.WriteLine("Writing in New File....\n");
                Newfil.WriteLine("New file Created");
                Newfil.WriteLine("Added Text line ");
                Newfil.Close();
                Console.WriteLine("Writed in New File");
                string[] lines = File.ReadAllLines(dir);
                foreach (string s in lines)
                {
                    Console.WriteLine(s);
                }


               // File.Delete(filename);
               // Console.WriteLine(filename + " was deleted");

            }
    
        }
        public static void deleteFil()
        {
            string dir = Directory.GetCurrentDirectory();
            dir = dir + "\\file1.txt";
            Console.WriteLine("Going to Delete file ...");
            File.Delete(dir);
            Console.WriteLine("File deleted");

        }
        public static void ReadFil()
        {
            string dir = Directory.GetCurrentDirectory();
            dir = dir + "\\file1.txt";
            Console.WriteLine("File Content: \n");
            string text = File.ReadAllText(dir);
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {
            FileFun();
            Console.ReadLine();
        }
    }
}
