using System;
using System.Collections.Generic;

namespace CourseItemList
{
    class Program
    {
        static void Main(string[] args)
        {
            //READ THE JSON FILE FOUND AT THE PATH WE SPECIFY AND RETURN A STRING
            string fileAsText = GatherData.GetDataAsStringFromJsonFile(GatherData.GetFilePath());

            //DESERIALIZE THE STRING INTO THE OBJECTS FOUND IN THE JSON FILE USING NEWTONSOFT.JSON INTO A LIST OF OBJECTS
            List<ItemInfo> ItemInfos = GatherData.GetDeserializedData(fileAsText);

            //LOOP OVER THE ANIMAL INFO IN THE LIST OF ANIMAL INFO
            foreach (var itemInfo in ItemInfos)
            {
                //WRITE THE ANIMAL INFO
                Console.WriteLine("ID: " + itemInfo.ID);
                Console.WriteLine("Name: " + itemInfo.Name);
                Console.WriteLine("BackgroundInfo: " + itemInfo.Description.BackgroundInfo);
                Console.WriteLine("Address: " + itemInfo.Description.Location.Address);
                Console.WriteLine("City: " + itemInfo.Description.Location.City);
                Console.WriteLine("State: " + itemInfo.Description.Location.State);
                Console.WriteLine("ZIP: " + itemInfo.Description.Location.ZIP);
                Console.WriteLine();
            }

            //WAIT FOR THE USER TO HIT ENTER, THEN CLOSE THE APPLICAITON
            Console.ReadLine();
        }
    }
}
