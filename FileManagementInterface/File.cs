using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagementInterface
{
    class File
    {
        private readonly IFile _file;

        public File(IFile file)
        {
            _file = file;
        }

        public void Open()
        {
            _file.OpenFile();
        }
        public void Read()
        {
            _file.ReadFile();
        }
        public void SearchFile()
        {
            _file.Search();
        }
    }
}
