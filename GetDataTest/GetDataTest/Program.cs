using System;

namespace GetDataTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = MakeRequest.MakeHttpRequest();
            var deserializedData = MakeRequest.DeserializeResponseData(data);

            PrintData.PrintDataToConsole(deserializedData);

            Console.ReadLine();
        }
    }
}
