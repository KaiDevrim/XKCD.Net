using NUnit.Framework;

namespace XKCD.Net.Test;

[TestFixture]
public class XkcdComicTest
{
    private readonly Comic _latestComic = new(0);
    private readonly Comic _randomComic = new(-1);
    private readonly Comic _specificComic = new(2009);

    [Test]
    public void IsNotNull()
    {
        Assert.IsNotNull(_latestComic);
        Assert.IsNotNull(_randomComic);
        Assert.IsNotNull(_specificComic);
    }

    [Test]
    public void CheckDates()
    {
        Assert.That(DateTime.Now.Month, Is.EqualTo(int.Parse(_latestComic.Month)));
        Assert.That(DateTime.Now.Year, Is.EqualTo(int.Parse(_latestComic.Year)));

        DateTime specificDate = new(2018, 6, 20);
        Assert.That(specificDate.Month, Is.EqualTo(int.Parse(_specificComic.Month)));
        Assert.That(specificDate.Day, Is.EqualTo(int.Parse(_specificComic.Day)));
        Assert.That(specificDate.Year, Is.EqualTo(int.Parse(_specificComic.Year)));
    }

    [Test]
    public void InvalidComic()
    {
        Assert.Throws<FileNotFoundException>(() => new Comic(-84845));
        Assert.Throws<FileNotFoundException>(() => new Comic(-2));
    }

    [Test]
    public void CheckSpecific()
    {
        Assert.That(_specificComic.Num, Is.EqualTo(2009));
        Assert.That(_specificComic.Link, Is.EqualTo(""));
        Assert.That(_specificComic.News, Is.EqualTo(""));
        Assert.That(_specificComic.SafeTitle, Is.EqualTo("Hertzsprung-Russell Diagram"));
        Assert.That(_specificComic.Transcript, Is.EqualTo(""));
        Assert.That(_specificComic.Alt,
            Is.EqualTo(
                "The Hertzsprung-Russell diagram is located in its own lower right corner, unless you're viewing it on an unusually big screen."));
        Assert.That(_specificComic.Img, Is.EqualTo(new Uri("https://imgs.xkcd.com/comics/hertzsprung_russell_diagram.png")));
        Assert.That(_specificComic.Title, Is.EqualTo("Hertzsprung-Russell Diagram"));
    }
}