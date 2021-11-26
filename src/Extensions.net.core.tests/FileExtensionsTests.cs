// Copyright © 2021 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System.IO;
using Xunit;

namespace Extensions.net.core.tests.UnitTests
{
    public class FileExtensionsTests
    {
        [Fact]
        public void WriteToFile()
        {
            string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tristique arcu vel libero gravida, tincidunt mollis est iaculis. Donec accumsan urna a libero volutpat vulputate. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Morbi sem nunc, interdum eget tortor ac, feugiat auctor neque. Proin rutrum neque sed dictum accumsan. Praesent id viverra leo. Nunc fermentum eros et vulputate maximus. Suspendisse potenti. Duis viverra sagittis erat, vel pretium tortor vehicula nec.";

            lorem.WriteToFileExt("c:\\temp\\lorem.txt");

            string fileText = File.ReadAllText("c:\\temp\\lorem.txt");
            Assert.True(fileText == lorem);
        }

        [Fact]
        public void WriteToGZippedFile()
        {
            string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tristique arcu vel libero gravida, tincidunt mollis est iaculis. Donec accumsan urna a libero volutpat vulputate. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Morbi sem nunc, interdum eget tortor ac, feugiat auctor neque. Proin rutrum neque sed dictum accumsan. Praesent id viverra leo. Nunc fermentum eros et vulputate maximus. Suspendisse potenti. Duis viverra sagittis erat, vel pretium tortor vehicula nec.";

            lorem.WriteToGZippedFileExt("c:\\temp\\lorem.gz");
            Assert.True(File.Exists("c:\\temp\\lorem.gz"));
        }

        [Fact]
        public void ReadFromGZippedFile()
        {
            string expected = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tristique arcu vel libero gravida, tincidunt mollis est iaculis. Donec accumsan urna a libero volutpat vulputate. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Morbi sem nunc, interdum eget tortor ac, feugiat auctor neque. Proin rutrum neque sed dictum accumsan. Praesent id viverra leo. Nunc fermentum eros et vulputate maximus. Suspendisse potenti. Duis viverra sagittis erat, vel pretium tortor vehicula nec.";

            string path = "c:\\temp\\lorem.gz";
            string decompressedString = path.ReadFromGZippedFileExt();

            Assert.Equal(expected, decompressedString);
        }

        [Fact]
        public void AppendToFile()
        {
            string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tristique arcu vel libero gravida, tincidunt mollis est iaculis. Donec accumsan urna a libero volutpat vulputate. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Morbi sem nunc, interdum eget tortor ac, feugiat auctor neque. Proin rutrum neque sed dictum accumsan. Praesent id viverra leo. Nunc fermentum eros et vulputate maximus. Suspendisse potenti. Duis viverra sagittis erat, vel pretium tortor vehicula nec.";

            lorem.AppendToFileExt("c:\\temp\\lorem.txt");

            string fileText = File.ReadAllText("c:\\temp\\lorem.txt");
            Assert.Contains(lorem, fileText);
        }
    }
}
