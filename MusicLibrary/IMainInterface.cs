namespace MusicLibrary;

public interface IMainInterface
{
    void AddGenre(Genre genre);

    void RemoveGenre(string genre);   

    bool AddSong(string title, string artist, string genre);

    void RemoveSong(string song);

    /// get list of song sorted by name  
    List<Music> GetSongsBySomethingSorted(string key);
}