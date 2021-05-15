using Notino_Homework_Stryncl.ResultStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notino_Homework_Stryncl
{
    public class SerializedResultStorageFactory
    {
        public ISerializedResultStorage CreateSerializedResultStorage(TargetFormatType targetFormat, IBlobStorage storage)
        {
            switch (targetFormat)
            {
                case TargetFormatType.Json:
                    return new ResultStorageText(storage);
                case TargetFormatType.Protobuf:
                    return new ResultStorageProtobuf(storage);
                default:
                    throw new Exception("Neznámý");
            }
            
        }
    }
}
