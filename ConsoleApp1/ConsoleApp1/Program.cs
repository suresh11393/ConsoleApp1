using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //edit the folder location
            string dirPath=@"D:\Products\SaralTDS12\SaralTDS\SaralTDS\Main\bin\Debug\Data\Userfiles\FY_2020_21\TDS";
            processDirectory(dirPath);
            Console.ReadLine();
        }
        private static void processDirectory(string startLocation)
        {
            foreach (var directory in Directory.GetDirectories(startLocation))
            {
                processDirectory(directory);
                if (Directory.GetFiles(directory).Length == 0 &&
                    Directory.GetDirectories(directory).Length == 0)
                {
                    Directory.Delete(directory, false);
                }
            }
        }
    }
}
