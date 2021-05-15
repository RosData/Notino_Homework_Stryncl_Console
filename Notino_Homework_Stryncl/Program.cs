using System;

namespace Notino_Homework_Stryncl
{
    public class Document
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // vstupy od někud
            StorageType storageType = StorageType.FileSystem;
            string sourceFileName = "url nebo filePath Document1.xml";
            string targetFileName = "url na cil, nebo filePath";
            TargetFormatType targetFormat = TargetFormatType.Json;

            // v reálu přes nějaké DI
            ProxyClientAPIFormatConvertor proxyClient = new ProxyClientAPIFormatConvertor();
            // podle typu storage
            IBlobStorage storage = new BlobStorageFactory().CreateBlobStorage(storageType);
            // podle ciloveho typu persist storage
            ISerializedResultStorage serializedResultStorage = new SerializedResultStorageFactory().CreateSerializedResultStorage(targetFormat, storage);


            string input;

            try
            {
                input = storage.ReadAsString(sourceFileName);

                DocToConvert docToConvert = new DocToConvert
                {
                    TargetFormat = targetFormat,
                    XmlContent = input,
                };

                // API provede konverzi
                string convertedResult = proxyClient.GetConvertedContent(docToConvert);

                serializedResultStorage.SaveConvertedContent(convertedResult, targetFileName);                
            }
            catch (Exception ex)
            {
                // TODO ILogger logger
                // zalogovat včetně StackTrace
                // logger.LogException(ex);

                // výše poslat jen stručné info
                throw new Exception("Něco se nepovedlo");
            }
        }

        // puvodni NOTINO kod
        /*
         * static void Main(string[] args)
        {
            var sourceFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\Source Files\\Document1.xml");
            var targetFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\Target Files\\Document1.json");

            try
            {
                FileStream sourceStream = File.Open(sourceFileName, FileMode.Open);
                var reader = new StreamReader(sourceStream);
                string input = reader.ReadToEnd();                                  !!! 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            var xdoc = XDocument.Parse(input);
            var doc = new Document
            {
                Title = xdoc.Root.Element("title").Value,
                Text = xdoc.Root.Element("text").Value
            };

            var serializedDoc = JsonConvert.SerializeObject(doc);

            var targetStream = File.Open(targetFileName, FileMode.Create, FileAccess.Write);
            var sw = new StreamWriter(targetStream);
            sw.Write(serializedDoc);

        }
         */

    }
}
