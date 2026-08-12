using System.Text.Json;
using DesafioBatch.Models;

namespace DesafioBatch.Services;

public class JsonlReader
{
    public IEnumerable<Club> Read(string filePath)
    {
        using var reader = new StreamReader(filePath);

        string? line;

        while ((line = reader.ReadLine()) != null)
        {
            Club? club = null;

            try
            {
                club = JsonSerializer.Deserialize<Club>(line);
            }
            catch
            {
                // Ignora linhas com JSON inválido
            }

            if (club != null)
            {
                yield return club;
            }
        }
    }
}