using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notino_Homework_Stryncl
{
    public class GoogleBlobStorage : IBlobStorage
    {
        public string ReadAsString(string filePathOrUrl)
        {
            throw new NotImplementedException();
        }

        public void SaveContent(string targetFileName, byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
