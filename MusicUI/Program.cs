using MusicLibrary;

OperationsWithData operationsWithData = new();

var list = operationsWithData.ReadSongFromFile(null);

list.ForEach(x=> Console.WriteLine(x.GetMusicInfo()));

MusicLibrary.MusicLibrary musicLibrary = new(list, null);

musicLibrary.GetSongsBySomethingSorted("favorites");

musicLibrary.AddSong(new Song("Who", "DrWho", new Genre("Arthoutse", "just joke")));


