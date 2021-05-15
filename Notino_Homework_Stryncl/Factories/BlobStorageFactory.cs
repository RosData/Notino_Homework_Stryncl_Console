﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notino_Homework_Stryncl
{
    public class BlobStorageFactory
    {
        public IBlobStorage CreateBlobStorage(StorageType storageType)
        {
            switch (storageType)
            {
                case StorageType.FileSystem:
                    return new FileBlobStorage();
                case StorageType.Azure:
                    return new AzureBlobStorage();
                case StorageType.Google:
                    return new GoogleBlobStorage();
                case StorageType.Web:
                    return new WebBlobStorage();
                default:
                    throw new NotImplementedException($"Neimplementovan {storageType}");
            }
        }
    }
}
