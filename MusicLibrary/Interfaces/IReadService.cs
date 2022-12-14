namespace MusicLibrary;

public interface IReadService
{
       List<Song>? ReadSongs(string? path);
}