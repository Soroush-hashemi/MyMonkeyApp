using MyMonkeyApp.Data;
using MyMonkeyApp.Model;
using Xunit;

namespace MyMonkeyApp.Tests.Data;

public class MonkeyHelperTests
{
    [Fact]
    public void GetMonkeys_ReturnsAllMonkeys()
    {
        // Act
        var result = MonkeyHelper.GetMonkeys();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(7, result.Count);
        Assert.Contains(result, m => m.Name == "Gorilla");
    }

    [Theory]
    [InlineData("Capuchin", true)]
    [InlineData("CAPUCHIN", true)]
    [InlineData("Unknown", false)]
    public void GetMonkeyByName_FindsCorrectMonkey(string name, bool shouldExist)
    {
        // Act
        var result = MonkeyHelper.GetMonkeyByName(name);

        // Assert
        if (shouldExist)
        {
            Assert.NotNull(result);
            Assert.Equal(name, result.Name, ignoreCase: true);
        }
        else
        {
            Assert.Null(result);
        }
    }

    [Fact]
    public void GetMonkeyByName_ThrowsForNullOrEmpty()
    {
        // Assert
        Assert.Throws<ArgumentNullException>(() => MonkeyHelper.GetMonkeyByName(null));
        Assert.Throws<ArgumentNullException>(() => MonkeyHelper.GetMonkeyByName(""));
    }

    [Fact]
    public void GetRandomMonkey_ReturnsValidMonkey()
    {
        // Act
        var result = MonkeyHelper.GetRandomMonkey();

        // Assert
        Assert.NotNull(result);
        Assert.Contains(MonkeyHelper.GetMonkeys(), m => m.Name == result.Name);
    }

    [Theory]
    [InlineData("Gorilla")]
    [InlineData("Chimpanzee")]
    public void GetMonkeyAscii_ReturnsNonEmptyArt(string name)
    {
        // Act
        var result = MonkeyHelper.GetMonkeyAscii(name);

        // Assert
        Assert.False(string.IsNullOrWhiteSpace(result));
        Assert.Contains("\n", result);
    }
}