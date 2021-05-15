using System;
using System.Collections.Generic;
using System.Text;

namespace Notino_Homework_Stryncl
{
    public class ProxyClientAPIFormatConvertor
    {
        public string GetConvertedContent(DocToConvert docToConvert) {

            // zavolat API
            /*
            var responseText = zavolat API a získat json text
            deserializovat na ConvertedResult
            ConvertedResult typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<ConvertedResult>(responseText, JsonSerializerSettings);
            */

            return @"{json obsah, base64 dle TargetFormatType";
        }
    }

    public class DocToConvert
    {
        public TargetFormatType TargetFormat { get; set; }
        public string XmlContent { get; set; }
    }

    public class ConvertedResult
    {
        public TargetFormatType TargetFormat { get; set; }
        public string Content { get; set; }
    }

    public enum TargetFormatType
    {
        Json = 0,
        Protobuf = 1,
        // dalsi formaty ..

    }
}
