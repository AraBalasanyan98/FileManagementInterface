using System;
using System.Collections.Generic;

namespace FileManagementInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            File textFile = new File(new TextFile());
            File binaryFile = new File(new BinaryFile());
            List<File> files = new List<File>();
            files.Add(textFile);
            files.Add(binaryFile);
            for (int i = 0; i < files.Count; i++)
            {
                files[i].Open();
                files[i].Read();
                files[i].SearchFile();

            }
        }
    }
}
