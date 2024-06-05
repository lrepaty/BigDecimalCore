// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
    [Serializable]
    [TypeForwardedFrom("System.Numerics, Version=4.0.0.0, PublicKeyToken=b77a5c561934e089")]

    public readonly struct BigDecimal
    : IComparable,
      IComparable<BigDecimal>,
      IEquatable<BigDecimal>
    {
        /// Number of decimal places
        public static int Precision = 50;

        // Summary:
        //     Specifies the strategy that mathematical rounding methods should use to round
        //     a number.
        public static MidpointRounding Rounding = MidpointRounding.ToEven;

        // Constant representing the BigDecimal value 0.
        public static BigDecimal Zero = 0;

        // Constant representing the BigDecimal value 1.
        public static BigDecimal One = 1;

        // Constant representing the BigDecimal value -1.
        public static BigDecimal MinusOne = -1;

        public bool IsZero => _mantisa == 0;

        public bool IsOne => this == One;

        // Mantisa
        internal readonly BigInteger _mantisa;

        // Exponent
        internal readonly int _exponent;
        
        private static string numberDecimalSeparator => Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        // Constructs a BigDecimal from an BigDecimal.
        //
        public BigDecimal(BigDecimal value)
        {
            _mantisa = value._mantisa;
            _exponent = value._exponent;
            if (Precision < -_exponent)
            {
                _mantisa = Multiple_10_Powered(_mantisa, Precision + _exponent);
                _exponent = -Precision;
            }
        } 
        
        // Constructs a BigDecimal from an BigInteger.
        //
        public BigDecimal(BigInteger value)
        {
            _mantisa = value;
            _exponent = 0;
            if (Precision < -_exponent)
            {
                _mantisa = Multiple_10_Powered(_mantisa, Precision + _exponent);
                _exponent = -Precision;
            }
        }

        // Constructs a BigDecimal from an unsigned long value.
        //
        public BigDecimal(UInt128 value)
        {
            _mantisa = value;
            _exponent = 0;
            if (Precision < -_exponent)
            {
                _mantisa = Multiple_10_Powered(_mantisa, Precision + _exponent);
                _exponent = -Precision;
            }
        }

        // Constructs a BigDecimal from an unsigned long value.
        //
        public BigDecimal(Int128 value)
        {
            _mantisa = value;
            _exponent = 0;
            if (Precision < -_exponent)
            {
                _mantisa = Multiple_10_Powered(_mantisa, Precision + _exponent);
                _exponent = -Precision;
            }
        }

        // Constructs a BigDecimal from an unsigned long value.
        //
        public BigDecimal(ulong value)
        {
            _mantisa = value;
            _exponent = 0;
            if (Precision < -_exponent)
            {
                _mantisa = Multiple_10_Powered(_mantisa, Precision + _exponent);
                _exponent = -Precision;
            }
        }

        // Constructs a BigDecimal from an long value.
        //
        public BigDecimal(long value)
        {
            _mantisa = value;
            if (Precision < -_exponent)
            {
                _mantisa = Multiple_10_Powered(_mantisa, Precision + _exponent);
                _exponent = -Precision;
            }
        }

        // Constructs a BigDecimal from an double-precision floating-point value.
        //
        public BigDecimal(double value)
        {
            string ret = value.ToString();
            int pos = ret.LastIndexOf("E");
            int length;
            if (pos > -1)
            {
                _exponent = int.Parse(ret.Substring(pos + 1));
                ret = ret.Substring(0, pos);
                pos = ret.LastIndexOf(numberDecimalSeparator);
                length = ret.Substring(pos + 1).Length;
                _exponent -= length;
                ret = ret.Remove(pos, numberDecimalSeparator.Length);
                if (_exponent - length < 0)
                {
                    if (ret.Length <= _exponent + length)
                    {
                        ret = "0.".PadRight(_exponent + length - ret.Length + 2, '0') + ret;
                    }
                }
            }
            pos = ret.LastIndexOf(numberDecimalSeparator);
            if (pos > -1)
            {
                _exponent = pos + 1 - ret.Length;
                ret = ret.Remove(pos, numberDecimalSeparator.Length);
            }
            _mantisa = BigInteger.Parse(ret);
            if (Precision < -_exponent)
            {
                _mantisa = Multiple_10_Powered(_mantisa, Precision + _exponent);
                _exponent = -Precision;
            }
        }

        // Constructs a BigDecimal from an decimal value.
        //
        public BigDecimal(decimal value)
        {
            string ret = value.ToString();
            int pos = ret.LastIndexOf(numberDecimalSeparator);
            if (pos > -1)
            {
                _exponent = pos + 1 - ret.Length;
                ret = ret.Remove(pos, numberDecimalSeparator.Length);
            }
            _mantisa = BigInteger.Parse(ret);
            if (Precision < -_exponent)
            {
                _mantisa = Multiple_10_Powered(_mantisa, Precision + _exponent);
                _exponent = -Precision;
            }
        }

        private BigDecimal(BigInteger value, int exponent)
        {
            _mantisa = value;
            _exponent = exponent;
            if (Precision < -_exponent)
            {
                _mantisa = Multiple_10_Powered(_mantisa, Precision + _exponent);
                _exponent = -Precision;
            }
        }

        // Value multiple 10 Powered power
        //
        public static BigInteger Multiple_10_Powered(BigInteger value, int power)
        {
            BigInteger remainder;
            BigInteger maxremainder;
            BigInteger result;
            int sign;
            result = value;
            if (power > 0)
            {
                result *= BigInteger.Pow(10, power);
            }
            else if (power < 0)
            {
                if (value < 0)
                {
                    sign = -1;
                    result = -value;
                }
                else
                    sign = 1;
                result = BigInteger.DivRem(result, BigInteger.Pow(10, -power), out remainder);
                switch (Rounding)
                {
                    case MidpointRounding.ToEven:
                    case MidpointRounding.AwayFromZero:
                        maxremainder = 5 * BigInteger.Pow(10, -power - 1);
                        if (Rounding == MidpointRounding.ToEven)
                        {
                            if (result % 2 == 0)
                                maxremainder++;
                        }
                        if (remainder >= maxremainder)
                            result++;
                        break;
                    case MidpointRounding.ToPositiveInfinity:
                        if (remainder > 0 && sign == 1)
                            result++;
                        break;
                    case MidpointRounding.ToNegativeInfinity:
                        if (remainder > 0 && sign == -1)
                            result++;
                        break;
                }
                if (sign == -1)
                    result = -result;
            }
            return result;
        }

        // Compares this object to another object, returning an integer that
        // indicates the relationship.
        // Returns a value less than zero if this  object
        // null is considered to be less than any instance.
        // If object is not of type BigDecimal, this method throws an ArgumentException.
        //
        public int CompareTo(object? obj)
        {
            if (obj == null)
                return 1;
            if (obj is not BigDecimal bigDec)
                throw new ArgumentException("Argument must be BigDecimal", nameof(obj));
            return CompareTo(bigDec);
        }

        public int CompareTo(BigDecimal value)
        {
            BigInteger leftMantisa, rightMantisa;
            int exponent;
            SetEqualPrecision(this, value, out leftMantisa, out rightMantisa, out exponent);
            return leftMantisa.CompareTo(rightMantisa);
        }

        private static void SetEqualPrecision(BigDecimal left, BigDecimal right, out BigInteger leftMantisa, out BigInteger rightMantisa, out int exponent)
        {
            int diference;
            diference = left._exponent - right._exponent;
            if (diference <= 0)
            {
                if (diference < 0)
                {
                    rightMantisa = Multiple_10_Powered(right._mantisa, -diference);
                }
                else
                {
                    rightMantisa = right._mantisa;
                }
                leftMantisa = left._mantisa;
                exponent = left._exponent;
            }
            else
            {
                leftMantisa = Multiple_10_Powered(left._mantisa, diference);
                rightMantisa = right._mantisa;
                exponent = right._exponent;
            }
        }


        // Checks if this BigDecimal is equal to a given object. Returns true
        // if the given object is a boxed BigDecimal and its value is equal to the
        // value of this BigDecimal. Returns false otherwise.
        //
        public override bool Equals([NotNullWhen(true)] object? value) =>
            value is BigDecimal other &&
            Equals(other);

        public bool Equals(BigDecimal value)
        {
            BigInteger leftMantisa, rightMantisa;
            int exponent;
            SetEqualPrecision(this, value, out leftMantisa, out rightMantisa, out exponent);
            return leftMantisa.Equals(rightMantisa);
        }

        // Compares two BigDecimal values for equality. Returns true if the two
        // BigDecimal values are equal, or false if they are not equal.
        //
        public static bool Equals(BigDecimal d1, BigDecimal d2)
        {
            return d1.Equals(d2);
        }

        // Rounds a BigDecimal value to a given number of decimal places. The value
        // given by d is rounded to the number of decimal places given by
        // decimals. The decimals argument must be an integer between
        // 0 and 28 inclusive.
        //
        // By default a mid-point value is rounded to the nearest even number. If the mode is
        // passed in, it can also round away from zero.

        public static BigDecimal Round(BigDecimal d) => Round(ref d, 0, MidpointRounding.ToEven);
        public static BigDecimal Round(BigDecimal d, int decimals) => Round(ref d, decimals, MidpointRounding.ToEven);
        public static BigDecimal Round(BigDecimal d, MidpointRounding mode) => Round(ref d, 0, mode);
        public static BigDecimal Round(BigDecimal d, int decimals, MidpointRounding mode) => Round(ref d, decimals, mode);

        private static BigDecimal Round(ref BigDecimal d, int decimals, MidpointRounding mode)
        {
            MidpointRounding oldRound;
            BigInteger mantisa;
            int exponent;
            mantisa = d._mantisa;
            exponent = d._exponent;
            if (decimals < -d._exponent)
            {
                oldRound = Rounding;
                Rounding = mode;
                mantisa = Multiple_10_Powered(d._mantisa, decimals + d._exponent);
                exponent = -decimals;
                Rounding = oldRound;
            }
            return new BigDecimal(mantisa, exponent);
        }

        // Truncates a BigDecimal to an integer value. The BigDecimal argument is Rounding
        // towards zero to the nearest integer value, corresponding to removing all
        // digits after the decimal point.
        //
        public static BigDecimal Truncate(BigDecimal d) => Truncate(ref d);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static BigDecimal Truncate(ref BigDecimal d) => Round(ref d, 0, MidpointRounding.ToZero);

        // Rounds a BigDecimal to an integer value. The BigDecimal argument is Rounding
        // towards positive infinity.
        public static BigDecimal Ceiling(BigDecimal d) => Round(ref d, 0, MidpointRounding.ToPositiveInfinity);

        // Rounds a BigDecimal to an integer value. The BigDecimal argument is rounded
        // towards negative infinity.
        //
        public static BigDecimal Floor(BigDecimal d) => Round(ref d, 0, MidpointRounding.ToNegativeInfinity);

        public override int GetHashCode()
        {
            return (_mantisa.GetHashCode() * 397) ^ _exponent;
        }

        #region Conversions
        public static implicit operator BigDecimal(BigInteger value) => new BigDecimal(value);
        public static implicit operator BigDecimal(UInt128 value) => new BigDecimal(value);
        public static implicit operator BigDecimal(Int128 value) => new BigDecimal(value);
        public static implicit operator BigDecimal(ulong value) => new BigDecimal(value);
        public static implicit operator BigDecimal(long value) => new BigDecimal(value);
        public static implicit operator BigDecimal(uint value) => new BigDecimal((ulong)value);
        public static implicit operator BigDecimal(double value) => new BigDecimal(value);
        public static implicit operator BigDecimal(decimal value) => new BigDecimal(value);
        public static explicit operator BigInteger(BigDecimal value) => BigInteger.Parse(Round(value).ToString());
        public static explicit operator UInt128(BigDecimal value) => UInt128.Parse(Round(value).ToString());
        public static explicit operator Int128(BigDecimal value) => Int128.Parse(Round(value).ToString());
        public static explicit operator UInt64(BigDecimal value) => UInt64.Parse(Round(value).ToString());
        public static explicit operator Int64(BigDecimal value) => Int64.Parse(Round(value).ToString());
        public static explicit operator UInt32(BigDecimal value) => UInt32.Parse(Round(value).ToString());
        public static explicit operator decimal(BigDecimal value) => decimal.Parse(Round(value).ToString());
        public static explicit operator double(BigDecimal value) => double.Parse(Round(value).ToString());
        #endregion

        //
        // Summary:
        //     Returns the value of the System.Numerics.BigDecimal operand. (The sign of the
        //     operand is unchanged.)
        //
        // Parameters:
        //   value:
        //     An integer value.
        //
        // Returns:
        //     The value of the value operand.
        public static BigDecimal operator +(BigDecimal value)
        {
            BigInteger mantisa;
            int exponent;
            mantisa = value._mantisa;
            exponent = value._exponent;
            if (Precision < -exponent)
            {
                mantisa = Multiple_10_Powered(mantisa, Precision + exponent);
                exponent = -Precision;
            }
            return new BigDecimal(mantisa, exponent);
        }

        //
        // Summary:
        //     Adds the values of two specified System.Numerics.BigDecimal objects.
        //
        // Parameters:
        //   left:
        //     The first value to add.
        //
        //   right:
        //     The second value to add.
        //
        // Returns:
        //     The sum of left and right.
        public static BigDecimal operator +(BigDecimal left, BigDecimal right)
        {
            BigInteger leftMantisa, rightMantisa;
            int exponent;
            SetEqualPrecision(left, right, out leftMantisa, out rightMantisa, out exponent);
            return new BigDecimal(leftMantisa + rightMantisa, exponent);
        }

        // Adds two BigDecimal values.
        //
        public static BigDecimal Add(BigDecimal d1, BigDecimal d2)
        {
            return d1 + d2;
        }

        //
        // Summary:
        //     Negates a specified BigDecimal value.
        //
        // Parameters:
        //   value:
        //     The value to negate.
        //
        // Returns:
        //     The result of the value parameter multiplied by negative one (-1).
        public static BigDecimal operator -(BigDecimal value)
        {
            BigInteger mantisa;
            int exponent;
            mantisa = -value._mantisa;
            exponent = value._exponent;
            if (Precision < -exponent)
            {
                mantisa = Multiple_10_Powered(mantisa, Precision + exponent);
                exponent = -Precision;
            }
            return new BigDecimal(mantisa, exponent);
        }

        // Returns the negated value of the given BigDecimal. If d is non-zero,
        // the result is -d. If d is zero, the result is zero.
        //
        public static BigDecimal Negate(BigDecimal d) => -d;

        //
        // Summary:
        //     Subtracts a System.Numerics.BigDecimal value from another System.Numerics.BigDecimal
        //     value.
        //
        // Parameters:
        //   left:
        //     The value to subtract from (the minuend).
        //
        //   right:
        //     The value to subtract (the subtrahend).
        //
        // Returns:
        //     The result of subtracting right from left.
        public static BigDecimal operator -(BigDecimal left, BigDecimal right)
        {
            return left + -right;
        }

        // Subtracts two BigDecimal values.
        //
        public static BigDecimal Subtract(BigDecimal d1, BigDecimal d2)
        {
            return d1 - d2;
        }

        //
        // Summary:
        //     Increments a System.Numerics.BigDecimal value by 1.
        //
        // Parameters:
        //   value:
        //     The value to increment.
        //
        // Returns:
        //     The value of the value parameter incremented by 1.
        public static BigDecimal operator ++(BigDecimal value)
        {
            BigDecimal result = value + One;
            return result;
        }

        //
        // Summary:
        //     Decrements a System.Numerics.BigDecimal value by 1.
        //
        // Parameters:
        //   value:
        //     The value to decrement.
        //
        // Returns:
        //     The value of the value parameter decremented by 1.
        public static BigDecimal operator --(BigDecimal value)
        {
            BigDecimal result = value - One;
            return result;
        }

        public static BigDecimal operator *(BigDecimal left, BigDecimal right)
        {
            BigDecimal result = new(left._mantisa * right._mantisa, left._exponent + right._exponent);
            return result;
        }

        // Multiplies two BigDecimal values.
        //
        public static BigDecimal Multiply(BigDecimal d1, BigDecimal d2)
        {
            return d1 * d2;
        }

        public static BigDecimal operator /(BigDecimal dividend, BigDecimal divisor)
        {
            if (divisor.IsZero)
                throw new DivideByZeroException();

            if (divisor.IsOne)
                return divisor;

            if (dividend.IsZero)
                return Zero;

            BigInteger mantisa;
            int multiple = Precision + dividend._exponent - divisor._exponent + 1;
            mantisa = Multiple_10_Powered(dividend._mantisa, multiple);
            mantisa = mantisa / divisor._mantisa;
            return new BigDecimal(mantisa, -Precision -1);
        }

        // Divides two BigDecimal values.
        //
        public static BigDecimal Divide(BigDecimal d1, BigDecimal d2)
        {
            return d1 / d2;
        }

        public static bool operator <(BigDecimal left, BigDecimal right)
        {
            BigInteger leftMantisa, rightMantisa;
            int exponent;
            SetEqualPrecision(left, right, out leftMantisa, out rightMantisa, out exponent);
            return leftMantisa.CompareTo(rightMantisa) < 0;
        }

        public static bool operator <=(BigDecimal left, BigDecimal right)
        {
            BigInteger leftMantisa, rightMantisa;
            int exponent;
            SetEqualPrecision(left, right, out leftMantisa, out rightMantisa, out exponent);
            return leftMantisa.CompareTo(rightMantisa) <= 0;
        }

        public static bool operator >(BigDecimal left, BigDecimal right)
        {
            BigInteger leftMantisa, rightMantisa;
            int exponent;
            SetEqualPrecision(left, right, out leftMantisa, out rightMantisa, out exponent);
            return leftMantisa.CompareTo(rightMantisa) > 0;
        }

        public static bool operator >=(BigDecimal left, BigDecimal right)
        {
            BigInteger leftMantisa, rightMantisa;
            int exponent;
            SetEqualPrecision(left, right, out leftMantisa, out rightMantisa, out exponent);
            return leftMantisa.CompareTo(rightMantisa) >= 0;
        }

        public static bool operator ==(BigDecimal left, BigDecimal right)
        {
            BigInteger leftMantisa, rightMantisa;
            int exponent;
            SetEqualPrecision(left, right, out leftMantisa, out rightMantisa, out exponent);
            return leftMantisa.Equals(rightMantisa);
        }

        public static bool operator !=(BigDecimal left, BigDecimal right)
        {
            BigInteger leftMantisa, rightMantisa;
            int exponent;
            SetEqualPrecision(left, right, out leftMantisa, out rightMantisa, out exponent);
            return !leftMantisa.Equals(rightMantisa);
        }

        public static BigDecimal Abs(BigDecimal value)
        {
            return (value >= Zero) ? new(value) : new(-value);
        }

        /// <inheritdoc cref="INumber{TSelf}.Max(TSelf, TSelf)" />
        public static BigDecimal Max(BigDecimal x, BigDecimal y)
        {
            if (x >= y)
                return new(x);
            else
                return new(y);
        }

        /// <inheritdoc cref="INumber{TSelf}.Min(TSelf, TSelf)" />
        public static BigDecimal Min(BigDecimal x, BigDecimal y)
        {
            if (x <= y)
                return new(x);
            else
                return new(y);
        }

        //
        // Summary:
        //     Raises a System.Numerics.BigDecimal value to the power of a specified value.
        //
        // Parameters:
        //   value:
        //     The number to raise to the exponent power.
        //
        //   exponent:
        //     The exponent to raise value by.
        //
        // Returns:
        //     The result of raising value to the exponent power.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     exponent is negative.
        public static BigDecimal Sqrt(BigDecimal value)
        {
            //Babylonian method.
            //x0 = value
            //y0 = 1;
            //xn = (xn-1 + yn-1)/2
            //yn = value/xn
            BigDecimal x;
            BigDecimal y;
            BigDecimal maxDifenece;
            bool done;
            int oldPrecision;
            if (value._mantisa < 0)
                throw new OutOfMemoryException();
            else if (value._mantisa == 0)
                x = value;
            else
            {
                oldPrecision = Precision;
                if (Precision < Int32.MaxValue - 1)
                    Precision += 2;
                if (Precision < Int32.MaxValue)
                    ++Precision;
                maxDifenece = new BigDecimal(1, -Precision);
                x = value;
                y = 1;
                done = false;
                while (!done)
                {
                    x = (x + y) / 2;
                    y = value / x;
                    if (Abs(x - y) <= maxDifenece)
                    {
                        done = true;
                    }
                    else
                    {
                        Thread.Yield();
                    }
                }
                Precision = oldPrecision;
            }
            return new BigDecimal(x);
        }

        //
        // Summary:
        //     Returns a specified number raised to the specified power.
        //
        // Parameters:
        //   value:
        //     A System.Numerics.BigDecimal number to be raised to a power.
        //
        //   exponent:
        //     A 64-bit signed integer value that specifies a power.
        //
        // Returns:
        //     The number value raised to the power exponent.
        public static BigDecimal IntPow(BigDecimal value, long exponent)
        {
            BigDecimal result;
            // If the exponent is negative, compute 1/(x^-exponent).
            if (exponent < 0)
            {
                return 1 / IntPow(value, -exponent);
            }

            result = 1;
            // Loop to compute value^exponent.
            while (exponent > 0)
            {
                // Is the rightmost bit a 1?
                if ((exponent & 1) == 1)
                {
                    result = result * value;
                }

                // Square x and shift exponent 1 bit to the right.
                value *= value;
                exponent >>= 1;
                if (exponent > 0)
                    Thread.Yield();
            }
            return result;
        }

        //
        // Summary:
        //     Raises a System.Numerics.BigDecimal value to the power of a specified value.
        //
        // Parameters:
        //   value:
        //     The number to raise to the exponent power.
        //
        //   exponent:
        //     The exponent to raise value by.
        //
        // Returns:
        //     The result of raising value to the exponent power.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     exponent is negative.
        public static BigDecimal Pow(BigDecimal x, BigDecimal exponent)
        {
            int oldPrecision, add;
            BigDecimal result;
            oldPrecision = Precision;
            add = (int)(Ln(x) * exponent);
            if (Precision <= Int32.MaxValue - add)
                Precision += add;
            else
                Precision = Int32.MaxValue;
            result = Ln(x) * exponent;
            result = Exp(result);
            Precision = oldPrecision;
            return new BigDecimal(result);
        }

        //
        // Summary:
        //     Returns the value of the constant e (Euler's number) raised to the power of a given number (value).
        //     The constant e is approximately equal to 2.71828, which is the base of the natural logarithm.
        //
        // Parameters:
        //   value:
        //     exponent.
        //
        // Returns:
        //     e (Euler's number) raised to the power of a given number
        //https://www.codeproject.com/Tips/311714/Natural-Logarithms-and-Exponent
        public static BigDecimal Exp(BigDecimal Exponent)
        {
            int oldPrecision, i;
            BigDecimal result, x, y, maxDifenece;
            bool done;
            oldPrecision = Precision;
            if (Precision < Int32.MaxValue - 1)
                Precision += 2;
            if (Precision < Int32.MaxValue)
                ++Precision;
            maxDifenece = new BigDecimal(1, -Precision);
            i = 1;
            x = Exponent;
            y = x;
            result = 1 + x;
            done = false;
            while (!done)
            {
                i++;
                y *= x / i;
                result += y;
                if (Abs(y) <= maxDifenece)
                {
                    done = true;
                }
                else
                {
                    Thread.Yield();
                }
            }
            Precision = oldPrecision;
            return new BigDecimal(result);
        }

        //
        // Summary:
        //    Returns logarithm (ln) of a specified value.
        //
        // Parameters:
        //   value:
        //     The number to for calculate natural logarithm.
        //
        // Returns:
        //     The result of natural logarithm of value.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     exponent is negative or zero.
        public static BigDecimal Ln(BigDecimal value)
        {
            // Using Newton's method, the iteration simplifies to (implementation) 
            // which has cubic convergence to ln(x).
            BigDecimal x, result, maxDifenece;
            bool done;
            int i;
            if (value < 0)
                throw new OutOfMemoryException();
            int oldPrecision = Precision;
            if (Precision < Int32.MaxValue - 1)
                Precision += 2;
            if (Precision < Int32.MaxValue)
                ++Precision;
            maxDifenece = new BigDecimal(1, -Precision);
            x = value - 1; // using the first term of the taylor series as initial-value
            result = x;
            done = false;
            i = 0;
            while (!done)
            {
                i++;
                x = result;
                result = x + 2 * (value - Exp(x)) / (value + Exp(x));
                if (Abs(x - result) <= maxDifenece)
                {
                    done = true;
                }
                else
                {
                    Thread.Yield();
                }
            };
            Precision = oldPrecision;
            return new BigDecimal(result);
        }

        //
        // Summary:
        //     Returns sine of teh specified angle.
        //
        // Parameters:
        //   value:
        //     specified angle in radians.
        //
        // Returns:
        //     The result of sine of value.
        //
        public static BigDecimal Sin(BigDecimal value)
        {
            // Using Maclaurin series expansion for sin(x)
            //sin(x) = x - x3 / 3! + x5 / 5! - x7 / 7! + ....
            int oldPrecision;
            BigDecimal result, temp, maxDifenece;
            bool done;
            oldPrecision = Precision;
            if (Precision < Int32.MaxValue - 1)
                Precision += 2;
            if (Precision < Int32.MaxValue)
                ++Precision;
            maxDifenece = new BigDecimal(1, -Precision);
            // Declaring variable to calculate final answer
            result = value;
            temp = value;
            done = false; 
            for (int i = 1; !done; i++)
            {
                // Updating temp and answer accordingly
                temp = ((-temp) * value * value) /
                            ((2 * i) * (2 * i + 1));
                result += temp;
                if (Abs(temp) <= maxDifenece)
                {
                    done = true;
                }
                else
                {
                    Thread.Yield();
                }
            }
            Precision = oldPrecision;
            return new BigDecimal(result);
        }

        //
        // Summary:
        //     Return the cosine of teh specified angle.
        //
        // Parameters:
        //   value:
        //     specified angle in radians.
        //
        // Returns:
        //     The result of cosine of value.
        //
        public static BigDecimal Cos(BigDecimal value)
        {
            // Using Maclaurin series expansion for cos(x)
            //cos(x) = 1 - x2 / 2! + x4 / 4! - x6 / 6! + ....
            int oldPrecision;
            BigDecimal result, temp, maxDifenece;
            bool done;
            oldPrecision = Precision;
            if (Precision < Int32.MaxValue - 1)
                Precision += 2;
            if (Precision < Int32.MaxValue)
                ++Precision;
            maxDifenece = new BigDecimal(1, -Precision);

            // Declaring variable to calculate final answer
            result = 1;
            temp = 1;
            done = false;
            for (int i = 1; !done; i++)
            {
                // Updating temp and answer accordingly
                temp = ((-temp) * value * value) /
                            ((2 * i - 1) * (2 * i));
                result += temp;
                if (Abs(temp) <= maxDifenece)
                {
                    done = true;
                }
                else
                {
                    Thread.Yield();
                }
            }
            Precision = oldPrecision;
            return new BigDecimal(result);
        }

        //
        // Summary:
        //     Return the tangent of teh specified angle.
        //
        // Parameters:
        //   value:
        //     specified angle in radians.
        //
        // Returns:
        //     The result of tangent of value.
        //
        public static BigDecimal Tan(BigDecimal value)
        {
            int oldPrecision;
            BigDecimal result;
            oldPrecision = Precision;
            if (Precision < Int32.MaxValue - 1)
                Precision += 2;
            if (Precision < Int32.MaxValue)
                ++Precision;
            result = Sin(value) / Cos(value);
            Precision = oldPrecision;
            return new BigDecimal(result);
        }

        //
        // Summary:
        //     Returns hyperbolic sine of teh specified angle.
        //
        // Parameters:
        //   value:
        //     specified angle in radians.
        //
        // Returns:
        //     The result of hyperbolic sine of value.
        //
        public static BigDecimal Sinh(BigDecimal value)
        {
            int oldPrecision;
            BigDecimal result;
            oldPrecision = Precision;
            if (Precision < Int32.MaxValue - 1)
                Precision += 2;
            if (Precision < Int32.MaxValue)
                ++Precision;
            result = (Exp(value) - Exp(-value)) / 2;
            Precision = oldPrecision;
            return new BigDecimal(result);
        }

        //
        // Summary:
        //     Returns hyperbolic cosine of teh specified angle.
        //
        // Parameters:
        //   value:
        //     specified angle in radians.
        //
        // Returns:
        //     The result of hyperbolic cosine of value.
        //
        public static BigDecimal Cosh(BigDecimal value)
        {
            int oldPrecision;
            BigDecimal result;
            oldPrecision = Precision;
            if (Precision < Int32.MaxValue - 1)
                Precision += 2;
            if (Precision < Int32.MaxValue)
                ++Precision;
            result = (Exp(value) + Exp(-value)) / 2;
            Precision = oldPrecision;
            return new BigDecimal(result);
        }

        //
        // Summary:
        //     Returns hyperbolic tangent of teh specified angle.
        //
        // Parameters:
        //   value:
        //     specified angle in radians.
        //
        // Returns:
        //     The result of hyperbolic tangent of value.
        //
        public static BigDecimal Tanh(BigDecimal value)
        {
            int oldPrecision;
            BigDecimal result;
            oldPrecision = Precision;
            if (Precision < Int32.MaxValue - 1)
                Precision += 2;
            if (Precision < Int32.MaxValue)
                ++Precision;
            result = Sinh(value) / Cosh(value);
            Precision = oldPrecision;
            return new BigDecimal(result);
        }

        //
        // Summary:
        //     Returns the pi value
        public static BigDecimal PI
        {
            get
            {
                int oldPrecision;
                BigDecimal a, b, c, e, pi, maxDifenece;
                long npow;
                bool done;
                oldPrecision = Precision;
                if (Precision <= Int32.MaxValue - 2)
                    Precision += 2;
                else
                    Precision = Int32.MaxValue;
                maxDifenece = new BigDecimal(1, -Precision);
                c = Sqrt(0.125);
                a = 1 + 3 * c;
                b = Sqrt(a);
                e = b - 0.625;
                b = 2 * b;
                c = e - c;
                a = a + e;
                npow = 4;
                done = false;
                while (!done)
                {
                    npow = 2 * npow;
                    e = (a + b) / 2;
                    b = Sqrt(a * b);
                    e = e - b;
                    b = 2 * b;
                    c = c - e;
                    a = e + b;
                    if (Abs(e) <= maxDifenece)
                    {
                        done = true;
                    }
                    else
                    {
                        Thread.Yield();
                    }
                }
                e = e * e / 4;
                a = a + b;
                pi = (a * a - e - e / 2) / (a * c - e) / npow;
                Precision = oldPrecision;
                return new BigDecimal(pi);
            }
        }

        //// Summary:
        ////     Converts the numeric value of the current System.Numerics.BigDecimal object to
        ////     its equivalent string representation.
        ////
        //// Returns:
        ////     The string representation of the current System.Numerics.BigDecimal value.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ToString(CultureInfo.CurrentCulture.NumberFormat);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(IFormatProvider? provider) => ToString(_mantisa, _exponent, provider);

        private static string ToString(BigInteger mantissa, Int32 exponent, IFormatProvider? provider)
        {
            if (provider is null)
            {
                provider = CultureInfo.CurrentCulture;
            }

            var formatProvider = NumberFormatInfo.GetInstance(provider);

            var negativeValue = mantissa.Sign == -1;
            var negativeExponent = Math.Sign(exponent) == -1;

            var result = BigInteger.Abs(mantissa).ToString();
            var absExp = Math.Abs(exponent);

            if (negativeExponent)
            {
                if (absExp > result.Length)
                {
                    var zerosToAdd = Math.Abs(absExp - result.Length);
                    var zeroString = String.Concat(Enumerable.Repeat(formatProvider.NativeDigits[0], zerosToAdd));
                    result = zeroString + result;
                    result = result.Insert(0, formatProvider.NumberDecimalSeparator);
                    result = result.Insert(0, formatProvider.NativeDigits[0]);
                }
                else
                {
                    var indexOfRadixPoint = Math.Abs(absExp - result.Length);
                    result = result.Insert(indexOfRadixPoint, formatProvider.NumberDecimalSeparator);
                    if (indexOfRadixPoint == 0)
                    {
                        result = result.Insert(0, formatProvider.NativeDigits[0]);
                    }
                }

                result = result.TrimEnd('0');
                if (result.Last().ToString() == formatProvider.NumberDecimalSeparator)
                {
                    result = result.Substring(0, result.Length - 1);
                }
            }
            else if (mantissa != 0)
            {
                var zeroString = String.Concat(Enumerable.Repeat(formatProvider.NativeDigits[0], absExp));
                result += zeroString;
            }

            if (negativeValue)
            {

                // Prefix "-"
                result = result.Insert(0, formatProvider.NegativeSign);
            }

            return result;
        }

        /// <summary>Converts the string representation of a decimal to the BigDecimal equivalent.</summary>
        /// <param name="input">A string that contains a number to convert.</param>
        /// <returns></returns>
        public static BigDecimal Parse(String input)
        {
            return Parse(input, CultureInfo.CurrentCulture.NumberFormat);
        }

        /// <summary>
        /// Converts the string representation of a decimal in a specified culture-specific format to its BigDecimal equivalent.
        /// </summary>
        /// <param name="input">A string that contains a number to convert.</param>
        /// <param name="provider">An object that provides culture-specific formatting information about value.</param>
        /// <returns></returns>
        public static BigDecimal Parse(String input, IFormatProvider? provider)
        {
            if (provider is null)
            {
                provider = CultureInfo.CurrentCulture.NumberFormat;
            }

            NumberFormatInfo numberFormatProvider = NumberFormatInfo.GetInstance(provider);

            input = input.Trim();
            if (String.IsNullOrEmpty(input))
            {
                return BigInteger.Zero;
            }

            var exponent = 0;
            var isNegative = false;

            if (input.StartsWith(numberFormatProvider.NegativeSign, StringComparison.OrdinalIgnoreCase))
            {
                isNegative = true;
                input = input.Replace(numberFormatProvider.NegativeSign, String.Empty);
            }

            var posE = input.LastIndexOf('E') + 1;
            if (posE > 0)
            {
                var sE = input.Substring(posE);

                if (Int32.TryParse(sE, out exponent))
                {
                    //Trim off the exponent
                    input = input.Substring(0, posE - 1);
                }
            }

            if (input.Contains(numberFormatProvider.NumberDecimalSeparator))
            {
                var decimalPlace = input.IndexOf(numberFormatProvider.NumberDecimalSeparator, StringComparison.Ordinal);

                exponent += decimalPlace + 1 - input.Length;
                input = input.Replace(numberFormatProvider.NumberDecimalSeparator, String.Empty);
            }

            var mantissa = BigInteger.Parse(input, numberFormatProvider);
            if (isNegative)
            {
                mantissa = BigInteger.Negate(mantissa);
            }

            BigDecimal result = new BigDecimal(mantissa, exponent);
            return result;
        }

        /// <summary>
        /// Tries to convert the string representation of a number to its BigDecimal equivalent, and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="input">The string representation of a number.</param>
        /// <param name="result">When this method returns, this out parameter contains the BigDecimal equivalent
        /// to the number that is contained in value, or default(BigDecimal) if the conversion fails.
        /// The conversion fails if the value parameter is null or is not of the correct format.</param>
        /// <returns></returns>
        public static bool TryParse(String input, out BigDecimal result)
        {
            return TryParse(input, CultureInfo.CurrentCulture.NumberFormat, out result);
        }

        /// <summary>
        /// Tries to convert the string representation of a number in a specified style and culture-specific format
        /// to its BigDecimal equivalent, and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="input">The string representation of a number.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about value.</param>
        /// <param name="result">When this method returns, this out parameter contains the BigDecimal equivalent
        /// to the number that is contained in value, or default(BigDecimal) if the conversion fails.
        /// The conversion fails if the value parameter is null or is not of the correct format.</param>
        /// <returns></returns>
        public static bool TryParse(String input, IFormatProvider provider, out BigDecimal result)
        {
            try
            {
                BigDecimal output = Parse(input, provider);
                result = output;
                return true;
            }
            catch
            {
                result = default(BigDecimal);
                return false;
            }
        }
    }
}
