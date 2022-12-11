namespace MusicLibrary;

public class MusicLibrary : IMusicService
{
    private readonly List<Song> _listOfSongs;
    private readonly List<Genre> _listOfGenres;

    public MusicLibrary()
    {
        _listOfGenres = new List<Genre>();
        _listOfSongs = new List<Song>();
    }
    
    public MusicLibrary(List<Song>? listOfSongs, List<Genre>? listOfGenres)
    {
        _listOfSongs = listOfSongs ?? new List<Song>();
        _listOfGenres = listOfGenres ?? new List<Genre>();
        
        foreach (var song in _listOfSongs.Where(song => song.Genre.Name.Length!=0 && !_listOfGenres.Contains(song.Genre)))
        {
            _listOfGenres.Add(song.Genre);
        }
    }
    
    public void AddGenre(Genre genre)
    {
        _listOfGenres.Add(genre);
    }

    public void RemoveGenre(string genreName)
    {
        var genre = _listOfGenres.FirstOrDefault(x => x.Name == genreName);
        
    }

    public void AddSong(Song song)
    {
        _listOfSongs.Add(song);
    }

    public void RemoveSong(string titleOfSong)
    {
        var song = _listOfSongs.FirstOrDefault(x => x.Title == titleOfSong);
    }
    
    public List<Song> GetSongsBySomethingSorted(string key)
    {
        switch (key)
        {
            case "favorites":
                return _listOfSongs;
            case "genre":
                return _listOfSongs;
            default:
                throw new Exception("key is not correct");
        }
    }
    
    
}