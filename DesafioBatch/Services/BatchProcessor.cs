using DesafioBatch.Models;

namespace DesafioBatch.Services;

public class BatchProcessor
{
    private readonly JsonlReader _jsonlReader;
    private readonly CsvWriter _csvWriter;

    public BatchProcessor(JsonlReader jsonlReader, CsvWriter csvWriter)
    {
        _jsonlReader = jsonlReader;
        _csvWriter = csvWriter;
    }

    public void Process(
        string inputPath,
        string clubsOutputPath,
        string playersOutputPath)
    {
        using var clubsWriter = new StreamWriter(clubsOutputPath);
        using var playersWriter = new StreamWriter(playersOutputPath);

        _csvWriter.WriteLine(
            clubsWriter,
            new[]
            {
                "ClubId",
                "Name",
                "Championship",
                "FoundingDate",
                "City",
                "State",
                "Country",
                "Stadium",
                "President",
                "Nickname",
                "Colors"
            });

        _csvWriter.WriteLine(
            playersWriter,
            new[]
            {
                    "ClubId",
                    "PlayerId",
                    "Name",
                    "Age",
                    "Goals",
                    "DebutDate",
                    "Position",
                    "ShirtNumber"
            });

        foreach (var club in _jsonlReader.Read(inputPath))
        {
            if (club.Championship != "SERIE A" &&
                club.Championship != "SERIE B")
            {
                continue;
            }

            _csvWriter.WriteLine(
                clubsWriter,
                new[]
                {
                    club.ClubId,
                    club.Name,
                    club.Championship,
                    DateUtils.FormatDate(club.FoundingDate),
                    club.City,
                    club.State,
                    club.Country,
                    club.Stadium,
                    club.President,
                    club.Nickname,
                    string.Join("|", club.Colors ?? [])
                });

            foreach (var player in club.Players ?? [])
            {
                _csvWriter.WriteLine(
                    playersWriter,
                    new[]
                    {
                        club.ClubId,
                        player.PlayerId,
                        player.Name,
                        player.Age?.ToString(),
                        player.Goals?.ToString(),
                        DateUtils.FormatDate(player.DebutDate),
                        player.Position,
                        player.ShirtNumber?.ToString()
                    });
            }
        }
    }
}