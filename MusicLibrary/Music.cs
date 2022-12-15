namespace MusicLibrary;

public class Music
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string GenreName { get; set; }

    public bool IsFavourite { get; set; }

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