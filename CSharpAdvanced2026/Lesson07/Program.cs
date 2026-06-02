// See https://aka.ms/new-console-template for more information

using Lesson07;


List<Player> players = new()
{
    new Player("DekelReiss", 42),
    new Player("KristinaAgilera", 67),
    new Player("BorisBoris", 99),
};

var playersWithSpaces = players.Select(p => new Player(p.Name.AddSpaces(), p.Score)).Where(p => p.Score > 60).OrderByDescending(p => p.Score);
foreach (var player in playersWithSpaces)
{
    Console.WriteLine($"name = {player.Name}, Score = {player.Score}");
}
