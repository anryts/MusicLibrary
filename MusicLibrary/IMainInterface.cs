namespace MusicLibrary;

public interface IMainInterface
{
    void AddGenre(Genre genre);

    void RemoveGenre(string genre);   

    void AddSong(Music song);

    void RemoveSong(string song);

    /// get list of song sorted by name  
    List<Music> GetSongsBySomethingSorted(string key);
}