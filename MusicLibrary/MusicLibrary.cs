namespace MusicLibrary;

public class MusicLibrary : IMusicService
{
    private readonly IReadService _readService;
    private readonly IReturnService _returnService;
    private readonly IPrintService _printService;
    private readonly IInMemoryCollection _inMemoryCollection;
    
    public MusicLibrary(IReturnService returnService, IReadService readService, IPrintService printService, IInMemoryCollection inMemoryCollection)
    {
        _returnService = returnService;
        _readService = readService;
        _printService = printService;
        _inMemoryCollection = inMemoryCollection;
    }
    
    public void AddGenre(Genre genre)
    {
        _inMemoryCollection.Genres.Add(genre);
    }

    public void RemoveGenre(string genreName)
    {
        var genre = _inMemoryCollection.Genres.FirstOrDefault(x => x.Name == genreName);
        if (genre != null)
            _inMemoryCollection.Genres.Remove(genre);
    }

    public void AddSongs(string? path)
    {
       var result = _readService.ReadSongs(path);
       _inMemoryCollection.Songs.AddRange(result);
    }
    
    public void PrintSongs()
    {
        _printService.Print(_inMemoryCollection.Songs);
    }
    
    public void AddSong(Song song)
    {
        _inMemoryCollection.Songs.Add(song);
    }

    public void RemoveSong(string titleOfSong)
    {
        var song = _inMemoryCollection.Songs.FirstOrDefault(x => x.Title == titleOfSong);
        if (song != null) 
            _inMemoryCollection.Songs.Remove(song);
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
                return _returnService.GetSongsSortedByTitle(_inMemoryCollection.Songs);
            case "genre":
                if(genre == null)
                    throw new Exception("Genre is null");
                return _returnService.GetSongsSortedByGenre(_inMemoryCollection.Songs, genre);
            default:
                return _returnService.GetSongs(_inMemoryCollection.Songs);
        }
    }
    
}