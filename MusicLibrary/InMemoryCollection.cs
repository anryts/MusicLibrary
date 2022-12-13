namespace MusicLibrary;

public static class InMemoryCollection
{
    public static List<Song> Songs { get; } = new List<Song>();
    public static List<Genre> Genres { get; } = new List<Genre>();
}