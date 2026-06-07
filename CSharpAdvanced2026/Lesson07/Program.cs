// See https://aka.ms/new-console-template for more information

using Lesson07;

string path = "Logs";
var files = Directory.EnumerateFiles(path, "*.txt", SearchOption.AllDirectories).Select(
    f =>new FileInfo(f)).Where( f => f.Length > 2 &&  f.LastWriteTime > DateTime.Now.AddMicroseconds(-1));

foreach (var file in files)
{
    Console.WriteLine(file.Name);    
}
/*

List<Player> players = new()
{
    new Player("DekelReiss", 42),
    new Player("KristinaAgilera", 67),
    new Player("BorisBoris", 99),
};

// add spaces between every word, only scores above 60, by descending order
var playersWithSpaces = players.Select(
    p => new Player(p.Name.AddSpaces(), p.Score)).Where(
    p => p.Score > 60).OrderByDescending(p => p.Score);


foreach (var player in playersWithSpaces)
{
    Console.WriteLine($"name = {player.Name}, Score = {player.Score}");
}*/
