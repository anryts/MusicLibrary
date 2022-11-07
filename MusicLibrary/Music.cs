namespace MusicLibrary;

public class Music
{
    private string Title { get;  }
    private string Artist { get; }
    private string GenreName { get; }

    private bool IsFavourite { get; set; }

    public Music(string title, string artist, string genre)
    {
        Title = title;
        Artist = artist;
        GenreName = genre;
    }
    
    public void SetFavourite()
    {
        IsFavourite = true;
    }
    
    public string GetMusicInfo()
    {
        return $"Title: {Title}, Artist: {Artist}, Genre: {GenreName}, Favourite: {(IsFavourite==true? "Yes" : "No")}";
    }
    
}