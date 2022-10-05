using System.Collections.Generic;
using HeyRed.Mime;
using Xunit;

namespace MimeTypesMapTests
{
    public class SimpleTests
    {
        [Fact]
        public void GetMimeTypeByFileName()
        {
            var mime = MimeTypesMap.GetMimeType("test.jpeg");
            Assert.Equal("image/jpeg", mime);
        }

        [Fact]
        public void GetMimeTypeByExtension()
        {
            var mime = MimeTypesMap.GetMimeType("jpeg");
            Assert.Equal("image/jpeg", mime);
        }

        [Fact]
        public void GetMimeTypeByUpperExtension()
        {
            var mime = MimeTypesMap.GetMimeType("JPG");
            Assert.Equal("image/jpeg", mime);
        }

        [Fact]
        public void GetExtension()
        {
            var ext = MimeTypesMap.GetExtension("image/jpeg");
            Assert.Equal("jpeg", ext);
        }

        [Fact]
        public void GetExtensions()
        {
            var expected = new List<string>
            {
                "ai",
                "eps",
                "ps"
            };
            var exts = MimeTypesMap.GetExtensions("application/postscript");
            Assert.Equal(expected, exts);
        }
        
        [Fact]
        public void AddOrUpdate()
        {
            var ext = "ext";
            var mimeToAdd = "test/ext";

            MimeTypesMap.AddOrUpdate(mimeToAdd, ext);
            var mimeResult = MimeTypesMap.GetMimeType("file.ext");

            Assert.Equal(mimeToAdd, mimeResult);
        }
    }
}
