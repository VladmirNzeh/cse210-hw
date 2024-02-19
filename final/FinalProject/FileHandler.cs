using System;
using System.IO;

public class FileHandler
{
    public void SaveData(string data)
    {
        try
        {
            File.WriteAllText("data.txt", data);
            Console.WriteLine("Data saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred while saving data: {ex.Message}");
        }
    }

    public string LoadData()
    {
        try
        {
            string data = File.ReadAllText("data.txt");
            Console.WriteLine("Data loaded successfully.");
            return data;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Data file not found.");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred while loading data: {ex.Message}");
            return null;
        }
    }
}
