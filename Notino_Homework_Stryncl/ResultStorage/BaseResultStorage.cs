using System;
using System.Collections.Generic;
using System.Text;

namespace Notino_Homework_Stryncl.ResultStorage
{
    public class BaseResultStorage
    {
        private readonly IBlobStorage storage;
        public BaseResultStorage(IBlobStorage storage)
        {
            this.storage = storage;
        }
        

        protected void SaveContent(string targetFileName, byte[] data)
        {
            this.storage.SaveContent(targetFileName, data);
        }
    }
}
