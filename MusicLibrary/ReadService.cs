namespace MusicLibrary;

public class ReadService: IReadService
{
    public List<Song>? ReadSongs(string? fileName)
    {
        var list = new List<Song>();
        var file = File.ReadLines(fileName ??= "listOfMusic.txt");
        var checkedFile = file.Where(x => x.Length!=0 && !x.Contains("Title"))
            .ToList();
        ;
        foreach (var item in checkedFile)
        {
            var split = item.Split('|', StringSplitOptions.TrimEntries)
                .ToList();
            if (split.Count == 0)
                break;
            list.Add(new Song(split[0], split[1], new Genre(split[2], null)));            
        }
        return list;
    }
}