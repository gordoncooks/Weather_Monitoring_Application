using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Weather_Monitoring_Application
{
    // Purpose: Collect temperature data
    public class TemperatureSensor : Sensor
    {

        // declare constance
        double MINIMUM_TEMPERATURE = -15.00;
        double MAXIMUM_TEMPERATURE = 40.00;

        // Create a random object
        Random random = new Random();


        // constructer
        public TemperatureSensor()
        {
            sensorType = "Temperature";
        }

        // Colect and display data.
        public override void CollectData()
        {
            while (true)
            {
                // generate a random temperature data (Simulating as if real time data)
                double randomValue = random.NextDouble(); // makes the randum value
                double temperature = MINIMUM_TEMPERATURE + ( randomValue * ( MAXIMUM_TEMPERATURE - MINIMUM_TEMPERATURE ) ); // make the temperature value using the random value and max and min values.

                // Log the data
                LogData(temperature.ToString("F2") + "°C\n");

                // Collect data every one second
                Thread.Sleep(1000);
            }
        }


    }
}
