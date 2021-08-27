using System;
using System.IO;
using System.Text;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string root = @"E:\CSharpGroup3";
            string source = @"E:\CSharpGroup3";

            Directory.CreateDirectory(source);

            string txtFile = @"E:\CSharpGroup3\CSharpGroup3.txt";
            File.CreateText(txtFile);

            string altSource = @"E:\CSharpGroup3\SubFolderCSharpGroup3";

            var isDirectoryExist = Directory.Exists(altSource);

            if (!isDirectoryExist)
                Directory.CreateDirectory(altSource);


            string wordFile = @"E:\CSharpGroup3\SubFolderCSharpGroup3\File.docx";
            string excelFile = @"E:\CSharpGroup3\SubFolderCSharpGroup3\File2.xlsx";

            File.Create(wordFile);
            File.Create(excelFile);


            string[] txtFileDir = Directory.GetFiles(root, "*.txt", SearchOption.AllDirectories);

            string randomDir = "";

            foreach (string item in txtFileDir)
            {
                randomDir = item;
            }

            FileStream strm = File.Open(randomDir, FileMode.Open);
            string ranWord = "My name is Chingiz";
            byte[] ranbyte = Encoding.Default.GetBytes(ranWord);
            strm.Write(ranbyte, 0, ranbyte.Length);
            strm.Position = 0;


            string[] txtWordFileDir = Directory.GetFiles(root, "*.docx", SearchOption.AllDirectories);

            string ranWordDir = "";

            foreach (string item in txtWordFileDir)
            {
                ranWordDir = item;
            }

            StreamWriter sw = File.CreateText(ranWordDir);
            sw.WriteLine("and I am 19 years old");
            sw.Close();

            StreamReader sr = File.OpenText(randomDir);
            StreamReader sr1 = File.OpenText(ranWordDir);

            Console.WriteLine($"Full Text: {sr.ReadToEnd()} {sr1.ReadToEnd()}");
            sr.Close();
            sr1.Close();
            


        }
    }
}
