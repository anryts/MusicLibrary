// read songs from prepared file with song names, authors and genres
// split them by \t and add to the list

using MusicLibrary;

MusicLibrary.MusicLibrary library = new MusicLibrary.MusicLibrary();
//library.ReadSongFromFile("songs.txt");
//library.ConsolePrintMusicList();
var test = new Genre ("Melon", "Test1");
library.AddGenre(test);
