# initial Hardware Setup for DeskSatellite

## Required Components:
- Raspberry Pi (4B or 3B+ recommended)
- DHT11 Temperature & Humidity Sensor
- 16x2 LCD Display (I2C)
- GPIO Jumper Wires
- Resistors (10KΩ for DHT11)

## Wiring Instructions:
- DHT11:
  - VCC → 3.3V (Pin 1)
  - Data → GPIO4 (Pin 7) + 10KΩ Pull-up Resistor
  - GND → GND (Pin 6)

- LCD Display (I2C):
  - SDA → GPIO2 (Pin 3)
  - SCL → GPIO3 (Pin 5)
  - VCC → 5V (Pin 2)
  - GND → GND (Pin 6)
