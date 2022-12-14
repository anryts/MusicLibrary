using MusicLibrary;



var library = new MusicLibrary.MusicLibrary(new ReturnService(), new ReadService(), 
    new PrintIntoConsoleService(), new InMemoryCollection(new List<Song>(
        new []
        {
            new Song("song1", "Andrii.H", new Genre("Rock", null)),
        }),
        new List<Genre>()
        ));

library.AddSongs(null);
var result = library.GetSongsBySomethingSorted("genre", new Genre("Rock", null));
result.ForEach(x => Console.WriteLine(x.GetMusicInfo()));



