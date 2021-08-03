using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private ISubject whetherData;
        private float temperature, humidity, pressure;

        public CurrentConditionsDisplay(ISubject whetherData)
        {
            this.whetherData = whetherData;
            whetherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current Conditions : " + temperature + "F degrees and " + humidity + "% humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }
    }
}
