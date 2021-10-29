using System.IO;
using System.IO.Compression;

namespace Extensions.net
{
    public static class FileExtensions
    {
        /// <summary>
        /// Write text to a file. If file exists it will ovewrite.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="path"></param>
        public static void WriteToFileExt(this string text, string path)
        {
            using (var f = File.Create(path))
            {
                using (StreamWriter sw = new StreamWriter(f))
                {
                    sw.Write(text);
                }
            }
        }

        /// <summary>
        /// Writes string to a compressed file with the extension gz.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="compressedFilePath"></param>
        public static void WriteToGZippedFileExt(this string text, string compressedFilePath)
        {
            using (MemoryStream uncompressedStream = new MemoryStream(text.GetBytesExt()))
            {
                using (FileStream compressedStream = File.Create(compressedFilePath))
                {
                    using (GZipStream gZipStream = new GZipStream(compressedStream, CompressionMode.Compress))
                    {
                        uncompressedStream.CopyTo(gZipStream);
                    }
                }
            }
        }

        /// <summary>
        /// Reads a GZipped compressed file and returns the content as a decompressed string
        /// </summary>
        /// <param name="compressedFilePath"></param>
        /// <returns></returns>
        public static string ReadFromGZippedFileExt(this string compressedFilePath)
        {
            string decompressedString = "";
            using (FileStream compressedStream = File.Open(compressedFilePath, FileMode.Open))
            {
                using (var decompressedStream = new GZipStream(compressedStream, CompressionMode.Decompress))
                {
                    using (var ms = new MemoryStream())
                    {
                        decompressedStream.CopyTo(ms);

                        var bytes = ms.ToArray();

                        decompressedString = bytes.GetStringExt();
                    }
                }
            }

            return decompressedString;
        }

        /// <summary>
        /// Append Text to a file or creates new file.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="path"></param>
        public static void AppendToFileExt(this string text, string path)
        {
            using (var f = File.AppendText(path))
            {
                f.WriteLine(text);
            }
        }
    }
}
