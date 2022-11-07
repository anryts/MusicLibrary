// read songs from prepared file with song names, authors and genres
// split them by \t and add to the list

MusicLibrary.MusicLibrary library = new MusicLibrary.MusicLibrary();
library.ReadSongFromFile("songs.txt");
library.ConsolePrintMusicList();


