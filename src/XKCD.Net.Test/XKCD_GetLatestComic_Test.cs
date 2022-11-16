using NUnit.Framework;
using XKCD.Net;
namespace XKCD.Net.Test;

[TestFixture]
public class XKCD_GetLatestComic_Test
{
    private Comic _comic;
    [SetUp]
    public void SetUp()
    {
        _comic = new Comic(-1);
    }
}