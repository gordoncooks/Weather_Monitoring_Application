# Weather Monitoring Application

This repository contains a C# Weather Monitoring Application that simulates data collection from various sensors. The sensors include Temperature, Humidity, and Pressure sensors. The application demonstrates multi-threaded programming by simulating concurrent data collection from these sensors.

## Files Included

- **Sensor.cs**
- **TemperatureSensor.cs**
- **HumiditySensor.cs**
- **PressureSensor.cs**
- **Program.cs**

## Overview

The Weather Monitoring Application is designed to simulate the collection of weather data from multiple types of sensors concurrently. Each sensor type collects data at regular intervals and logs the collected data to the console.

### Sensor.cs

- **Description:** This abstract base class serves as a common foundation for all sensor types.
- **Key Components:**
  - `sensorType` property
  - `CollectData` abstract method
  - `LogData` method

### TemperatureSensor.cs

- **Description:** This class inherits from `Sensor` and simulates the collection of temperature data.
- **Key Components:**
  - Constants for minimum and maximum temperature values
  - `CollectData` method generates random temperature data and logs it every 5 seconds

### HumiditySensor.cs

- **Description:** This class inherits from `Sensor` and simulates the collection of humidity data.
- **Key Components:**
  - Constants for minimum and maximum humidity values
  - `CollectData` method generates random humidity data and logs it every 5 seconds

### PressureSensor.cs

- **Description:** This class inherits from `Sensor` and simulates the collection of pressure data.
- **Key Components:**
  - Constants for minimum and maximum pressure values
  - `CollectData` method generates random pressure data and logs it every 5 seconds

### Program.cs

- **Description:** This is the main entry point of the application. It initializes and starts threads for each sensor to simulate concurrent data collection.
- **Key Components:**
  - Initialization of `CancellationTokenSource`
  - Creation and starting of threads for each sensor
  - Graceful stopping of threads after a specified period

## Usage

To run the application, execute the `Program` class. The application will:
1. Create instances of `TemperatureSensor`, `HumiditySensor`, and `PressureSensor`.
2. Start threads for each sensor to collect data concurrently.
3. Collect and log data from each sensor every 5 seconds.
4. Stop the threads after 10 seconds and ensure all threads have completed their execution.

## Example Output

When the application runs, it will log the following types of data:

```
Temperature Data: 23.45°C
Humidity Data: 56.78%
Pressure Data: 789.01kPa
```

Each type of sensor data will be collected and displayed at regular intervals.

## Requirements

- .NET Framework or .NET Core
- Visual Studio or any C# compatible IDE

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/weather-monitoring-application.git
   ```
2. Open the project in your preferred C# IDE.
3. Build and run the application.

## Contributing

Contributions are welcome! Please submit a pull request or open an issue to discuss your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
