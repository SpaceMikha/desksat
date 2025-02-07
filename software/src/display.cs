using System;
using System.Device.Gpio;
using System.Device.I2c;
using Iot.Device.CharacterLcd;

public class Display
{
    private static I2cDevice i2cDevice = I2cDevice.Create(new I2cConnectionSettings(1, 0x27));
    private static Lcd1602 lcd = new Lcd1602(i2cDevice);

    public static void ShowData(int temperature, int humidity)
    {
        lcd.Clear();
        lcd.Write($"Temp: {temperature}°C");
        lcd.SetCursorPosition(0, 1);
        lcd.Write($"Humidity: {humidity}%");
    }
}
