using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataTest
{
    class PrintData
    {
        public static void PrintDataToConsole(WeatherData data)
        {
            //Coord
            Console.WriteLine(data.coord.lon);
            Console.WriteLine(data.coord.lat);
            Console.WriteLine();

            //Weather
            int a = 1;
            foreach (var item in data.weather)
            {
                Console.WriteLine("Weather Item: " + a.ToString());
                Console.WriteLine(item.id);
                Console.WriteLine(item.main);
                Console.WriteLine(item.description);
                Console.WriteLine(item.icon);
                Console.WriteLine();
                a++;
            }

            //Base
            Console.WriteLine(data.@base);
            Console.WriteLine();
            //Main
            Console.WriteLine(data.main.temp);
            Console.WriteLine(data.main.pressure);
            Console.WriteLine(data.main.humidity);
            Console.WriteLine(data.main.temp_min);
            Console.WriteLine(data.main.temp_max);
            Console.WriteLine();
            //Visiblity
            Console.WriteLine(data.visibility);
            Console.WriteLine();
            //Wind
            Console.WriteLine(data.wind.speed);
            Console.WriteLine(data.wind.deg);
            Console.WriteLine();
            //Clouds
            Console.WriteLine(data.clouds.all);
            Console.WriteLine();
            //Data Time
            Console.WriteLine(data.dt);
            Console.WriteLine();
            //Sys
            Console.WriteLine(data.sys.type);
            Console.WriteLine(data.sys.id);
            Console.WriteLine(data.sys.message);
            Console.WriteLine(data.sys.country);
            Console.WriteLine(data.sys.sunrise);
            Console.WriteLine(data.sys.sunset);
            Console.WriteLine();
            //Timezone
            Console.WriteLine(data.timezone);
            Console.WriteLine();
            //ID
            Console.WriteLine(data.id);
            Console.WriteLine();
            //Name
            Console.WriteLine(data.name);
            Console.WriteLine();
            //COD
            Console.WriteLine(data.cod);
        }
    }
}
