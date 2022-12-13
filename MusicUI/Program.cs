using MusicLibrary;



var musicLibrary = new MusicLibrary.MusicLibrary(new ReturnService(), new ReadService(), new PrintIntoConsoleService());
musicLibrary.AddSongs(null);
musicLibrary.PrintSongs();


musicLibrary.GetSongsBySomethingSorted("favorites", null);






