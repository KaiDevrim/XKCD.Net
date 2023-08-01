<p align="center">
  <img src="./banner.png" />
</p>

# XKCD.Net

XKCD.Net is a C# library for getting Comics from the famous web-series [XKCD](https://xkcd.com)!

## Installation

Use the any dotnet package manager like Nuget or just the default dotnet to install the package.

```bash
dotnet add package KaiDevrim.XkcdApi
```

## Usage

To get the latest Comic, just instantiate a Comic class like so,

```cs
Comic comic = new Comic(0);
```

To get a random Comic, just use `-1` instead,

```cs
Comic comic = new Comic(-1);
```

And to get a specific Comic, just insert the Comic's number,

```cs
Comic comic = new Comic(606);
```

From there you can get the following information about the Comic,
```cs
comic.Month (string)
comic.Num (int)
comic.Link (string)
comic.Year (string)
comic.News (string)
comic.SafeTitle (string)
comic.Transcript (string)
comic.Alt (string)
comic.Title (string)
comic.Img (Uri)
comic.Day (string)
```

## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[MIT](https://choosealicense.com/licenses/mit/)
