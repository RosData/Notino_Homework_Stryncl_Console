using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notino_Homework_Stryncl
{
    public class FileBlobStorage : IBlobStorage
    {
        public string ReadAsString(string filePathOrUrl)
        {
            return System.IO.File.ReadAllText(filePathOrUrl);
        }

        public void SaveContent(string targetFileName, byte[] data)
        {
            System.IO.File.WriteAllBytes(targetFileName, data);
        }
    }
}
