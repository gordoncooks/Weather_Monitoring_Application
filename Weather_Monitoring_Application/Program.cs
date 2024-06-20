using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Weather_Monitoring_Application
{
    // Purpose: Initialize and start threads for each sensor to simulate concurrent data collection.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a instance for each sensor
            
            TemperatureSensor temperatureSensor = new TemperatureSensor(); // Instance of TemperatureSensor
            HumiditySensor humiditySensor = new HumiditySensor(); // Instance of HumiditySensor
            PressureSensor pressureSensor = new PressureSensor(); // Instance of PressureSensor

            // Create threads

            Thread tempThread = new Thread(new ThreadStart(temperatureSensor.CollectData)); // Thread for temperature sensor
            Thread humThread = new Thread(new ThreadStart(humiditySensor.CollectData)); // Thread for humidity sensor
            Thread pressThread = new Thread(new ThreadStart(pressureSensor.CollectData)); // Thread for pressure sensor

            // Start the threads

            tempThread.Start(); // Temperature thread started
            humThread.Start(); // Humidity thread started
            pressThread.Start(); // Pressure thread started
        }
    }
}
