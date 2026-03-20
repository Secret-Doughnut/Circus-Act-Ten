/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using System.Drawing;
using System.Security.Cryptography.X509Certificates;
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

            if (!players.ContainsKey(playerId))
            {
                players.Add(playerId, points);
            }
            else
            {
                players[playerId] += points;
            }
        }

        var topPlayers = players.ToArray();
        Array.Sort(topPlayers, (player1, player2) => player2.Value - player1.Value);

        int Counter = 0;

        while (Counter != 10)
        {
            Console.WriteLine(topPlayers[Counter]);
            Counter += 1;
        }


        // Console.WriteLine($"Players: {{{string.Join(", ", players)}}}");
    }
}