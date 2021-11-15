// Copyright © 2021 Adrian Gabor
// Refer to license.txt for usage and permission information 

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

            double c = 5.5;
            double d = 3.3;

            Assert.Equal(c + d, c.AddExt(d));

            decimal e = 5.5M;
            decimal f = 3.3M;

            Assert.Equal(e + f, e.AddExt(f));
        }


        [Fact]
        public void Subtract()
        {
            int a = 5;
            int b = 3;
            Assert.Equal(a - b, a.SubtractExt(b));

            double c = 5.5;
            double d = 3.3;

            Assert.Equal(c - d, c.SubtractExt(d));

            decimal e = 5.5M;
            decimal f = 3.3M;

            Assert.Equal(e - f, e.SubtractExt(f));
        }


        [Fact]
        public void Multiply()
        {
            int a = 5;
            int b = 3;
            Assert.Equal(a * b, a.MultiplyExt(b));

            double c = 5.5;
            double d = 3.3;

            Assert.Equal(c * d, c.MultiplyExt(d));

            decimal e = 5.5M;
            decimal f = 3.3M;

            Assert.Equal(e * f, e.MultiplyExt(f));
        }


        [Fact]
        public void Divide()
        {
            int a = 5;
            int b = 3;
            Assert.Equal(a / b, a.DivideExt(b));

            double c = 5.5;
            double d = 3.3;

            Assert.Equal(c / d, c.DivideExt(d));

            decimal e = 5.5M;
            decimal f = 3.3M;

            Assert.Equal(e / f, e.DivideExt(f));
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

        [Fact]
        public void AreaOfCircle()
        {
            double radius = 5.2;
            double expected = 84.94867;
            double actual = Math.Round(radius.AreaOfCircleExt(), 5);

            Assert.Equal(expected, actual);

            int radius2 = 7;
            expected = 153.93804;
            actual = Math.Round(radius2.AreaOfCircleExt(), 5);
            Assert.Equal(expected, actual);

            radius = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => radius.AreaOfCircleExt());

            radius2 = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => radius2.AreaOfCircleExt());
        }

        [Fact]
        public void AreaOfTriangle()
        {
            double theBase = 10;
            double height = 5;

            double expected = 25;
            double actual = theBase.AreaOfTriangleExt(height);

            Assert.Equal(expected, actual);

            int theBase2 = 10;
            int height2 = 5;

            expected = 25;
            actual = theBase2.AreaOfTriangleExt(height2);

            Assert.Equal(expected, actual);

            theBase = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => theBase.AreaOfTriangleExt(height));

            height2 = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => theBase2.AreaOfTriangleExt(height2));
        }

        [Fact]
        public void AreaOfRectangle()
        {
            int length = 3;
            int width = 4;
            double expected = length * width;
            double actual = length.AreaOfRectangleExt(width);
            Assert.Equal(expected, actual);
            actual = width.AreaOfRectangleExt(length);
            Assert.Equal(expected, actual);

            length = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => length.AreaOfRectangleExt(width));

            double length2 = 3.5;
            double width2 = 5.7;
            expected = length2 * width2;
            actual = length2.AreaOfRectangleExt(width2);
            Assert.Equal(expected, actual);
            actual = width2.AreaOfRectangleExt(length2);
            Assert.Equal(expected, actual);

            width2 = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => length2.AreaOfRectangleExt(width2));

        }

        [Fact]
        public void CircumferenceOfCircle()
        {
            double radius = 3.5;
            double expected = 21.99;
            double actual = Math.Round(radius.CircumferenceOfCircleExt(), 2);
            Assert.Equal(expected, actual);

            int radius2 = 3;
            expected = 18.85;
            actual = Math.Round(radius2.CircumferenceOfCircleExt(), 2);
            Assert.Equal(expected, actual);

            radius = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => radius.CircumferenceOfCircleExt());
        }

        [Fact]
        public void ArcLength()
        {
            double radius = 5;
            double centralAngle = 75;
            double expected = 6.54498;

            double actual = Math.Round(radius.ArcLengthExt(centralAngle), 5);

            Assert.Equal(expected, actual);

            int radius2 = 5;
            int centralAngle2 = 75;
            actual = Math.Round(radius2.ArcLengthExt(centralAngle2), 5);

            Assert.Equal(expected, actual);

            radius = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => radius.ArcLengthExt(centralAngle));

            centralAngle2 = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => radius2.ArcLengthExt(centralAngle2));
        }

        [Fact]
        public void Hypotenuse()
        {
            double a = 5;
            double b = 4.5;
            double c = 6.73;

            Assert.Equal(c, Math.Round(a.HypotenuseExt(b), 2));

            int a2 = 5;
            int b2 = 7;
            c = 8.6;

            Assert.Equal(c, Math.Round(a2.HypotenuseExt(b2), 1));

            a = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => a.HypotenuseExt(b));

            b2 = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => a2.HypotenuseExt(b2));
        }

        [Fact]
        public void VolumeOfCylinder()
        {
            int rad = 2;
            int height = 6;
            double expected = 75.39822;
            double actual = rad.VolumeOfCylinderExt(height).RoundExt(5);
            Assert.Equal(expected, actual);

            double rad2 = 3.4;
            double height2 = 7.98;
            expected = 289.80815;
            actual = rad2.VolumeOfCylinderExt(height2).RoundExt(5);
            Assert.Equal(expected, actual);

            rad = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => rad.VolumeOfCylinderExt(height));

            height2 = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => rad2.VolumeOfCylinderExt(height2));
        }

        [Fact]
        public void VolumeOfSphere()
        {
            int rad = 2;
            double expected = 33.51032;
            double actual = rad.VolumeOfSphereExt().RoundExt(5);
            Assert.Equal(expected, actual);

            double rad2 = 3.4;
            expected = 164.63621;
            actual = rad2.VolumeOfSphereExt().RoundExt(5);
            Assert.Equal(expected, actual);

            rad = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => rad.VolumeOfSphereExt());

            rad2 = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => rad2.VolumeOfSphereExt());
        }

        [Fact]
        public void VolumeOfCone()
        {
            int rad = 2;
            int height = 6;
            double expected = 25.13274;
            double actual = rad.VolumeOfConeExt(height).RoundExt(5);
            Assert.Equal(expected, actual);

            double rad2 = 3.4;
            double height2 = 7.98;
            expected = 96.60272;
            actual = rad2.VolumeOfConeExt(height2).RoundExt(5);
            Assert.Equal(expected, actual);

            rad = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => rad.VolumeOfConeExt(height));

            height2 = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => rad2.VolumeOfConeExt(height2));
        }

        [Fact]
        public void AreaOfTrapezoid()
        {
            int a = 3;
            int b = 4;
            int height = 5;
            double expected = 17.5;
            double actual = height.AreaOfTrapezoidExt(a, b);
            Assert.Equal(expected, actual);

            double a2 = 3.1;
            double b2 = 4.2;
            double height2 = 5.3;
            expected = 19.345;
            actual = height2.AreaOfTrapezoidExt(a2, b2).RoundExt(3);
            Assert.Equal(expected, actual);

            a = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => height.AreaOfTrapezoidExt(a, b));

            b2 = -1.2;
            Assert.Throws<ArgumentOutOfRangeException>(() => height2.AreaOfTrapezoidExt(a2, b2));
        }

        [Fact]
        public void VolumeOfPyramid()
        {
            int length = 3;
            int width = 4;
            int height = 5;

            double expected = 20;
            double actual = length.VolumeOfPyramidExt(width, height);
            Assert.Equal(expected, actual);

            length = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => length.VolumeOfPyramidExt(width, height));

            double length2 = 3;
            double width2 = 4;
            double height2 = 5;

            actual = length2.VolumeOfPyramidExt(width2, height2);
            Assert.Equal(expected, actual);

            width2 = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => length2.VolumeOfPyramidExt(width2, height2));

            width2 = 5;
            height2 = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => length2.VolumeOfPyramidExt(width2, height2));
        }

        [Fact]
        public void VolumeOfCube()
        {
            int edge = 3;
            double expected = 27;
            double actual = edge.VolumeOfCubeExt();
            Assert.Equal(expected, actual);

            edge = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => edge.VolumeOfCubeExt());

            double edge2 = 3.5;
            expected = 42.875;
            actual = edge2.VolumeOfCubeExt().RoundExt(3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AreaOfCylinder()
        {
            int radius = 5;
            int height = 7;
            double expected = 376.99112;
            double actual = radius.AreaOfCylinderExt(height).RoundExt(5);
            Assert.Equal(expected, actual);

            double radius2 = 5.2;
            double height2 = 7.9;
            expected = 428.01058;
            actual = radius2.AreaOfCylinderExt(height2).RoundExt(5);
            Assert.Equal(expected, actual);

            radius = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => radius.AreaOfCylinderExt(height));

            height2 = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => radius2.AreaOfCylinderExt(height2));
        }
    }
}
