// Copyright © 2022 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Extensions.net.core.tests.UnitTests
{
    public class StringExtensionsTests
    {
        readonly ITestOutputHelper output;

        public StringExtensionsTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void IsNullOrWhiteSpace()
        {
            string str1 = "";
            Assert.Equal(string.IsNullOrWhiteSpace(str1), str1.IsNullOrWhiteSpaceExt());

            string str2 = "Not whitespace";
            Assert.Equal(string.IsNullOrWhiteSpace(str2), str2.IsNullOrWhiteSpaceExt());

            string str3 = " ";
            Assert.Equal(string.IsNullOrWhiteSpace(str3), str3.IsNullOrWhiteSpaceExt());
        }

        [Fact]
        public void IsNullOrEmpty()
        {
            string str1 = "";
            Assert.Equal(string.IsNullOrEmpty(str1), str1.IsNullOrEmptyExt());

            string str2 = " ";
            Assert.Equal(string.IsNullOrEmpty(str2), str2.IsNullOrEmptyExt());

            string str3 = "Not empty";
            Assert.Equal(string.IsNullOrEmpty(str3), str3.IsNullOrEmptyExt());
        }

        [Fact]
        public void IsNotNullOrWhiteSpace()
        {
            string str1 = "";
            Assert.Equal(!string.IsNullOrWhiteSpace(str1), str1.IsNotNullOrWhiteSpaceExt());

            string str2 = "Not whitespace";
            Assert.Equal(!string.IsNullOrWhiteSpace(str2), str2.IsNotNullOrWhiteSpaceExt());

            string str3 = " ";
            Assert.Equal(!string.IsNullOrWhiteSpace(str3), str3.IsNotNullOrWhiteSpaceExt());
        }

        [Fact]
        public void IsNotNullOrEmpty()
        {
            string str1 = "";
            Assert.Equal(!string.IsNullOrEmpty(str1), str1.IsNotNullOrEmptyExt());

            string str2 = " ";
            Assert.Equal(!string.IsNullOrEmpty(str2), str2.IsNotNullOrEmptyExt());

            string str3 = "Not empty";
            Assert.Equal(!string.IsNullOrEmpty(str3), str3.IsNotNullOrEmptyExt());
        }

        [Fact]
        public void Compare()
        {
            string str1 = "Apples";
            string str2 = "Bananas";
            Assert.Equal(string.Compare(str1, str2), str1.CompareExt(str2));
            Assert.Equal(string.Compare(str2, str1), str2.CompareExt(str1));

            string str3 = "apples";
            Assert.Equal(string.Compare(str3, str1, true), str3.CompareExt(str1));

            string str4 = null;
            Assert.Equal(string.Compare(str1, str4), str1.CompareExt(str4));
        }

        [Fact]
        public void CompareFirst()
        {
            string str1 = "Apples";
            string str2 = "Bananas";
            Assert.Equal("Apples", str1.CompareFirstExt(str2));

            string str3 = "apples";
            Assert.Equal("", str1.CompareFirstExt(str3));
        }

        [Fact]
        public void CompareOrdinal()
        {
            string str1 = "Apples";
            string str2 = "Bananas";
            Assert.Equal(string.CompareOrdinal(str1, str2), str1.CompareOrdinalExt(str2));
            Assert.Equal(string.CompareOrdinal(str2, str1), str2.CompareOrdinalExt(str1));

            string str3 = "apples";
            Assert.Equal(string.CompareOrdinal(str3, str1), str3.CompareOrdinalExt(str1));

            string str4 = null;
            Assert.Equal(string.CompareOrdinal(str1, str4), str1.CompareOrdinalExt(str4));
        }

        [Fact]
        public void CompareOrdinal2()
        {
            string str1 = "Apples";
            int str1Index = 0;
            string str2 = "Bananas";
            int str2Index = 1;
            int length = 3;
            Assert.Equal(string.CompareOrdinal(str1, str1Index, str2, str2Index, length), str1.CompareOrdinalExt(str1Index, str2, str2Index, length));
            Assert.Equal(string.CompareOrdinal(str2, str2Index, str1, str1Index, length), str2.CompareOrdinalExt(str2Index, str1, str1Index, length));
        }

        [Fact]
        public void Format()
        {
            string str1 = "fu{0}{1}";
            string str2 = "bar";
            string str3 = "star";

            object obj1 = new ();

            Assert.Equal(string.Format(str1, str2, str3), str1.FormatExt(str2, str3));
            Assert.Equal(string.Format(str1, str2, obj1), str1.FormatExt(str2, obj1));

            object obj2 = null;
            Assert.Equal(string.Format(str1, str2, obj2), str1.FormatExt(str2, obj2));
        }

        [Fact]
        public void Intern()
        {
            string str1 = "test";
            Assert.Equal(string.Intern(str1), str1.InternExt());
        }

        [Fact]
        public void IsInterned()
        {
            string str1 = "test";
            Assert.Equal(string.IsInterned(str1), str1.IsInternExt());
        }

        [Fact]
        public void Join()
        {
            string str1 = "fu";
            string str2 = "bar";
            string separator = " ";

            Assert.Equal(string.Join(separator, new string[2] { str1, str2 }, 0, 0), str1.JoinExt(separator, new string[1] { str2 }, 0, 0));
            Assert.Equal(string.Join(separator, str1, str2), str1.JoinExt(separator, str2));
        }

        [Fact]
        public void ReferenceEqualsExt()
        {
            string str1 = "test";
            string str2 = "test";
            string str3 = str1;

            Assert.Equal(ReferenceEquals(str1, str1), str1.ReferenceEqualsExt(str1));
            Assert.Equal(ReferenceEquals(str1, str2), str1.ReferenceEqualsExt(str2));
            Assert.Equal(ReferenceEquals(str1, str3), str1.ReferenceEqualsExt(str3));
        }

        [Fact]
        public void ToDateTime()
        {
            string date = "01/01/2018";
            Assert.Equal(date.ToDateTimeExt(), Convert.ToDateTime(date));

            string date2 = "January 1, 2017";
            DateTime date3 = Convert.ToDateTime(date2);
            Assert.Equal(date3, date2.ToDateTimeExt());

            string date4 = "This is not a date";
            Assert.Throws<FormatException>(() => date4.ToDateTimeExt());
        }

        [Fact]
        public void FromBase64String()
        {
            string str1 = "AAEPISo=";
            byte[] b64 = Convert.FromBase64String(str1);

            Assert.Equal(b64, str1.FromBase64StringExt());

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = Base64DotNet(str1), () => actualElapsed = Base64Ext(str1));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void FromBase64String2()
        {
            string str1 = "AAEPISo=";
            byte[] b64 = Convert.FromBase64String(str1);
            string actual = Encoding.Default.GetString(b64);

            Assert.Equal(actual, str1.FromBase64String2Ext());

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = Base64DotNet2(str1), () => actualElapsed = Base64Ext2(str1));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToBase64String()
        {
            string text = "Lorem ipsum dolor amet";

            byte[] bytes = Encoding.UTF8.GetBytes(text);
            string expected = Convert.ToBase64String(bytes);

            Assert.Equal(expected, text.ToBase64StringExt());
        }

        [Fact]
        public void ToTitleCase()
        {
            string str1 = "fubar";
            Assert.Equal("Fubar", str1.ToTitleCaseExt());

            string longText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam orci orci, consequat nec dui eu, porta volutpat augue. Nulla vel vehicula lectus, eget facilisis lectus. Sed sed ipsum a nibh aliquet facilisis id quis dui. Mauris interdum urna urna, et euismod tortor luctus quis. Etiam consequat quam vitae lectus egestas finibus. Aliquam id nisi nec ligula semper tempus sed a leo. Pellentesque nec aliquam justo. Nunc non erat bibendum, feugiat urna id, imperdiet metus. Nulla imperdiet mauris vitae justo tincidunt consectetur. Suspendisse interdum lacus sit amet aliquam tincidunt. Aliquam blandit pulvinar vestibulum. Quisque rhoncus tincidunt sem, vitae mollis diam rutrum non.";
            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = TileCaseDotNet(longText), () => actualElapsed = TitleCaseExt(longText));         

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void Reverse()
        {
            string str1 = "fubar";
            Assert.Equal("rabuf", str1.ReverseExt());

            string str2 = "green room";
            Assert.Equal("moor neerg", str2.ReverseExt());
        }

        [Fact]
        public void Palindrome()
        {
            string str1 = "mom";
            Assert.True(str1.IsPalindromeExt());

            string str2 = "socks";
            Assert.False(str2.IsPalindromeExt());
        }

        [Fact]
        public void GetBytes()
        {
            string s = "test";
            byte[] expected = Encoding.Default.GetBytes(s);
            Assert.Equal(expected, s.GetBytesExt());
        }

        [Fact]
        public void GetBytesUtf8()
        {
            string s = "test";
            byte[] expected = Encoding.UTF8.GetBytes(s);
            Assert.Equal(expected, s.GetBytesUtf8Ext());
        }

        [Fact]
        public void GetBytesUtf32()
        {
            string s = "test";
            byte[] expected = Encoding.UTF32.GetBytes(s);
            Assert.Equal(expected, s.GetBytesUtf32Ext());
        }

        [Fact]
        public void GetBytesUnicode()
        {
            string s = "test";
            byte[] expected = Encoding.Unicode.GetBytes(s);
            Assert.Equal(expected, s.GetBytesUnicodeExt());
        }

        [Fact]
        public void GetBytesASCII()
        {
            string s = "test";
            byte[] expected = Encoding.ASCII.GetBytes(s);
            Assert.Equal(expected, s.GetBytesASCIIExt());
        }

        [Fact]
        public void GetBytesBigEndianUnicode()
        {
            string s = "test";
            byte[] expected = Encoding.BigEndianUnicode.GetBytes(s);
            Assert.Equal(expected, s.GetBytesBigEndianUnicodeExt());
        }

        [Fact]
        public void UrlEncode()
        {
            string s = "This & That";
            string expected = System.Web.HttpUtility.UrlEncode(s);
            Assert.Equal(expected, s.UrlEncodeExt());
        }

        [Fact]
        public void UrlDecode()
        {
            string s = "This+%26+That";
            string expected = System.Web.HttpUtility.UrlDecode(s);
            Assert.Equal(expected, s.UrlDecodeExt());
        }

        [Fact]
        public void HtmlEncode()
        {
            string s = "This & That";
            string expected = System.Web.HttpUtility.HtmlEncode(s);
            Assert.Equal(expected, s.HtmlEncodeExt());
        }

        [Fact]
        public void HtmlDecode()
        {
            string s = "This+%26+That";
            string expected = System.Web.HttpUtility.HtmlDecode(s);
            Assert.Equal(expected, s.HtmlDecodeExt());
        }

        [Fact]
        public void HtmlAttributeEncode()
        {
            string s = "This & That";
            string expected = System.Web.HttpUtility.HtmlAttributeEncode(s);
            Assert.Equal(expected, s.HtmlAttributeEncodeExt());
        }

        [Fact]
        public void JavaScriptStringEncode()
        {
            string s = "<script>function {};</script>";
            string expected = System.Web.HttpUtility.JavaScriptStringEncode(s);
            Assert.Equal(expected, s.JavaScriptStringEncodeExt());
        }

        [Fact]
        public void UrlDecodeToBytes()
        {
            string s = "This+%26+That";
            byte[] expected = System.Web.HttpUtility.UrlDecodeToBytes(s);
            Assert.Equal(expected, s.UrlDecodeToBytesExt());

            byte[] expected2 = System.Web.HttpUtility.UrlDecodeToBytes(s, Encoding.UTF8);
            Assert.Equal(expected2, s.UrlDecodeToBytesExt(Encoding.UTF8));
        }

        [Fact]
        public void UrlEncodeToBytes()
        {
            string s = "This & That";
            byte[] expected = System.Web.HttpUtility.UrlEncodeToBytes(s);
            Assert.Equal(expected, s.UrlEncodeToBytesExt());

            expected = System.Web.HttpUtility.UrlEncodeToBytes(s, Encoding.UTF8);
            Assert.Equal(expected, s.UrlEncodeToBytesExt(Encoding.UTF8));
        }

        [Fact]
        public void Capitalize()
        {
            string s = "testing testing t.t testing testing. sentence 2.";
            string expected = "Testing testing t.t testing testing. Sentence 2.";

            Assert.Equal(expected, s.CapitalizeExt());

            string s2 = null;
            Assert.Null(s2.CapitalizeExt());

            string s3 = " ";
            Assert.Equal(s3, s3.CapitalizeExt());

            s = "this is a test string. this is another test string.";
            expected = "This is a test string. This is another test string.";

            Assert.Equal(expected, s.CapitalizeExt());

            s = "this is a test string";
            expected = "This is a test string";

            Assert.Equal(expected, s.CapitalizeExt());

            s = "this is a test string; this is another test.";
            expected = "This is a test string; this is another test.";

            Assert.Equal(expected, s.CapitalizeExt());
        }

        [Fact]
        public void Duplicate()
        {
            string s = "s";
            string expected = "sssss";
            Assert.Equal(expected, s.DuplicateExt(5));

            s = null;
            expected = "";
            Assert.Equal(expected, s.DuplicateExt(5));

            s = "";
            Assert.Equal("", s.DuplicateExt(5));

            s = " ";
            expected = "     ";
            Assert.Equal(expected, s.DuplicateExt(5));
        }

        [Fact]
        public void Center()
        {
            string test = "test";
            string expected = "     test     ";

            string result = test.CenterExt(14);
            Assert.Equal(expected, result);

            expected = "aaaaatestaaaaa";
            result = test.CenterExt(14, 'a');
            Assert.Equal(expected, result);

            expected = "test";
            result = test.CenterExt(3);
            Assert.Equal(expected, result);

            test = null;
            expected = null;
            result = test.CenterExt(14);
            Assert.Equal(expected, result);

            test = "";
            expected = "     ";
            result = test.CenterExt(5);
            Assert.Equal(expected, result);

            test = "";
            expected = "bbbbb";
            result = test.CenterExt(5, 'b');
            Assert.Equal(expected, result);

            test = " ";
            expected = "     ";
            result = test.CenterExt(5);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsAlphaNumeric()
        {
            string text = "abc123";
            Assert.True(text.IsAlphaNumericExt());

            text = "123";
            Assert.True(text.IsAlphaNumericExt());

            text = "abc";
            Assert.True(text.IsAlphaNumericExt());

            text = "abc.123";
            Assert.False(text.IsAlphaNumericExt());

            text = "abc 123";
            Assert.False(text.IsAlphaNumericExt());

            text = null;
            Assert.False(text.IsAlphaNumericExt());
        }

        [Fact]
        public void IsAlpha()
        {
            string text = "abc123";
            Assert.False(text.IsAlphaExt());

            text = "123";
            Assert.False(text.IsAlphaExt());

            text = "abc";
            Assert.True(text.IsAlphaExt());

            text = "abc.123";
            Assert.False(text.IsAlphaExt());

            text = "abc 123";
            Assert.False(text.IsAlphaExt());

            text = null;
            Assert.False(text.IsAlphaExt());
        }

        [Fact]
        public void IsNumeric()
        {
            string text = "abc123";
            Assert.False(text.IsNumericExt());

            text = "123";
            Assert.True(text.IsNumericExt());

            text = "abc";
            Assert.False(text.IsNumericExt());

            text = "abc.123";
            Assert.False(text.IsNumericExt());

            text = "abc 123";
            Assert.False(text.IsNumericExt());

            text = null;
            Assert.False(text.IsNumericExt());
        }

        [Fact]
        public void IsASCII()
        {
            string text = "abc123";
            Assert.True(text.IsASCIIExt());

            text = "123";
            Assert.True(text.IsASCIIExt());

            text = "abc";
            Assert.True(text.IsASCIIExt());

            text = "abc.123";
            Assert.True(text.IsASCIIExt());

            text = "abc 123";
            Assert.True(text.IsASCIIExt());

            text = null;
            Assert.False(text.IsASCIIExt());

            text = "";
            Assert.True(text.IsASCIIExt());

            text = " ";
            Assert.True(text.IsASCIIExt());

            text = "æ";
            Assert.False(text.IsASCIIExt());
        }

        [Fact]
        public void IsLower()
        {
            string text = "abc123";
            Assert.False(text.IsLowerExt());

            text = "123";
            Assert.False(text.IsLowerExt());

            text = "abc";
            Assert.True(text.IsLowerExt());

            text = "abc.123";
            Assert.False(text.IsLowerExt());

            text = "abc 123";
            Assert.False(text.IsLowerExt());

            text = null;
            Assert.False(text.IsLowerExt());

            text = "";
            Assert.False(text.IsLowerExt());

            text = " ";
            Assert.False(text.IsLowerExt());

            text = "æ";
            Assert.False(text.IsLowerExt());

            text = "zzz";
            Assert.True(text.IsLowerExt());

            text = "AAA";
            Assert.False(text.IsLowerExt());
        }

        [Fact]
        public void IsUpper()
        {
            string text = "abc123";
            Assert.False(text.IsUpperExt());

            text = "123";
            Assert.False(text.IsUpperExt());

            text = "abc";
            Assert.False(text.IsUpperExt());

            text = "ABC";
            Assert.True(text.IsUpperExt());

            text = "abc.123";
            Assert.False(text.IsUpperExt());

            text = "abc 123";
            Assert.False(text.IsUpperExt());

            text = null;
            Assert.False(text.IsUpperExt());

            text = "";
            Assert.False(text.IsUpperExt());

            text = " ";
            Assert.False(text.IsUpperExt());

            text = "æ";
            Assert.False(text.IsUpperExt());

            text = "zzz";
            Assert.False(text.IsUpperExt());

            text = "AAA";
            Assert.True(text.IsUpperExt());
        }

        [Fact]
        public void IsMatch()
        {
            string text = "Lorem ipsum dolor sit amet consectetur adipiscing elit";
            string pattern = "^[a-zA-Z.\\s]+$";

            Assert.True(text.IsMatchExt(pattern));
            Assert.Equal(Regex.IsMatch(text, pattern), text.IsMatchExt(pattern));
            Assert.Equal(Regex.IsMatch(text, pattern, RegexOptions.IgnorePatternWhitespace), text.IsMatchExt(pattern, RegexOptions.IgnorePatternWhitespace));
            Assert.Equal(Regex.IsMatch(text, pattern, RegexOptions.IgnorePatternWhitespace, new TimeSpan(0, 1, 0)), text.IsMatchExt(pattern, RegexOptions.IgnorePatternWhitespace, new TimeSpan(0, 1, 0)));
        }

        [Fact]
        public void ToUri()
        {
            string url = "https://www.example.com";
            Assert.Equal(new Uri(url), url.ToUriExt());

            url = "";
            Assert.Throws<System.UriFormatException>(() => url.ToUriExt());
        }

        [Fact]
        [Obsolete("This test uses an obsolete extension and will be removed in a future release.", false)]
        public void ToHttpWebRequest()
        {
            string url = "https://www.example.com";
            string method = "get";
            string contentType = "application/json";
            string accept = "*/*";
            string host = "example.com";
            int timeout = 60;
            //string mediaType = "audio/mpeg";
            //string userAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";

            //var headers = new Tuple<string, string>[1] { new Tuple<string,string>("Authorization", "Basic ar4fgvtr6bh7") };

            HttpWebRequest actual = url.ToHttpWebRequestExt();
            Assert.NotNull(actual);

            HttpWebRequest actual2 = url.ToHttpWebRequestExt(method, contentType);
            Assert.Equal(actual2.Method, method);

            HttpWebRequest actual3 = url.ToHttpWebRequestExt(method: method, contentType: contentType, accept: accept, host: host, timeout: timeout);
            Assert.Equal(actual3.Accept, accept);
        }

        [Fact]
        public void Print()
        {
            string text = "test";

            var ex1 = Record.Exception(() => text.PrintExt());
            Assert.Null(ex1);
        }

        [Fact]
        public void TraceError()
        {
            string message = "error";
            var ex = Record.Exception(() => message.TraceErrorExt());
            Assert.Null(ex);
        }

        [Fact]
        public void TraceWarning()
        {
            string message = "warning";
            var ex = Record.Exception(() => message.TraceWarningExt());
            Assert.Null(ex);
        }

        [Fact]
        public void TraceInformation()
        {
            string message = "info";
            var ex = Record.Exception(() => message.TraceInformationExt());
            Assert.Null(ex);
        }

        [Fact]
        public void ToXml()
        {
            string text = "Some text to create XML.";
            string root = "Name";
            string expected = "<Name>Some text to create XML.</Name>";
            string actual = text.ToXmlExt(root);
            Assert.Equal(expected, actual);

            expected = "<Root>Some text to create XML.</Root>";
            actual = text.ToXmlExt();
            Assert.Equal(expected, actual);

            string nameSpace = "https://www.namespace.com";
            expected = "<Name xmlns=\"https://www.namespace.com\">Some text to create XML.</Name>";
            actual = text.ToXmlExt(root, nameSpace);
            Assert.Equal(expected, actual);

            expected = "<Root xmlns=\"https://www.namespace.com\">Some text to create XML.</Root>";
            actual = text.ToXmlExt(ns: nameSpace);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToXDocument()
        {
            string text = "Some text to create XML.";
            string root = "Name";
            XDocument expected = new (new XElement(root, text));
            XDocument actual = text.ToXDocumentExt(root);
            Assert.Equal(expected.ToString(), actual.ToString());

            expected = new (new XElement("Root", text));
            actual = text.ToXDocumentExt();
            Assert.Equal(expected.ToString(), actual.ToString());

            string nameSpace = "https://www.namespace.com";
            XNamespace ns = nameSpace; 
            expected = new XDocument(new XElement(ns + root, text));
            actual = text.ToXDocumentExt(root, nameSpace);
            Assert.Equal(expected.ToString(), actual.ToString());

            expected = new XDocument(new XElement(ns + "Root", text));
            actual = text.ToXDocumentExt(ns: nameSpace);
            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void Shuffle()
        {
            string text = "abcdefghijklmnop";
            string actual = text.ShuffleExt();
            Assert.NotEqual(text, actual);
            Assert.Equal(text.Length, actual.Length);

            text = "abc";
            string[] expected = { "abc", "acb", "bac", "bca", "cab", "cba" };
            actual = text.ShuffleExt();
            Assert.True(expected.ContainsExt(actual));

            text = "This is a test";
            int expected2 = 4;
            int actual2 = text.ShuffleExt().Split(' ').Length;
            Assert.Equal(expected2, actual2);
            Assert.NotEqual(text, text.ShuffleExt());
        }

        [Fact]
        public void Scrub()
        {
            string text = "P@ssw0rd#";
            string expected = "*********";
            Assert.Equal(expected, text.ScrubExt());

            Assert.Equal(expected, text.ScrubExt(length: -1));

            expected = "P@ss*****";
            Assert.Equal(expected, text.ScrubExt(length: 5));

            expected = "P########";
            Assert.Equal(expected, text.ScrubExt('#', 8));

            expected = "#########";
            Assert.Equal(expected, text.ScrubExt('#'));

            expected = "P@ssw0rd#";
            Assert.Equal(expected, text.ScrubExt(length: 0));

            expected = "*********";
            Assert.Equal(expected, text.ScrubExt(length: 1000));
        }

        [Fact]
        public void Tab()
        {
            string test = "Test";
            string expected = $"\t\t\t\t\t{test}";
            string actual = test.TabExt(5);
            Assert.Equal(expected, actual);

            string testNull = null;
            expected = "\t\t\t\t\t";
            actual = testNull.TabExt(5);
            Assert.Equal(expected, actual);

            string testEmpty = null;
            expected = "\t\t\t\t\t";
            actual = testEmpty.TabExt(5);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Line()
        {
            string test = "Test";
            string expected = "Test\r\n\r\n\r\n\r\n\r\n";
            string actual = test.LineBreakExt(5);
            Assert.Equal(expected,actual);

            string testNull = null;
            expected = "\r\n\r\n\r\n\r\n\r\n";
            actual = testNull.LineBreakExt(5);
            Assert.Equal(expected, actual);

            string testEmpty = "";
            expected = "\r\n\r\n\r\n\r\n\r\n";
            actual = testEmpty.LineBreakExt(5);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsJson()
        {
            string test = "{\"name\": \"Bob\"}";
            Assert.True(test.IsJsonExt());

            test = "\"name\": \"Bob\"}";
            Assert.False(test.IsJsonExt());
        }

        #region "Private Methods"
        private static long Base64DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.FromBase64String(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long Base64Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.FromBase64StringExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long Base64DotNet2(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tc1 = Convert.FromBase64String(str1);
            Encoding.Default.GetString(tc1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long Base64Ext2(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.FromBase64StringExt().GetStringExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long TileCaseDotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
            textInfo.ToTitleCase(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long TitleCaseExt(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToTitleCaseExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }
        #endregion
    }
}
