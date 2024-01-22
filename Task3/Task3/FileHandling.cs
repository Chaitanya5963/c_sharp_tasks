using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class FileHandling
    {
        public void CreateFile()
        {
            File.Create("C:\\Users\\cchellaboyina\\Documents\\5963\\sample.txt");
            Console.WriteLine("File is created");
        }
        public void DeleteFile()
        {
            File.Delete("C:\\Users\\cchellaboyina\\Documents\\5963\\sample.txt");
            Console.WriteLine("File is Deleted");
        }
        public void WriteFile()
        {
            try
            {
                File.WriteAllText("C:\\Users\\cchellaboyina\\Documents\\5963\\sample.txt", "Hello world");
                Console.WriteLine("Content Updated");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ReadFile()
        {
            Console.WriteLine("File content is\n"+File.ReadAllText("C:\\Users\\cchellaboyina\\Documents\\5963\\sample.txt"));
        }
    }
}
