using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagementInterface
{
    class TextFile : IFile
    {
        public void OpenFile()
        {
            Console.WriteLine("Opening Text File");
        }

        public void ReadFile()
        {
            Console.WriteLine("Reading Text File");
        }

        public void Search()
        {
            Console.WriteLine("Searching Text File");
        }
    }
}
