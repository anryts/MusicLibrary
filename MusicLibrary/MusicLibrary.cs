namespace MusicLibrary;

public class MusicLibrary : IMainInterface
{
    private List<Music> musicList = new List<Music>();
    private List<string> not_polite_words = new List<string>() { "@$!&*(", "%^&&@", "!@)^&$#"};
    private List<Genre> genres = new List<Genre>();

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
        foreach (var music in musicList)
        {
            Console.WriteLine(music.GetMusicInfo());
        }
    }
    public void AddGenre(Genre genre)
    {
        if (genre is null)
            throw new ArgumentNullException(nameof(genre));

        if (genre.Name.Length is 0 || genre.Description.Length is 0)
            throw new ArgumentException("Name or Description length was 0");
        genres.Add(genre);
    }

    public void RemoveGenre(string genre)
    {
        if (genre.Length is 0) throw new ArgumentNullException(nameof(genre));
        var result = genres.FirstOrDefault(x => x.Name == genre);
        if (result is null)
            throw new ArgumentException("Genre with this Name does not Exists");
        genres.Remove(result);
    }

    public bool AddSong(string title, string artist, string genre)
    {
        Music new_music = new Music(title, artist, genre);
        if (title == null || artist == null || genre == null)
        {
            throw new Exception();
        }
        for (int i = 0; i < musicList.Count; i++)
        {
            if (musicList[i].Title.ToLower().Equals(title.ToLower()))
            {
                throw new Exception();
            }           
        }
        for (int i = 0; i < not_polite_words.Count; i++)
        {
            if (title.Contains(not_polite_words[i]) || artist.Contains(not_polite_words[i]) || genre.Contains(not_polite_words[i]))
            {
                throw new Exception();
            }
        }
        musicList.Add(new_music);
        return true;
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