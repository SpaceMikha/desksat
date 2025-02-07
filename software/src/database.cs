using System;
using System.Data.SQLite;

public class Database
{
    private static string dbPath = "Data Source=database.db";

    public static void Initialize()
    {
        using var conn = new SQLiteConnection(dbPath);
        conn.Open();

        string tableQuery = @"
            CREATE TABLE IF NOT EXISTS SensorData (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
                temperature INTEGER,
                humidity INTEGER
            )";
        using var cmd = new SQLiteCommand(tableQuery, conn);
        cmd.ExecuteNonQuery();
    }

    public static void StoreData(int temperature, int humidity)
    {
        using var conn = new SQLiteConnection(dbPath);
        conn.Open();

        string insertQuery = "INSERT INTO SensorData (temperature, humidity) VALUES (@temp, @humid)";
        using var cmd = new SQLiteCommand(insertQuery, conn);
        cmd.Parameters.AddWithValue("@temp", temperature);
        cmd.Parameters.AddWithValue("@humid", humidity);
        cmd.ExecuteNonQuery();

        Console.WriteLine("Data stored in database.");
    }
}
