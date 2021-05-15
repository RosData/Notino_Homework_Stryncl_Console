using System;
using System.Collections.Generic;
using System.Text;

namespace Notino_Homework_Stryncl.ResultStorage
{
    public class BaseResultStorage
    {
        private readonly ISourceBlobStorage storage;
        private readonly IPersistBlobStorage persistBlobStorage;
        public BaseResultStorage(ISourceBlobStorage storage, IPersistBlobStorage persistBlobStorage)
        {
            this.storage = storage;
            this.persistBlobStorage = persistBlobStorage;
        }


        protected void SaveContent(string targetFileName, byte[] data)
        {
            this.persistBlobStorage.SaveContent(targetFileName, data);
        }
    }
}
