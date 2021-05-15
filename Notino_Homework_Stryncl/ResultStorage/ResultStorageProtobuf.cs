using System;
using System.Collections.Generic;
using System.Text;

namespace Notino_Homework_Stryncl.ResultStorage
{
    public class ResultStorageProtobuf : BaseResultStorage, ISerializedResultStorage
    {
        public ResultStorageProtobuf(IBlobStorage storage):base(storage)
        {            
        }

        public void SaveConvertedContent(string input, string targetFileName)
        {
            // vime, že jde o Base64
            byte[] data = Convert.FromBase64String(input);

            this.SaveContent(targetFileName, data);
        }
    }
}
