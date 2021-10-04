using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagementInterface
{
    class BinaryFile : IFile
    {
        public void OpenFile()
        {
            Console.WriteLine("Opening Binary File");
        }

        public void ReadFile()
        {
            Console.WriteLine("Reading Binary File");
        }

        public void Search()
        {
            Console.WriteLine("Searching Binary File");
        }
    }
}
