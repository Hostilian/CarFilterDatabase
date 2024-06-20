using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class CarDatabase
{
    private List<Car> cars = new List<Car>();

    public void LoadData(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            // Skip the header line if it exists
            for (int i = 1; i < lines.Length; i++)
            {
                cars.Add(new Car(lines[i]));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading data: " + ex.Message);
        }
    }

    // ... (Add methods for filtering, sorting, statistics, etc.)
}