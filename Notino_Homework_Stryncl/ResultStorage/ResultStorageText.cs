using System;
using System.Collections.Generic;
using System.Text;

namespace Notino_Homework_Stryncl.ResultStorage
{
    public class ResultStorageText : BaseResultStorage, ISerializedResultStorage
    {
        public ResultStorageText(ISourceBlobStorage storage, IPersistBlobStorage persistBlobStorage) : base(storage, persistBlobStorage)
        {
        }

        public void SaveConvertedContent(string input, string targetFileName)
        {
            // text na bajty
            byte[] data = Encoding.UTF8.GetBytes(input);

            this.SaveContent(targetFileName, data);
        }
    }
}
