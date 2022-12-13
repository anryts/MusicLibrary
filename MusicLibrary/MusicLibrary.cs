namespace MusicLibrary;

public class MusicLibrary : IMusicService
{
    private readonly IReadService _readService;
    private readonly IReturnService _returnService;
    private readonly IPrintService _printService;

    public MusicLibrary(IReturnService returnService, IReadService readService, IPrintService printService)
    {
        _returnService = returnService;
        _readService = readService;
        _printService = printService;
    }
    
    public void AddGenre(Genre genre)
    {
        InMemoryCollection.Genres.Add(genre);
    }

    public void RemoveGenre(string genreName)
    {
        var genre = InMemoryCollection.Genres.FirstOrDefault(x => x.Name == genreName);
        
    }

    public void AddSongs(string? path)
    {
       var result = _readService.ReadSongs(path);
       InMemoryCollection.Songs.AddRange(result);
    }
    
    public void PrintSongs()
    {
        _printService.Print(InMemoryCollection.Songs);
    }
    
    public void AddSong(Song song)
    {
        InMemoryCollection.Songs.Add(song);
    }

    public void RemoveSong(string titleOfSong)
    {
        var song = InMemoryCollection.Songs.FirstOrDefault(x => x.Title == titleOfSong);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="key">favorites or genre</param>
    /// <param name="genre">optionally</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public List<Song> GetSongsBySomethingSorted(string key, Genre? genre)
    {
        switch (key)
        {
            case "favorites":
                return _returnService.GetSongsSortedByTitle();
            case "genre":
                return _returnService.GetSongsSortedByGenre(genre);
            default:
                throw new Exception("key is not correct");
        }
    }
    
    
}