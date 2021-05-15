using Notino_Homework_Stryncl.ResultStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notino_Homework_Stryncl
{
    public class SerializedResultStorageFactory
    {
        public ISerializedResultStorage CreateSerializedResultStorage(TargetFormatType targetFormat, ISourceBlobStorage storage, IPersistBlobStorage persistBlobStorage)
        {
            switch (targetFormat)
            {
                case TargetFormatType.Json:
                    return new ResultStorageText(storage, persistBlobStorage);
                case TargetFormatType.Protobuf:
                    return new ResultStorageProtobuf(storage, persistBlobStorage);
                default:
                    throw new Exception("Neznámý");
            }
            
        }
    }
}
