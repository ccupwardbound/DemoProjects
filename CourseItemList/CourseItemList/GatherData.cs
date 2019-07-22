using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace CourseItemList
{
    class GatherData
    {
        public static string GetFilePath()
        {
            //RETURNS THE PATH TO THE JSON FILE IN THE PROJECT
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ItemInformation.json");
        }

        public static string GetDataAsStringFromJsonFile(string path)
        {
            //RETURN THE JSON DATA FOUND AT THE PATH AS A STRING
            return File.ReadAllText(path);
        }

        public static List<ItemInfo> GetDeserializedData(string data)
        {
            //RETURN DESERIALIZED OBJECTS FOUND IN THE JSON FILE USING NEWTONSOFT.JSON
            return JsonConvert.DeserializeObject<List<ItemInfo>>(data);
        }
    }
}
