using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject weatherData = new WeatherData();

            _ = new CurrentConditionsDisplay(weatherData);
            _ = new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(80, 60, 30);
            weatherData.SetMeasurements(82, 70, 29);

            Console.ReadKey();
        }
    }
}
