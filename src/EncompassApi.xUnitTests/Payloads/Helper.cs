using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EncompassApi.xUnitTests.Payloads
{
    public static class Helper
    {

        public static void SaveJsonFile(string fileName, string filePath,  string jsn)
        {
            var fullPath = $"{filePath}/Payloads/{fileName}.json";

            // Get the absolute path to the JSON file
            var path = Path.IsPathRooted(fullPath)
                ? fullPath
                : Path.GetRelativePath(Directory.GetCurrentDirectory(), fullPath);

            //// Write that JSON to txt file,  
            //var read = System.IO.File.ReadAllText(path + "output.json");
            System.IO.File.WriteAllText(path, jsn, Encoding.UTF8);
        }

        public static JObject[] GetArray(string fileName)
        {
            var fullPath = $"Payloads/{fileName}.json";

            // Get the absolute path to the JSON file
            var path = Path.IsPathRooted(fullPath)
                ? fullPath
                : Directory.GetCurrentDirectory() + "/" + fullPath;
            Assert.True(File.Exists(path), $"FIle {fileName}.json doesn't exist!");
            //if (!File.Exists(path))
            //{

            //    throw new ArgumentException($"Could not find file at path: {path}");
            //}
            // Load the file
            var fileData = File.ReadAllText(fullPath);
            return JsonConvert.DeserializeObject<JObject[]>(fileData);
        }

        public static JObject[] GetLoanDocuments() => GetArray("LoanDocuments");
        public static JObject[] GetLoanAttachments() => GetArray("LoanAttachments");

        public static JObject Get(string fileName)
        {
            var fullPath = $"Payloads/{fileName}.json";

            // Get the absolute path to the JSON file
            var path = Path.IsPathRooted(fullPath)
                ? fullPath
                : Directory.GetCurrentDirectory() + "/" + fullPath;
            Assert.True(File.Exists(path), $"FIle {fileName}.json doesn't exist!");

            //if (!File.Exists(path))
            //{
            //    throw new ArgumentException($"Could not find file at path: {path}");
            //}
            // Load the file
            var fileData = File.ReadAllText(fullPath);
            var objs = JsonConvert.DeserializeObject<JObject[]>(fileData);
            return objs[0];
        }

        public static JObject GetLoanDocument() => Get("LoanDocuments");
        public static JObject GetMediaUrlObject() => Get("MediaUrlObject");
    }
}
