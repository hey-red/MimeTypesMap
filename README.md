# MimeTypesMap
Simple dictionary provides a few methods to lookup mime type/extension, generated from Apache's mime.types.

## Install
via [NuGet](https://www.nuget.org/packages/MimeTypesMap):
```
PM> Install-Package MimeTypesMap
```

## Usage
```C#
using HeyRed.Mime;

MimeTypesMap.GetExtension("image/jpeg"); // => jpeg
MimeTypesMap.GetMimeType("filename.jpeg"); // => image/jpeg

MimeTypesMap.AddOrUpdate(string mime, string extension);
```

## License
[MIT](LICENSE)
