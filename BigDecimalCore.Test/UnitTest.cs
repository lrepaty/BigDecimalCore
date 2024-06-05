using Microsoft.VisualBasic;
using System.Numerics;

namespace BigDecimals.Test
{
    [TestClass]
    public class UnitTest
    {
        int oldPrecision;

        [TestInitialize]
        public void Initialize()
        {
            oldPrecision = BigDecimal.Precision;
            BigDecimal.Precision = 10;
        }

        [TestCleanup]
        public void Cleanup()
        {
            BigDecimal.Precision = oldPrecision;
        }

        [TestMethod]
        public void TestBigInteger_0()
        {
            BigInteger value = 0;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
        }

        [TestMethod]
        public void TestBigInteger_5()
        {
            BigInteger value = 5;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToEven) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestBigInteger_Minus5()
        {
            BigInteger value = -5;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToEven) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestBigInteger_15()
        {
            BigInteger value = 15;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToEven) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestBigInteger_Minus15()
        {
            BigInteger value = -15;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToEven) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestBigInteger_6()
        {
            BigInteger value = 6;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestBigInteger_Minus6()
        {
            BigInteger value = -6;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestBigInteger_Random()
        {
            Random rnd = new Random();
            BigInteger value = rnd.NextInt64();
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            value = rnd.Next();
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            value = rnd.Next();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            value = rnd.Next();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            value = rnd.Next();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            value = rnd.Next();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestUInt128_MinValue()
        {
            UInt128 value = UInt128.MinValue;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestUInt128_MaxValue()
        {
            UInt128 value = long.MaxValue;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestInt128_MinValue()
        {
            Int128 value = (Int128)decimal.MinValue/10;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestInt128_MaxValue()
        {
            Int128 value = (Int128)decimal.MaxValue / 10;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestInt128_Random()
        {
            Random rnd = new Random();
            Int128 value = (Int128)rnd.NextInt64();
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            value = (Int128)rnd.NextInt64();
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            value = (Int128)rnd.NextInt64();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            value = (Int128)rnd.NextInt64();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            value = (Int128)rnd.NextInt64();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            value = (Int128)rnd.NextInt64();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestULong_MinValue()
        {
            ulong value = ulong.MinValue;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestULong_MaxValue()
        {
            ulong value = ulong.MaxValue;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestLong_MinValue()
        {
            long value = long.MinValue;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestLong_MaxValue()
        {
            long value = long.MaxValue;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestLong_Random()
        {
            Random rnd = new Random();
            long value = rnd.NextInt64();
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            value = rnd.NextInt64();
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            value = rnd.NextInt64();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            value = rnd.NextInt64();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            value = rnd.NextInt64();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            value = rnd.NextInt64();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestUInt_MinValue()
        {
            uint value = uint.MinValue;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestUInt_MaxValue()
        {
            uint value = uint.MaxValue;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestInt_MinValue()
        {
            int value = int.MinValue;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);
            
            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);
            
            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);
            
            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestInt_MaxValue()
        {
            int value = int.MaxValue;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestInt_Random()
        {
            Random rnd = new Random();
            int value = rnd.Next();
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            value = rnd.Next();
            a = value;
            excepted = (Math.Round((decimal)value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            value = rnd.Next();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            value = rnd.Next();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            value = rnd.Next();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            value = rnd.Next();
            a = value;
            excepted = (Math.Round((decimal)value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestDecimal_0()
        {
            decimal value = 0;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round(value / 10) * 10).ToString();
            actual = a.ToString();

            actual.Should().Be(excepted);
            BigDecimal.Precision = 10;
        }

        [TestMethod]
        public void TestDecimal_5()
        {
            decimal value = 5M;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round(value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }
        [TestMethod]
        public void TestDecimal_Minus5()
        {
            decimal value = -5M;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round(value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestDecimal_6()
        {
            decimal value = 5.000000000051M;
            string excepted = decimal.Round(value, BigDecimal.Precision).ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round(value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);
            BigDecimal.Rounding = MidpointRounding.ToZero;

            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);
            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;

            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);
            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;

            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestDecimal_Minus6()
        {
            decimal value = -5.000000000051M;
            string excepted = decimal.Round(value, BigDecimal.Precision).ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round(value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);
            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestDecimal_MinValue()
        {
            decimal value = decimal.MinValue / 10;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round(value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestDecimal_MaxValue()
        {
            decimal value = decimal.MaxValue / 10;
            string excepted = value.ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round(value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestDecimal_1_123456789051()
        {
            decimal value = 1.123456789051M;
            string excepted = decimal.Round(value, BigDecimal.Precision).ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round(value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestDouble_PositiveExponet1()
        {
            double value = 1.12345678E+25;
            string excepted = "112345678".PadRight(26, '0');
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestDouble_PositiveExponet2()
        {
            double value = 1.12345678E+5;
            string excepted = double.Round(value, BigDecimal.Precision).ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);
            a = value;

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round(value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestDouble_NegativExponetValue()
        {
            double value = 1.12345678E-3;
            string excepted = double.Round(value, BigDecimal.Precision).ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round(value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestDouble_Random()
        {
            Random rnd = new Random();
            double value = rnd.NextDouble();
            string excepted = double.Round(value, BigDecimal.Precision).ToString();
            BigDecimal a = value;
            string actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = -1;
            a = value;
            excepted = (Math.Round(value / 10) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.AwayFromZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.AwayFromZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToZero;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToZero) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToNegativeInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
            a = value;
            excepted = (Math.Round(value / 10, MidpointRounding.ToPositiveInfinity) * 10).ToString();
            actual = a.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 10;
            BigDecimal.Rounding = MidpointRounding.ToEven;
        }

        [TestMethod]
        public void TestCovertToBigInteger()
        {
            Random rnd = new Random();
            BigInteger excepted = rnd.NextInt64();
            BigDecimal a = excepted;
            BigInteger actual = (BigInteger)a;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestCovertToUInt128()
        {
            Random rnd = new Random();
            UInt128 excepted = (UInt128)rnd.NextInt64();
            BigDecimal a = excepted;
            UInt128 actual = (UInt128)a;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestCovertTot128()
        {
            Random rnd = new Random();
            Int128 excepted = (Int128)rnd.NextInt64();
            BigDecimal a = excepted;
            Int128 actual = (Int128)a;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestCovertToULong()
        {
            ulong excepted = 125;
            BigDecimal a = excepted;
            ulong actual = (ulong)a;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestCovertToLong()
        {
            long excepted = 125;
            BigDecimal a = excepted;
            long actual = (long)a;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestCovertToUInt()
        {
            uint excepted = 125;
            BigDecimal a = excepted;
            uint actual = (uint)a;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestCovertToInt()
        {
            int excepted = 125;
            BigDecimal a = excepted;
            int actual = (int)a;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestCovertToUShort()
        {
            ushort excepted = 125;
            BigDecimal a = excepted;
            ushort actual = (ushort)a;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestCovertToShort()
        {
            short excepted = 125;
            BigDecimal a = excepted;
            short actual = (byte)a;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestCovertToByte()
        {
            byte excepted = 125;
            BigDecimal a = excepted;
            byte actual = (byte)a;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestCovertToSByte()
        {
            sbyte excepted = 125;
            BigDecimal a = excepted;
            sbyte actual = (sbyte)a;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestPositiv()
        {
            decimal value = 0.0011234567500650883M;
            string excepted = decimal.Round(+value, BigDecimal.Precision).ToString();
            BigDecimal result = value;
            result = +result;
            string actual = result.ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestNegativ()
        {
            decimal value = 0.0011234567500650883M;
            string excepted = decimal.Round(-value, BigDecimal.Precision).ToString();
            BigDecimal result = value;
            result = -result;
            string actual = result.ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestPlusPlus()
        {
            decimal value = 0.0011234567500650883M;
            string excepted = decimal.Round(++value, BigDecimal.Precision).ToString();
            --value;
            BigDecimal result = value;
            ++result;
            string actual = result.ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestMultiple_10_Powered()
        {
            MidpointRounding oldRouding = BigDecimal.Rounding;
            decimal[] values = { 344, 345, 347, 354, 355, 357 -344, -345, -347, -354, -355, -357 };
            foreach (decimal value in values)
            {
                BigInteger val = (int)value;
                BigDecimal.Rounding = MidpointRounding.ToEven;
                string actual = BigDecimal.Multiple_10_Powered(val, -1).ToString();
                string excepted = decimal.Round(value / 10, 0, BigDecimal.Rounding).ToString();
                actual.Should().Be(excepted);

                BigDecimal.Rounding = MidpointRounding.AwayFromZero;
                actual = BigDecimal.Multiple_10_Powered(val, -1).ToString();
                excepted = decimal.Round(value / 10, 0, BigDecimal.Rounding).ToString();
                actual.Should().Be(excepted);

                BigDecimal.Rounding = MidpointRounding.ToZero;
                actual = BigDecimal.Multiple_10_Powered(val, -1).ToString();
                excepted = decimal.Round(value / 10, 0, BigDecimal.Rounding).ToString();
                actual.Should().Be(excepted);

                BigDecimal.Rounding = MidpointRounding.ToNegativeInfinity;
                actual = BigDecimal.Multiple_10_Powered(val, -1).ToString();
                excepted = decimal.Round(value / 10, 0, BigDecimal.Rounding).ToString();
                actual.Should().Be(excepted);

                BigDecimal.Rounding = MidpointRounding.ToPositiveInfinity;
                actual = BigDecimal.Multiple_10_Powered(val, -1).ToString();
                excepted = decimal.Round(value / 10, 0, BigDecimal.Rounding).ToString();
                actual.Should().Be(excepted);
            }
            BigDecimal.Rounding = oldRouding;
        }

        [TestMethod]
        public void TestMinusMinus()
        {
            decimal value = 0.0011234567500650883M;
            string excepted = decimal.Round(--value, BigDecimal.Precision).ToString();
            ++value;
            BigDecimal result = value;
            --result;
            string actual = result.ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestPlus()
        {
            decimal value1 = 1.12345678M;
            BigDecimal val1 = value1;
            BigDecimal.Precision = 20;
            decimal value2 = 123.456789M;
            BigDecimal val2 = value2;
            string excepted = (value1 + value2).ToString();
            BigDecimal result = val1 + val2;
            string actual = result.ToString();
            actual.Should().Be(excepted);
            BigDecimal.Precision = 10;
        }

        [TestMethod]
        public void TestMinus()
        {
            decimal value1 = 1.12345678M;
            BigDecimal val1 = value1;
            BigDecimal.Precision = 20;
            decimal value2 = 123.456789M;
            BigDecimal val2 = value2;
            string excepted = (value1 - value2).ToString();
            BigDecimal result = val1 - val2;
            string actual = result.ToString();
            actual.Should().Be(excepted);
            BigDecimal.Precision = 10;
        }

        [TestMethod]
        public void TestMultiple()
        {
            BigDecimal.Precision = 20;
            decimal value1 = 9.12M;
            BigDecimal val1 = value1;
            decimal value2 = 9.1234M;
            BigDecimal val2 = value2;
            string excepted = decimal.Round(value1 * value2, BigDecimal.Precision).ToString();
            BigDecimal result = val1 * val2;
            string actual = result.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 20;
            value1 = 9.12345678909234567890M;
            val1 = value1;
            value2 = 9.123456789092345678M;
            val2 = value2;
            excepted = decimal.Round(value1 * value2, BigDecimal.Precision).ToString();
            result = val1 * val2;
            actual = result.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 5;
            value1 = 2000000M;
            val1 = value1;
            BigDecimal.Precision = -1;
            value2 = 300M;
            val2 = value2;
            excepted = (decimal.Round(value1 * value2 / 10) * 10).ToString();
            BigDecimal.Precision = -2;
            result = val1 * val2;
            actual = result.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 5;
            Random rnd = new Random();
            value1 = rnd.Next();
            val1 = value1;
            value2 = rnd.NextInt64();
            val2 = value2;
            excepted = (value1 * value2).ToString();
            result = val1 * val2;
            actual = result.ToString();
            actual.Should().Be(excepted);
            BigDecimal.Precision = 10;
        }

        [TestMethod]
        public void TestDivide()
        {
            BigDecimal.Precision = 5;
            decimal value1 = 1M;
            BigDecimal val1 = value1;
            BigDecimal.Precision = 20;
            decimal value2 = 10M;
            BigDecimal val2 = value2;
            string excepted = decimal.Round(value1 / value2, BigDecimal.Precision).ToString();
            BigDecimal result = val1 / val2;
            string actual = result.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 5;
            value1 = 2000000M;
            val1 = value1;
            BigDecimal.Precision = -1;
            value2 = 300M;
            val2 = value2;
            excepted = (decimal.Round(value1 / value2 / 100) * 100).ToString();
            BigDecimal.Precision = -2;
            result = val1 / val2;
            actual = result.ToString();
            actual.Should().Be(excepted);

            Random rnd = new Random();
            value1 = rnd.NextInt64();
            val1 = value1;
            BigDecimal.Precision = -1;
            value2 = rnd.NextInt64();
            val2 = value2;
            excepted = (decimal.Round(value1 / value2 / 100) * 100).ToString();
            BigDecimal.Precision = -2;
            result = val1 / val2;
            actual = result.ToString();
            actual.Should().Be(excepted);
            BigDecimal.Precision = 10;
        }

        [TestMethod]
        public void TestLower()
        {
            BigDecimal.Precision = 5;
            decimal value1 = 2M;
            BigDecimal val1 = value1;
            BigDecimal.Precision = 20;
            decimal value2 = 3M;
            BigDecimal val2 = value2;
            bool excepted = value1 < value2;
            bool actual = val1 < val2;
            actual.Should().Be(excepted);
            BigDecimal.Precision = 10;
            long value3 = 3;
            actual = val1 < value3;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestLowerOrEquall()
        {
            BigDecimal.Precision = 5;
            decimal value1 = 2M;
            BigDecimal val1 = value1;
            BigDecimal.Precision = 20;
            decimal value2 = 2M;
            BigDecimal val2 = value2;
            bool excepted = value1 <= value2;
            bool actual = val1 <= val2;
            actual.Should().Be(excepted);
            BigDecimal.Precision = 10;
            long value3 = 2;
            actual = val1 <= value3;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestUpper()
        {
            BigDecimal.Precision = 5;
            decimal value1 = 2M;
            BigDecimal val1 = value1;
            BigDecimal.Precision = 20;
            decimal value2 = 3M;
            BigDecimal val2 = value2;
            bool excepted = value1 < value2;
            bool actual = val1 < val2;
            actual.Should().Be(excepted);
            BigDecimal.Precision = 10;
            long value3 = 3;
            actual = val1 < value3;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestUpperOrEquall()
        {
            BigDecimal.Precision = 5;
            decimal value1 = 2M;
            BigDecimal val1 = value1;
            BigDecimal.Precision = 20;
            decimal value2 = 2M;
            BigDecimal val2 = value2;
            bool excepted = value1 >= value2;
            bool actual = val1 >= val2;
            actual.Should().Be(excepted);
            BigDecimal.Precision = 10;
            long value3 = 2;
            actual = val1 >= value3;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestEquall()
        {
            BigDecimal.Precision = 5;
            decimal value1 = 2M;
            BigDecimal val1 = value1;
            BigDecimal.Precision = 20;
            decimal value2 = 2M;
            BigDecimal val2 = value2;
            bool excepted = value1 == value2;
            bool actual = val1 == val2;
            actual.Should().Be(excepted);
            BigDecimal.Precision = 10;
            long value3 = 2;
            actual = val1 == value3;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestNotEquall()
        {
            BigDecimal.Precision = 5;
            decimal value1 = 2M;
            BigDecimal val1 = value1;
            BigDecimal.Precision = 20;
            decimal value2 = 3M;
            BigDecimal val2 = value2;
            bool excepted = value1 != value2;
            bool actual = val1 != val2;
            actual.Should().Be(excepted);
            BigDecimal.Precision = 10;
            long value3 = 3;
            actual = val1 != value3;
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestRound()
        {
            decimal value;
            value = 0.5M;
            BigDecimal val = value;
            string excepted = decimal.Round(value).ToString();
            BigDecimal result = BigDecimal.Round(val);
            string actual = result.ToString();
            actual.Should().Be(excepted);

            value = 1.5M;
            val = value;
            excepted = decimal.Round(value).ToString();
            result = BigDecimal.Round(val);
            actual = result.ToString();
            actual.Should().Be(excepted);

            value = 0.5M;
            val = value;
            excepted = decimal.Round(value, MidpointRounding.AwayFromZero).ToString();
            result = BigDecimal.Round(val, MidpointRounding.AwayFromZero);
            actual = result.ToString();
            actual.Should().Be(excepted);

            value = 1.5M;
            val = value;
            excepted = decimal.Round(value, MidpointRounding.AwayFromZero).ToString();
            result = BigDecimal.Round(val, MidpointRounding.AwayFromZero);
            actual = result.ToString();
            actual.Should().Be(excepted);

            value = 0.5M;
            val = value;
            excepted = decimal.Round(value, MidpointRounding.ToZero).ToString();
            result = BigDecimal.Round(val, MidpointRounding.ToZero);
            actual = result.ToString();
            actual.Should().Be(excepted);

            value = 1.5M;
            val = value;
            excepted = decimal.Round(value, MidpointRounding.ToZero).ToString();
            result = BigDecimal.Round(val, MidpointRounding.ToZero);
            actual = result.ToString();
            actual.Should().Be(excepted);

            value = 0.5M;
            val = value;
            excepted = decimal.Round(value, MidpointRounding.ToNegativeInfinity).ToString();
            result = BigDecimal.Round(val, MidpointRounding.ToNegativeInfinity);
            actual = result.ToString();
            actual.Should().Be(excepted);

            value = 1.5M;
            val = value;
            excepted = decimal.Round(value, MidpointRounding.ToNegativeInfinity).ToString();
            result = BigDecimal.Round(val, MidpointRounding.ToNegativeInfinity);
            actual = result.ToString();
            actual.Should().Be(excepted);

            value = 0.5M;
            val = value;
            excepted = decimal.Round(value, MidpointRounding.ToPositiveInfinity).ToString();
            result = BigDecimal.Round(val, MidpointRounding.ToPositiveInfinity);
            actual = result.ToString();
            actual.Should().Be(excepted);

            value = 1.5M;
            val = value;
            excepted = decimal.Round(value, MidpointRounding.ToPositiveInfinity).ToString();
            result = BigDecimal.Round(val, MidpointRounding.ToPositiveInfinity);
            actual = result.ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestTruncate()
        {
            decimal value;
            value = 0.5M;
            BigDecimal val = value;
            string excepted = decimal.Truncate(value).ToString();
            BigDecimal result = BigDecimal.Truncate(val);
            string actual = result.ToString();
            actual.Should().Be(excepted);

            value = 1.5M;
            val = value;
            excepted = decimal.Truncate(value).ToString();
            result = BigDecimal.Truncate(val);
            actual = result.ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestCeiling()
        {
            decimal value;
            value = 0.5M;
            BigDecimal val = value;
            string excepted = decimal.Ceiling(value).ToString();
            BigDecimal result = BigDecimal.Ceiling(val);
            string actual = result.ToString();
            actual.Should().Be(excepted);

            value = 1.5M;
            val = value;
            excepted = decimal.Ceiling(value).ToString();
            result = BigDecimal.Ceiling(val);
            actual = result.ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestFloor()
        {
            decimal value;
            value = 0.5M;
            BigDecimal val = value;
            string excepted = decimal.Floor(value).ToString();
            BigDecimal result = BigDecimal.Floor(val);
            string actual = result.ToString();
            actual.Should().Be(excepted);

            value = 1.5M;
            val = value;
            excepted = decimal.Floor(value).ToString();
            result = BigDecimal.Floor(val);
            actual = result.ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestSqrt()
        {
            string excepted;
            string actual;
            BigDecimal bigDecimalValue;
            bigDecimalValue = 2;
            excepted = $"1{Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator}4142135623730950488016887242096980785696718753769480731766797379907324784621070388503875343276415727350138462309122970249248360558507372126441214970999358314132226659275055927557999505011527820605714701095599716059702745345968620147285174186408891986095523292304843087143214508397626036279952514079896872533965463318088296406206152583523950547457502877599617298355752203375318570113543746034084988471603868999706990048150305440277903164542478230684929369186215805784631115966687130130156185689872372352885092648612494977154218334204285686060146824720771435854874155657069677653720226485447015858801620758474922657226002085584466521458398893944370926591800311388246468157082630100594858704003186480342194897278290641045072636881313739855256117322040245091227700226941127573627280495738108967504018369868368450725799364729060762996941380475654823728997180326802474420629269124859052181004459842150591120249441341728531478105803603371077309182869314710171111683916581726889419758716582152128229518488472089694633862891562882765952635140542267653239694617511291602408715510135150455381287560052631468017127402653969470240300517495318862925631385188163478001569369176881852378684052287837629389214300655869568685964595155501644724509836896036887323114389415576651040883914292338113206052433629485317049915771756228549741438999188021762430965206564211827316726257539594717255934637238632261482742622208671155839599926521176252698917540988159348640083457085181472231814204070426509056532333398436457865796796519267292399875366617215982578860263363617827495994219403777753681426217738799194551397231274066898329989895386728822856378697749662519966583525776198939322845344735694794962952168891485492538904755828834526096524096542889394538646625744927556381964410316979833061852019379384940057156333720548068540575867999670121372239475821426306585132217408832382947287617393647467837431960001592188807347857617252211867490424977366929207311096369721608933708661156734585334833295254675851644710757848602463600834449114818587655554286455123314219926311332517970608436559704352856410087918500760361009159465670676883605571740076756905096136719401324935605240185999105062108163597726431380605467010293569971042425105781749531057255934984451126922780344913506637568747760283162829605532422426957534529028838768446429173282770888318087025339852338122749990812371892540726475367850304821591801886167108972869229201197599880703818543332536460211082299279293072871780799888099176741774108983060800326311816427988231171543638696617029999341616148786860180455055539869131151860103863753250045581860448040750241195184305674533683613674597374423988553285179308960373898915173195874134428817842125021916951875593444387396189314549999906107587049090260883517636224749757858858368037457931157339802099986622186949922595913276423619410592100328026149874566599688874067956167391859572888642473463585886864496822386006983352642799056283165613913942557649062065186021647263033362975075697870606606856498160092718709292153132368281356988937097416504474590960537472796524477094099241238710614470543986743647338477454819100872886222149589529591187892149179833981083788278153065562315810360648675873036014502273208829351341387227684176678436905294286984908384557445794095986260742499549168028530773989382960362133539875320509199893607513906444495768456993471276364507163279154701597733548638939423257277540038260274785674172580951416307159597849818009443560379390985590168272154034581581521004936662953448827107292396602321638238266612626830502572781169451035379371568823365932297823192986064679789864092085609558142614363631004615594332550474493975933999125419532300932175304476533964706627611661753518754646209676345587386164880198848497479264045065444896910040794211816925796857563784881498986416854994916357614484047021033989215342377037233353115645944389703653166721949049351882905806307401346862641672470110653463493916407146285567980177933814424045269137066609777638784866238003392324370474115331872531906019165996455381157888";
            BigDecimal.Precision = excepted.Length - 2;
            BigDecimal bigDecimalResult = BigDecimal.Sqrt(bigDecimalValue);
            actual = bigDecimalResult.ToString();
            actual.Should().Be(excepted);
            BigDecimal.Precision = 10;
        }

        [TestMethod]
        public void TestIntPow()
        {
            string excepted;
            string actual;
            long lExponent;
            BigDecimal bigDecimalValue;
            bigDecimalValue = 2;
            lExponent = 1000;
            excepted = "10715086071862673209484250490600018105614048117055336074437503883703510511249361224931983788156958581275946729175531468251871452856923140435984577574698574803934567774824230985421074605062371141877954182153046474983581941267398767559165543946077062914571196477686542167660429831652624386837205668069376";
            actual = BigDecimal.IntPow(bigDecimalValue, lExponent).ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestPow()
        {
            string excepted;
            string actual;
            decimal value;
            BigDecimal bigDecimalValue;
            BigDecimal.Precision = 30;
            value = 235;
            excepted = (value * value).ToString();
            bigDecimalValue = value;
            actual = BigDecimal.Pow(bigDecimalValue, 2).ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestExp()
        {
            //https://cs.wikipedia.org/wiki/Eulerovo_%C4%8D%C3%ADslo
            string excepted;
            string actual;
            BigDecimal bigDecimalResult;
            decimal dValue = 1;
            excepted = $"2{Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator}71828182845904523536028747135266249775724709369995957496696762772407663035354759457138217852516642742746639193200305992181741359662904357290033429526059563073813232862794349076323382988075319525101901157383418793070215408914993488416750924476146066808226480016847741185374234544243710753907774499206955170276183860626133138458300075204493382656029760673711320070932870912744374704723069697720931014169283681902551510865746377211125238978442505695369677078544996996794686445490598793163688923009879312773617821542499922957635148220826989519366803318252886939849646510582093923982948879332036250944311730123819706841614039701983767932068328237646480429531180232878250981945581530175671736133206981125099618188159304169035159888851934580727386673858942287922849989208680582574927961048419844436346324496848756023362482704197862320900216099023530436994184914631409343173814364054625315209618369088870701676839642437814059271456354906130310720851038375051011574770417189861068739696552126715468895704";
            BigDecimal.Precision = excepted.Length - 2;
            bigDecimalResult = BigDecimal.Exp(dValue);
            actual = bigDecimalResult.ToString();
            actual.Should().Be(excepted);
            BigDecimal.Precision = oldPrecision;
        }

        [TestMethod]
        public void TestLn()
        {
            string excepted;
            string actual;
            BigDecimal bigDecimalValue;
            bigDecimalValue = 2;
            excepted = $"0{Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator}6931471805599453094172321214581765680755001343602552541206800094933936219696947156058633269964186875";
            BigDecimal.Precision = excepted.Length;
            BigDecimal result = BigDecimal.Ln(bigDecimalValue);
            actual =  BigDecimal.Round(result, excepted.Length - 2).ToString();
            actual.Should().Be(excepted);
            BigDecimal.Precision = excepted.Length - 2;
            result = BigDecimal.Exp(result);
            result.Should().Be(bigDecimalValue);
        }

        [TestMethod]
        public void TestPi()
        {
            string excepted;
            string actual;
            excepted = $"3{Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator}141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481117450284102701938521105559644622948954930381964";
            BigDecimal.Precision = excepted.Length - 2;
            actual = BigDecimal.PI.ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestSin()
        {
            string excepted;
            string actual;
            BigDecimal.Precision = 300;
            excepted = (BigDecimal.Sqrt(2) / 2).ToString();
            actual = BigDecimal.Sin(BigDecimal.PI / 4).ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestCos()
        {
            string excepted;
            string actual;
            BigDecimal.Precision = 300;
            excepted = (BigDecimal.Sqrt(2) / 2).ToString();
            actual = BigDecimal.Cos(BigDecimal.PI / 4).ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestTan()
        {
            string excepted;
            string actual;
            BigDecimal value, result;
            BigDecimal.Precision = 300;
            value = BigDecimal.PI / 8;
            BigDecimal.Precision += 2;
            result = BigDecimal.Sin(value) / BigDecimal.Cos(value);
            BigDecimal.Precision -= 2;
            result = new BigDecimal(result);
            excepted = result.ToString();
            actual = BigDecimal.Tan(value).ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestSinh()
        {
            string excepted;
            string actual;
            BigDecimal value, result;
            BigDecimal.Precision = 300;
            value = BigDecimal.PI / 4;
            BigDecimal.Precision += 2;
            result = (BigDecimal.Exp(value) - BigDecimal.Exp(-value)) / 2;
            BigDecimal.Precision -= 2;
            result = new BigDecimal(result);
            excepted = result.ToString();
            actual = BigDecimal.Sinh(value).ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestCosh()
        {
            string excepted;
            string actual;
            BigDecimal value, result;
            BigDecimal.Precision = 300;
            value = BigDecimal.PI / 4;
            BigDecimal.Precision += 2;
            result = (BigDecimal.Exp(value) + BigDecimal.Exp(-value)) / 2;
            BigDecimal.Precision -= 2;
            result = new BigDecimal(result);
            excepted = result.ToString();
            actual = BigDecimal.Cosh(value).ToString();
            actual.Should().Be(excepted);
        }


        [TestMethod]
        public void TestTanh()
        {
            string excepted;
            string actual;
            BigDecimal value, result;
            BigDecimal.Precision = 300;
            value = BigDecimal.PI / 4;
            BigDecimal.Precision += 2;
            result = BigDecimal.Sinh(value) / BigDecimal.Cosh(value);
            BigDecimal.Precision -= 2;
            result = new BigDecimal(result);
            excepted = result.ToString();
            actual = BigDecimal.Tanh(value).ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestToString()
        {
            string actual;
            string excepted;
            BigDecimal bigDecimalValue;
            decimal value;
            BigDecimal.Precision = -2;
            value = 150M;
            bigDecimalValue = value;
            excepted = (Math.Round(value / 100) * 100).ToString();
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            bigDecimalValue = BigDecimal.Parse(actual);
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            value = -150M;
            excepted = (Math.Round(value / 100) * 100).ToString();
            bigDecimalValue = value;
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            bigDecimalValue = BigDecimal.Parse(actual);
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            bigDecimalValue = BigDecimal.Parse(actual);
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 14;
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            bigDecimalValue = BigDecimal.Parse(actual);
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            value = 0.12345678901234567891M;
            excepted = (decimal.Ceiling(value * (decimal)Math.Pow(10, 14)) / (decimal)Math.Pow(10, 14)).ToString();
            bigDecimalValue = value;
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            BigDecimal.Precision = 30;
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            value = -0.12345678901234567891M;
            excepted = value.ToString();
            bigDecimalValue = value;
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            value = 1123456789012345.6789M;
            excepted = value.ToString();
            bigDecimalValue = value;
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            value = -1123456789012345.6789M;
            excepted = value.ToString();
            bigDecimalValue = value;
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            value = 0.012345678901234567M;
            excepted = value.ToString();
            bigDecimalValue = value;
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            value = -0.012345678901234567M;
            excepted = value.ToString();
            bigDecimalValue = value;
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            value = 123456789012340;
            excepted = value.ToString();
            bigDecimalValue = value;
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            bigDecimalValue = BigDecimal.Parse(actual);
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            value = -123456789012340;
            excepted = value.ToString();
            bigDecimalValue = value;
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            bigDecimalValue = BigDecimal.Parse(actual);
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);

            Random random = new Random();
            value = (decimal)random.NextDouble();
            excepted = value.ToString();
            bigDecimalValue = value;
            actual = bigDecimalValue.ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestParse()
        {
            string value;
            decimal decVal;
            BigDecimal result;
            string actual;
            string excepted;

            value = 0.5M.ToString();
            decVal = decimal.Parse(value);
            excepted = decVal.ToString();
            result = BigDecimal.Parse(value);
            actual = result.ToString();
            actual.Should().Be(excepted);
        }

        [TestMethod]
        public void TestTryParse()
        {
            bool retVal1;
            bool retVal2;
            string value;
            decimal decVal;
            BigDecimal result;
            string actual;
            string excepted;

            value = 0.5M.ToString();
            retVal1 = decimal.TryParse(value, out decVal);
            excepted = decVal.ToString();
            retVal2 = BigDecimal.TryParse(value, out result);
            actual = result.ToString();
            actual.Should().Be(excepted);
            retVal1.Should().Be(retVal2);

            value = 0.5M.ToString() + "a";
            retVal1 = decimal.TryParse(value, out decVal);
            excepted = decVal.ToString();
            retVal2 = BigDecimal.TryParse(value, out result);
            actual = result.ToString();
            actual.Should().Be(excepted);
            retVal1.Should().Be(retVal2);
        }
    }
}
