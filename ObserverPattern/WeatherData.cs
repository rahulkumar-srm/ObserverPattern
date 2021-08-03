using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature, humidity, pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach(var observer  in observers)
                observer.Update(temperature, humidity, pressure);
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            int index = observers.IndexOf(observer);
            if(index >= 0)
                observers.RemoveAt(index);
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementChanged();
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }
    }
}
