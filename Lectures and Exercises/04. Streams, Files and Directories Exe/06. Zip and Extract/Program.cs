using System;
using System.IO.Compression;

namespace _06._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            //replace path

            ZipFile.CreateFromDirectory("D:/ZipDemo", "D:/ZipDemo/ZipFile.zip");
            ZipFile.ExtractToDirectory("D:/ZipDemo/ZipFile.zip","D:/ZipResult");
        }
    }
}
