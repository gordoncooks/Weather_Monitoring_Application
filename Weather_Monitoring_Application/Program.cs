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
            // make an object for canecling threads
            CancellationTokenSource cts = new CancellationTokenSource();

            // Create a instance for each sensor

            TemperatureSensor temperatureSensor = new TemperatureSensor(); // Instance of TemperatureSensor
            HumiditySensor humiditySensor = new HumiditySensor(); // Instance of HumiditySensor
            PressureSensor pressureSensor = new PressureSensor(); // Instance of PressureSensor

            // Create threads

            Thread tempThread = new Thread(() => temperatureSensor.CollectData(cts.Token));  // Thread for temperature sensor
            Thread humThread = new Thread(() => humiditySensor.CollectData(cts.Token)); // Thread for humidity sensor
            Thread pressThread = new Thread(() => pressureSensor.CollectData(cts.Token)); // Thread for pressure sensor

            
            // Start the threads

            tempThread.Start(); // Temperature thread started
            humThread.Start(); // Humidity thread started
            pressThread.Start(); // Pressure thread started

            // Add a wait time beofre stopping threads
            Thread.Sleep(10000);

            // Request cancelations
            cts.Cancel();

            // Ensure the threads has finished
            tempThread.Join();
            humThread.Join();
            pressThread.Join();
            
        }
    }
}
