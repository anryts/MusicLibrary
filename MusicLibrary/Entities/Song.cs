namespace MusicLibrary;

public class Song
{
    public string Title { get; private set; }
    private string Artist { get; }
    public Genre Genre { get; }

    public bool IsFavourite { get; private set; }

    public Song(string title, string artist, Genre genre)
    {
        Title = title;
        Artist = artist;
        Genre = genre;
    }
    
    public void SetFavourite()
    {
        IsFavourite = true;
    }
    
    public string GetMusicInfo()
    {
        return $"Title: {Title}, Artist: {Artist}, Genre: {Genre.Name}, Favourite: {(IsFavourite==true? "Yes" : "No")}";
    }

    public override bool Equals(object? o)
    {
        var tmp = o as Song;
        if (this.Title.Length > tmp.Title.Length)
            return true;
        return false;
    }
}