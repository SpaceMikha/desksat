# DeskSatellite

## Overview
**DeskSatellite** is a simple Raspberry Pi-based stationary satellite project designed to collect and display environmental data. It retrieves temperature and humidity readings from a **DHT11 sensor**, logs the data, provides a web API for access, and offers integration with databases, MQTT, and cloud services. 

This project is **intended to be a starting point**, allowing you to modify and expand it according to your needs. You can integrate additional sensors, enhance data visualization, or connect it to IoT platforms.

---

## Features
 **Sensor Data Retrieval** - Reads temperature and humidity from a DHT11 sensor.  
 **LCD Display** - Displays real-time sensor data on a 16x2 LCD screen (I2C).  
 **Web API** - Exposes sensor data via an ASP.NET Core API (`/data`).  
 **Data Logging** - Logs all sensor readings in a local file (`sensor_data.log`).  
 **SQLite Database Storage** - Stores historical sensor data for later analysis.  
 **MQTT Integration** - Publishes sensor data to an MQTT broker for IoT applications.  
 **Cloud Upload** - Sends sensor data to a remote API for external processing.  

---

## Hardware Requirements
- Raspberry Pi (Recommended: 4B or 3B+)
- **DHT11** Temperature & Humidity Sensor
- **16x2 LCD Display** (I2C)
- Jumper Wires
- 10KΩ Resistor for DHT11

### Wiring Instructions
#### **DHT11 Sensor**
| DHT11 Pin | Raspberry Pi GPIO |
|-----------|-------------------|
| VCC       | 3.3V (Pin 1)      |
| Data      | GPIO4 (Pin 7)     |
| GND       | GND (Pin 6)       |

#### **LCD Display (I2C)**
| LCD Pin | Raspberry Pi GPIO |
|---------|-------------------|
| SDA     | GPIO2 (Pin 3)      |
| SCL     | GPIO3 (Pin 5)      |
| VCC     | 5V (Pin 2)         |
| GND     | GND (Pin 6)        |

---

## Installation & Usage
### **1️⃣ Install Dependencies**
```sh
sudo apt update
sudo apt install dotnet-sdk-6.0 sqlite3
```

### **2️⃣ Clone the Repository & Run**
```sh
git clone https://github.com/spacemikha/DeskSatellite.git
cd DeskSatellite
dotnet run
```

### **3️⃣ Access the Web API**
Once running, you can access sensor data via:
```
http://YOUR_RASPBERRY_PI_IP:5000/data
```

### **4️⃣ View Logged Data**
```sh
cat sensor_data.log
sqlite3 database.db "SELECT * FROM SensorData;"
```

---

## Customization
This project is designed to be easily **modified and expanded**. You can:
- **Add More Sensors** (Air Quality, GPS, Light Sensor, etc.)
- **Connect to Cloud Platforms** (Azure, AWS, Firebase, Google Cloud)
- **Improve Visualization** (OLED display, graphical UI, dashboards)
- **Enhance IoT Connectivity** (LoRaWAN, Zigbee, Bluetooth, etc.)

---

## License
This project is open-source and provided under the **MIT License**. Feel free to modify and distribute it.


---

## Disclaimer
**This is a simple experimental project** meant for learning purposes. It is **not intended for critical applications**. Modify and use it at your own discretion.

---

## Contact
For any questions or suggestions, feel free to reach out via GitHub Issues or email.

Happy coding!
