using System.IO;
using System.Text.Json;

public class FileHandler
{
    private string filePath;

    public FileHandler(string filePath)
    {
        this.filePath = filePath;
    }

    public T LoadData<T>()
    {
        // Read JSON data from the file and deserialize it into the specified type
        string jsonData = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(jsonData);
    }

    public void SaveData<T>(T data)
    {
        // Serialize the data object into JSON format and write it to the file
        string jsonData = JsonSerializer.Serialize(data);
        File.WriteAllText(filePath, jsonData);
    }
}
