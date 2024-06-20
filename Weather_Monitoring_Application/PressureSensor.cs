using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Weather_Monitoring_Application
{
    // Purpose: Collet pressure data
    public class PressureSensor : Sensor
    {
        // declare constance
        double MINIMUM_PRESSURE = 0.00;
        double MAXIMUM_PRESSURE = 1000.00;

        // Constructor
        public PressureSensor()
        {
            sensorType = "Pressure";
        }

        // Create a random object
        Random random = new Random();

        // Colect data and display
        public override void CollectData()
        {
            while (true)
            {
                // Generate a random pressure data (Simulating as if real time data)
                double randomValue = random.NextDouble(); // makes the randum value
                double pressure = MINIMUM_PRESSURE + (randomValue * (MAXIMUM_PRESSURE - MINIMUM_PRESSURE)); // Make the temperature value using the random value and max and min values.

                // Log the data
                LogData(pressure.ToString("F2") + "kPa\n");

                // Collect data every five second
                Thread.Sleep(5000);
            }
            
        }
    }
}
