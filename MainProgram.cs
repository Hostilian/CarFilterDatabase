using System;
using System.Collections.Generic;

class Program
{
    static CarDatabase carDB = new CarDatabase();

    static void Main(string[] args)
    {
        carDB.LoadData("Data/car_data.txt"); // Load data from file

        bool showMenu = true;
        while (showMenu)
        {
            showMenu = MainMenu();
        }
    }

    static bool MainMenu()
    {
        Console.WriteLine("\nCar Database Menu:");
        Console.WriteLine("1. Display All Cars");
        Console.WriteLine("2. Search by Make");
        Console.WriteLine("3. Filter by Year");
        // ... (Add more menu options)
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice: ");

        switch (Console.ReadLine())
        {
            case "1":
                DisplayAllCars();
                return true;
            case "2":
                SearchByMake();
                return true;
            case "3":
                FilterByYear();
                return true;
            // ... (Handle other menu options)
            case "0":
                return false;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return true;
        }
    }

    static void DisplayAllCars()
    {
        // ... (Implement logic to display all cars)
        foreach (var car in carDB.cars)
        {
            Console.WriteLine(car); // You'll likely want to format this output
        }
    }

    static void SearchByMake()
    {
        Console.Write("Enter the make to search for: ");
        string make = Console.ReadLine();

        // ... (Implement search logic using LINQ)
        var results = carDB.cars.Where(c => c.Make.Equals(make, StringComparison.OrdinalIgnoreCase));

        foreach (var car in results)
        {
            Console.WriteLine(car); // Format output as needed
        }
    }

    static void FilterByYear()
    {
        Console.Write("Enter the minimum year: ");
        int minYear;
        if (!int.TryParse(Console.ReadLine(), out minYear))
        {
            Console.WriteLine("Invalid year input.");
            return;
        }

        // ... (Implement filtering logic using LINQ)
        var results = carDB.cars.Where(c => c.Year >= minYear);

        foreach (var car in results)
        {
            Console.WriteLine(car); // Format output as needed
        }
    }

    // ... (Add more methods for other menu options)
}