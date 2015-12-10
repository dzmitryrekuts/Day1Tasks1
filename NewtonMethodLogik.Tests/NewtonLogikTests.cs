using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonMethodLogik.Tests
{

    [TestFixture]

    public class NewtonLogikTests

    {
        public static IEnumerable TestCases
        {
            get
            {
                //positive tests
                yield return new TestCaseData(16.0, 2, 1e-15).Returns(true);
                yield return new TestCaseData(8.0, 3, 0.1).Returns(true);
                yield return new TestCaseData(Double.MaxValue, 52, 0.1).Returns(true);
                yield return new TestCaseData(Double.MinValue, Int32.MinValue, Double.MinValue).Returns(true);
                yield return new TestCaseData(Double.MaxValue, Int32.MaxValue, Double.MinValue).Returns(true);
                yield return new TestCaseData(1000, Int32.MaxValue, Double.MinValue).Returns(true);
                yield return new TestCaseData(1000, 10, Double.MinValue).Returns(true);

                //negative tests
                yield return new TestCaseData(-16.0, 2, 1e-15).Throws(typeof(System.ArgumentException));
                yield return new TestCaseData(-16.0, 2, 1e-15).Throws(typeof(ArgumentException));
                yield return new TestCaseData(8.0, 3, 0.0).Throws(typeof(ArgumentException));
                yield return new TestCaseData(0, 0, 0).Throws(typeof(ArgumentException));
                yield return new TestCaseData(52, 6, -1e-15).Throws(typeof(ArgumentException));

            }
        }




        [TestCase(16.0, 2, 1e-15, Result = 4.0)]
        [TestCase(-8.0, 3, 1e-15, Result = -2.0)]
        [TestCase(-27.0, 3, 1e-15, Result = -3.0)]
        public double NewtonMetode_PositiveTests(double number, int power, double prec)
        {
            return RootFinding.NewtonMetode(number, power, prec);
        }


        [Test, TestCaseSource(typeof(NewtonLogikTests), "TestCases")]
        public bool NewtonMetode_PositiveTests_TestPrecision(double number, int power, double prec)
        {
            return (Math.Abs(Math.Pow(number, 1.0 / power) - RootFinding.NewtonMetode(number, power, prec)) < prec);
        }


    }

}

