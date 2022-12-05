namespace MusicLibrary;

public class MusicLibrary : IMainInterface
{
    private List<Music> _musicList = new List<Music>();

    public void ReadSongFromFile(string fileName)
    {
        var file = File.ReadLines("listOfMusic.txt");
        file = file.Skip(2).ToArray();
        foreach (var item in file)
        {
            try
            {
                var split = item.Split('\t', StringSplitOptions.RemoveEmptyEntries).ToList();
                AddSong(split[0], split[1], split[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public void ConsolePrintMusicList()
    {
        foreach (var music in _musicList)
        {
            Console.WriteLine(music.GetMusicInfo());
        }
    }

    public void AddGenre(Genre genre)
    {
        throw new NotImplementedException();
    }

    public void RemoveGenre(string genre)
    {
        throw new NotImplementedException();
    }

    public void AddSong(string title, string artist, string genre)
    {
        Music new_music = new Music(title, artist, genre);
        _musicList.Add(new_music);
    }

    public void RemoveSong(string song)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// key can be "genre" or "name"
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public List<Music> GetSongsBySomethingSorted(string key)
    {
        throw new NotImplementedException();
    }
}