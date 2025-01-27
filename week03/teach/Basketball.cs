using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row

        while (!reader.EndOfData)
        {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);

            // Update player's total points in the dictionary
            if (players.ContainsKey(playerId))
            {
                players[playerId] += points;
            }
            else
            {
                players[playerId] = points;
            }
        }

        // Get the top 10 players by total points
        var topPlayers = players
            .OrderByDescending(x => x.Value) // Order by descending points
            .Take(10) // Take top 10 players
            .Select(x => $"{x.Key}: {x.Value}") // Format player and points
            .ToArray();

        // Display top 10 players
        Console.WriteLine("Top 10 Players by Total Points:");
        foreach (var player in topPlayers)
        {
            Console.WriteLine(player);
        }
    }
}