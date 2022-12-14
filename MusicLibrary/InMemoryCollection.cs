namespace MusicLibrary;

public interface IInMemoryCollection
{
    List<Song>? Songs { get; }
    List<Genre>? Genres { get; }
}

public class InMemoryCollection : IInMemoryCollection
{
    public  List<Song>? Songs { get; }
    public  List<Genre>? Genres { get; }


    public InMemoryCollection(List<Song>? songs, List<Genre>? genres)
    {
        Songs = songs ?? new List<Song>();
        Genres = genres ?? new List<Genre>();
    }
    
}