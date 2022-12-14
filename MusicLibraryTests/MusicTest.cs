using Moq;
using MusicLibrary;

namespace MusicLibraryTests;

public class MusicTest
{
    [Fact]
    public void TestReturnService_Nothing_ShouldReturnListOfSongs()
    {
        var expectedSongs = new List<Song>(new []
            {
                new Song("MockTest", "Andrii.H", new Genre("Test", null)), 
            }
        );

        var mock = new Mock<IReadService>();
        mock.Setup(x => x.ReadSongs(null))
            .Returns(new List<Song>()
            {
                new Song("MockTest", "Andrii.H", new Genre("Test", null))
            });
        
        var musicLibrary = new MusicLibrary
            .MusicLibrary(new ReturnService(), mock.Object, new PrintIntoConsoleService(), new InMemoryCollection(new List<Song>(), new List<Genre>()));
        musicLibrary.AddSongs(null);
        var actual = musicLibrary.GetSongsBySomethingSorted("test", null);
        Assert.Equal(expectedSongs.Count, actual.Count);
    }
    
    [Fact]
    public void TestReadService_Nothing_ShouldReturnList()
    {
        const string testPath = "testListOfMusic.txt";
        var mock = new Mock<IPrintService>();
        var expectedCollection = new List<Song>(new[]
        {
            new Song("MockTest", "Andrii.H", new Genre("Test", null))
        });

        var musicLibrary = new MusicLibrary.
            MusicLibrary(new ReturnService(), new ReadService(), mock.Object, new InMemoryCollection(null, null));
        musicLibrary.AddSongs(testPath);
        var actualCollection = musicLibrary.GetSongsBySomethingSorted("test", null);
        Assert.Equal(expectedCollection.Count, actualCollection.Count);
    }

    [Fact]
    public void TestReturnList_Nothing_ShouldReturnSortedList()
    {
        var mock2 = new Mock<IPrintService>();
        var mock3 = new Mock<IReadService>();
        var testData = new InMemoryCollection(new List<Song>(
                new []
                {
                    new Song("MockTest", "Andrii.H", new Genre("Test", null)), 
                }
            ), null
        );

        var musicLibrary = new MusicLibrary
            .MusicLibrary(new ReturnService(),mock3.Object , mock2.Object, testData);
        
        var actualSongs = musicLibrary.GetSongsBySomethingSorted
            ("genre", new Genre("Test", null));
        
        Assert.Collection(actualSongs,  song =>
        {
            if (song.Genre.Name == "Test");
        });
    }
}