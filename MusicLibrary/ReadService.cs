namespace MusicLibrary;

public class ReadService: IReadService
{
    public List<Song>? ReadSongs(string? fileName)
    {
        var list = new List<Song>();
        var file = File.ReadLines(fileName ??= "listOfMusic.txt");
        // because txt file, have in first row Name of column, second empty row
        file = file.Skip(2).ToArray(); 
        foreach (var item in file)
        {
            var split = item.Split('\t', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            if (split.Count == 0)
                break;
            list.Add(new Song(split[0], split[1], new Genre(split[2], null)));            
        }
        return list;
    }
}