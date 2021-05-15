using System;
using System.Collections.Generic;
using System.Text;

namespace Notino_Homework_Stryncl
{
    public interface IPersistBlobStorage
    {
        void SaveContent(string targetFileName, byte[] data);
    }
}
