using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Monitoring_Application
{
    // Purpose: Serve as a common bese for all sensor types
    public abstract class Sensor
    {
        
        // constructer
        public string sensorType { get; set; }

        // colect the data and log it
        public abstract void CollectData();

        // Log the data to the terminal
        protected void LogData(string data)
        {
            Console.WriteLine($"{sensorType} Data: {data}");
        }
    }
}
