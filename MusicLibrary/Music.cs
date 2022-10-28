namespace MusicLibrary;

public class Music
{
    private string Title { get;  }
    private string Artist { get; }
    private string Genre { get; }

    public Music(string title, string artist, string genre)
    {
        Title = title;
        Artist = artist;
        Genre = genre;
    }
    
    public string GetMusicInfo()
    {
        return $"Title: {Title}, Artist: {Artist}, Genre: {Genre}";
    }
    
}