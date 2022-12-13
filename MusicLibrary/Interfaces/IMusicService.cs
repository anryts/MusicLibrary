namespace MusicLibrary;

public interface IMusicService
{
    void AddGenre(Genre genre);

    void RemoveGenre(string genre);   

    void AddSong(Song song);

    void RemoveSong(string titleOfSong);

    List<Song> GetSongsBySomethingSorted(string key, Genre genre);
}