using System;
using System.Collections.Generic;
using System.Text;

namespace Notino_Homework_Stryncl
{
    public interface ISerializedResultStorage
    {
        void SaveConvertedContent(string content, string targetFileName);
    }
}
