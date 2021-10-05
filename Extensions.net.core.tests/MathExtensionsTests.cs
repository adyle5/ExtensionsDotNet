using System;
using Xunit;

namespace Extensions.net.core.tests
{
    public class MathExtensionsTests
    {
        [Fact]
        public void Add()
        {
            int a = 5;
            int b = 3;
            Assert.Equal(a + b, a.AddExt(b));
        }


        [Fact]
        public void Subtract()
        {
            int a = 5;
            int b = 3;
            Assert.Equal(a - b, a.SubtractExt(b));
        }


        [Fact]
        public void Multiply()
        {
            int a = 5;
            int b = 3;
            Assert.Equal(a * b, a.MultiplyExt(b));
        }


        [Fact]
        public void Divide()
        {
            int a = 5;
            int b = 3;
            Assert.Equal(a / b, a.DivideExt(b));
        }


        [Fact]
        public void Abs()
        {
            decimal dec = decimal.MinValue;
            Assert.Equal(Math.Abs(dec), dec.AbsExt());

            double dou = double.MinValue;
            Assert.Equal(Math.Abs(dou), dou.AbsExt());

            short sh = short.MinValue + 1;
            Assert.Equal(Math.Abs(sh), sh.AbsExt());

            int i = int.MinValue + 1;
            Assert.Equal(Math.Abs(i), i.AbsExt());

            long l = long.MinValue + 1;
            Assert.Equal(Math.Abs(l), l.AbsExt());

            sbyte sb = sbyte.MinValue + 1;
            Assert.Equal(Math.Abs(sb), sb.AbsExt());

            float f = float.MinValue;
            Assert.Equal(Math.Abs(f), f.AbsExt());
        }

        [Fact]
        public void Acos()
        {
            double dou = double.MaxValue;
            Assert.Equal(Math.Acos(dou), dou.AcosExt());
        }

        [Fact]
        public void Asin()
        {
            double dou = double.MaxValue;
            Assert.Equal(Math.Asin(dou), dou.AsinExt());
        }

        [Fact]
        public void Atan()
        {
            double dou = double.MaxValue;
            Assert.Equal(Math.Atan(dou), dou.AtanExt());
        }

        [Fact]
        public void Atan2()
        {
            double x = double.MaxValue;
            double y = double.MinValue;
            Assert.Equal(Math.Atan2(x, y), x.Atan2Ext(y));
        }

        [Fact]
        public void Ceiling()
        {
            double dou = 123.456;
            Assert.Equal(Math.Ceiling(dou), dou.CeilingExt());

            decimal dec = 123.456M;
            Assert.Equal(Math.Ceiling(dec), dec.CeilingExt());
        }

        [Fact]
        public void Cos()
        {
            double dou = 123.456;
            Assert.Equal(Math.Cos(dou), dou.CosExt());
        }

        [Fact]
        public void Cosh()
        {
            double dou = 123.456;
            Assert.Equal(Math.Cosh(dou), dou.CoshExt());
        }

        [Fact]
        public void Exp()
        {
            double dou = 123.456;
            Assert.Equal(Math.Exp(dou), dou.ExpExt());
        }

        [Fact]
        public void Floor()
        {
            decimal dec = 123.456M;
            Assert.Equal(Math.Floor(dec), dec.FloorExt());

            double dou = 123.456;
            Assert.Equal(Math.Floor(dou), dou.FloorExt());
        }

        [Fact]
        public void IEEERemainder()
        {
            double x = 9;
            double y = 7;
            Assert.Equal(Math.IEEERemainder(x, y), x.IEEERemainderExt(y));
        }

        [Fact]
        public void Log()
        {
            double dou = 123.456;
            Assert.Equal(Math.Log(dou), dou.LogExt());

            double newBase = 5;
            Assert.Equal(Math.Log(dou, newBase), dou.LogExt(newBase));
        }

        [Fact]
        public void Log10()
        {
            double dou = 123.456;
            Assert.Equal(Math.Log10(dou), dou.Log10Ext());
        }

        [Fact]
        public void Max()
        {
            sbyte sb1 = 100;
            sbyte sb2 = 101;
            Assert.Equal(Math.Max(sb1, sb2), sb1.MaxExt(sb2));

            uint u1 = 100;
            uint u2 = 101;
            Assert.Equal(Math.Max(u1, u2), u1.MaxExt(u2));

            ushort us1 = 100;
            ushort us2 = 101;
            Assert.Equal(Math.Max(us1, us2), us1.MaxExt(us2));

            float f1 = 1.4f;
            float f2 = 2.3f;
            Assert.Equal(Math.Max(f1, f2), f1.MaxExt(f2));

            long l1 = 100;
            long l2 = 101;
            Assert.Equal(Math.Max(l1, l2), l1.MaxExt(l2));

            ulong ul1 = 100;
            ulong ul2 = 101;
            Assert.Equal(Math.Max(ul1, ul2), ul1.MaxExt(ul2));

            short s1 = 100;
            short s2 = 101;
            Assert.Equal(Math.Max(s1, s2), s1.MaxExt(s2));

            double d1 = 100.1;
            double d2 = 50.2;
            Assert.Equal(Math.Max(d1, d2), d1.MaxExt(d2));

            decimal dec1 = 100M;
            decimal dec2 = 101M;
            Assert.Equal(Math.Max(dec1, dec2), dec1.MaxExt(dec2));

            byte b1 = 10;
            byte b2 = 128;
            Assert.Equal(Math.Max(b1, b2), b1.MaxExt(b2));

            int i1 = 100;
            int i2 = 101;
            Assert.Equal(Math.Max(i1, i2), i1.MaxExt(i2));
        }

        [Fact]
        public void Min()
        {
            sbyte sb1 = 100;
            sbyte sb2 = 101;
            Assert.Equal(Math.Min(sb1, sb2), sb1.MinExt(sb2));

            uint u1 = 100;
            uint u2 = 101;
            Assert.Equal(Math.Min(u1, u2), u1.MinExt(u2));

            ushort us1 = 100;
            ushort us2 = 101;
            Assert.Equal(Math.Min(us1, us2), us1.MinExt(us2));

            float f1 = 1.4f;
            float f2 = 2.3f;
            Assert.Equal(Math.Min(f1, f2), f1.MinExt(f2));

            long l1 = 100;
            long l2 = 101;
            Assert.Equal(Math.Min(l1, l2), l1.MinExt(l2));

            ulong ul1 = 100;
            ulong ul2 = 101;
            Assert.Equal(Math.Min(ul1, ul2), ul1.MinExt(ul2));

            short s1 = 100;
            short s2 = 101;
            Assert.Equal(Math.Min(s1, s2), s1.MinExt(s2));

            double d1 = 100.1;
            double d2 = 50.2;
            Assert.Equal(Math.Min(d1, d2), d1.MinExt(d2));

            decimal dec1 = 100M;
            decimal dec2 = 101M;
            Assert.Equal(Math.Min(dec1, dec2), dec1.MinExt(dec2));

            byte b1 = 10;
            byte b2 = 128;
            Assert.Equal(Math.Min(b1, b2), b1.MinExt(b2));

            int i1 = 100;
            int i2 = 101;
            Assert.Equal(Math.Min(i1, i2), i1.MinExt(i2));
        }

        [Fact]
        public void Pow()
        {
            double x = 9;
            double y = 7;
            Assert.Equal(Math.Pow(x, y), x.PowExt(y));
        }

        [Fact]
        public void Round()
        {
            double dou = 12.345;
            MidpointRounding mr = MidpointRounding.AwayFromZero;
            Assert.Equal(Math.Round(dou, mr), dou.RoundExt(mr));

            int decimals = 2;
            Assert.Equal(Math.Round(dou, decimals, mr), dou.RoundExt(decimals, mr));
            Assert.Equal(Math.Round(dou, decimals), dou.RoundExt(decimals));
            Assert.Equal(Math.Round(dou), dou.RoundExt());

            decimal dec = 12.345M;
            MidpointRounding mr2 = MidpointRounding.ToEven;
            Assert.Equal(Math.Round(dec, mr2), dec.RoundExt(mr2));
            Assert.Equal(Math.Round(dec, decimals, mr2), dec.RoundExt(decimals, mr2));
            Assert.Equal(Math.Round(dec, decimals), dec.RoundExt(decimals));
            Assert.Equal(Math.Round(dec), dec.RoundExt());
        }

        [Fact]
        public void Sign()
        {
            float f = 100f;
            Assert.Equal(Math.Sign(f), f.SignExt());

            long l = 100;
            Assert.Equal(Math.Sign(l), l.SignExt());

            int i = 100;
            Assert.Equal(Math.Sign(i), i.SignExt());

            sbyte sb = 127;
            Assert.Equal(Math.Sign(sb), sb.SignExt());

            double d = 123.456;
            Assert.Equal(Math.Sign(d), d.SignExt());

            decimal dec = 123.456M;
            Assert.Equal(Math.Sign(dec), dec.SignExt());

            short sh = 100;
            Assert.Equal(Math.Sign(sh), sh.SignExt());
        }

        [Fact]
        public void Sin()
        {
            double d = 123.456;
            Assert.Equal(Math.Sin(d), d.SinExt());
        }

        [Fact]
        public void Sinh()
        {
            double d = 123.456;
            Assert.Equal(Math.Sinh(d), d.SinhExt());
        }

        [Fact]
        public void Sqrt()
        {
            double d = 100;
            Assert.Equal(Math.Sqrt(d), d.SqrtExt());
        }

        [Fact]
        public void Tan()
        {
            double d = 123.456;
            Assert.Equal(Math.Tan(d), d.TanExt());
        }

        [Fact]
        public void Tanh()
        {
            double d = 123.456;
            Assert.Equal(Math.Tanh(d), d.TanhExt());
        }

        [Fact]
        public void Truncate()
        {
            double d = 123.456;
            Assert.Equal(Math.Truncate(d), d.TruncateExt());
        }
    }
}
