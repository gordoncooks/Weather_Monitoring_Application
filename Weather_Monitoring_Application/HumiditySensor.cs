using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Weather_Monitoring_Application
{
    // Purpose: Collect humidity data
    public class HumiditySensor : Sensor
    {
        // declare constance
        double MINIMUM_HUMIDITY = 0.00;
        double MAXIMUM_HUMIDITY = 100.00;

        // constructor
        public HumiditySensor()
        {
            sensorType = "Humidity";
        }

        // create a random object
        Random random = new Random();

        // Collect and display data
        public override void CollectData(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                // Generate a random humidity data (Simulating as if real time data)
                double randomValue = random.NextDouble(); // makes the randum value
                double humidity = MINIMUM_HUMIDITY + (randomValue * (MAXIMUM_HUMIDITY - MINIMUM_HUMIDITY)); // Make the temperature value using the random value and max and min values.

                // Log the data
                LogData(humidity.ToString("F2") + "%\n");

                // Collect data every five second
                Thread.Sleep(5000);
            }
        }
    }
}