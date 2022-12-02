namespace MusicLibrary;

public interface IMainInterface
{
    void AddGenre(Genre genre);

    void RemoveGenre(string genre);   

    void AddSong(Music song);

    void RemoveSong(string song);

    /// get list of song sorted by name  
    List<Music> GetSongsByNamesSorted();

    /// get list of song for a given genre
    List<Music> GetSongsByGenre(string genre);
    
}