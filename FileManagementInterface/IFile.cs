using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagementInterface
{
    interface IFile
    {
        void OpenFile();
        void ReadFile();
        void Search();
    }
}
