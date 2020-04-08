using Microsoft.VisualStudio.TestTools.UnitTesting;
using P_Math;
using System;

namespace P_Math_Tests
{
    [TestClass]
    public class Math_Tests
    {
        [TestMethod]
        public void AddTest()
        {
            //check add(int a, int b)
            Assert.AreEqual(10, OwnMath.add(5, 5));
            Assert.AreEqual(-10, OwnMath.add(-5, -5));
            Assert.AreEqual(10, OwnMath.add(0, 10));
            Assert.AreEqual(-10, OwnMath.add(0, -10));

            //check add(double a, int b)
            Assert.AreEqual(10.5, OwnMath.add(5.5, 5));
            Assert.AreEqual(-10.5, OwnMath.add(-5.5, -5));
            Assert.AreEqual(10.5, OwnMath.add(10.5, 0));
            Assert.AreEqual(-10.5, OwnMath.add(-10.5, 0));

            //check add(double a, double b)
            Assert.AreEqual(11, OwnMath.add(5.5, 5.5));
            Assert.AreEqual(-11, OwnMath.add(-5.5, -5.5));


        }

        [TestMethod]
        public void SubTest()
        {
            //check sub(int a, int b)
            Assert.AreEqual(10, OwnMath.sub(15, 5));
            Assert.AreEqual(-10, OwnMath.sub(-15, -5));
            Assert.AreEqual(10, OwnMath.sub(10, 0));
            Assert.AreEqual(-10, OwnMath.sub(0, 10));

            //check sub(double a, int b)
            Assert.AreEqual(10.5, OwnMath.sub(15.5, 5));
            Assert.AreEqual(-10.5, OwnMath.sub(-15.5, -5));
            Assert.AreEqual(10.5, OwnMath.sub(10.5, 0));
            Assert.AreEqual(-10.5, OwnMath.sub(-10.5, 0));

            //check sub(double a, double b)
            Assert.AreEqual(10, OwnMath.sub(15.5, 5.5));
            Assert.AreEqual(-10, OwnMath.sub(-15.5, -5.5));
        }

        [TestMethod]
        public void MulTest()
        {
            //check mul(int a, int b)
            Assert.AreEqual(10, OwnMath.mul(5, 2));
            Assert.AreEqual(-10, OwnMath.mul(-5, 2));
            Assert.AreEqual(0, OwnMath.mul(10, 0));

            //check mul(double a, int b)
            Assert.AreEqual(11, OwnMath.mul(5.5, 2));
            Assert.AreEqual(-11, OwnMath.mul(-5.5, 2));
            Assert.AreEqual(0, OwnMath.mul(10.5, 0));

            //check mul(double a, double b)
            Assert.AreEqual(30.25, OwnMath.mul(5.5, 5.5));
            Assert.AreEqual(-30.25, OwnMath.mul(-5.5, 5.5));
        }

        [TestMethod]
        public void DivTest()
        {
            //check div(int a, int b)
            Assert.AreEqual(5, OwnMath.div(10, 2));
            Assert.AreEqual(-5, OwnMath.div(-10, 2));
            Assert.AreEqual(0, OwnMath.div(0, 2));
            Assert.AreEqual(double.PositiveInfinity, OwnMath.div(2, 0));

            //check div(double a, int b)
            Assert.AreEqual(5.25, OwnMath.div(10.5, 2));
            Assert.AreEqual(-5.25, OwnMath.div(-10.5, 2));
            Assert.AreEqual(0, OwnMath.div(0.0, 2));
            Assert.AreEqual(double.PositiveInfinity, OwnMath.div(10.5, 0));

            //check div(int a, double b)
            Assert.AreEqual(4, OwnMath.div(10, 2.5));
            Assert.AreEqual(-4, OwnMath.div(-10, 2.5));
            Assert.AreEqual(0, OwnMath.div(0, 2.5));
            Assert.AreEqual(double.PositiveInfinity, OwnMath.div(10, 0));

            //check mul(double a, double b)
            Assert.AreEqual(4.2, OwnMath.div(10.5, 2.5));
            Assert.AreEqual(-4.2, OwnMath.div(-10.5, 2.5));

            //check divInt(int a, int b)
            Assert.AreEqual(5, OwnMath.divInt(10, 2));
            Assert.AreEqual(-5, OwnMath.divInt(-10, 2));
            Assert.AreEqual(0, OwnMath.divInt(0, 2));
            Assert.ThrowsException<DivideByZeroException>(() => (OwnMath.divInt(2, 0)));
        }

        [TestMethod]
        public void AbsTest()
        {
            //check Abs(int a)
            Assert.AreEqual(10, OwnMath.Abs(10));
            Assert.AreEqual(10, OwnMath.Abs(-10));
            Assert.AreEqual(0, OwnMath.Abs(0));

            //check Abs(double a)
            Assert.AreEqual(10.5, OwnMath.Abs(10.5));
            Assert.AreEqual(10.5, OwnMath.Abs(-10.5));
        }

        [TestMethod]
        public void FactorialTest()
        {
            //check Factorial(int a)
            Assert.AreEqual(6, OwnMath.Factorial(3));
            Assert.AreEqual(1, OwnMath.Factorial(0));
            Assert.ThrowsException<InvalidOperationException>(() => OwnMath.Factorial(-2));
        }

        [TestMethod]
        public void MemAddTest()
        {
            //check memAdd(int a)
            OwnMath.memDel();
            OwnMath.memAdd(10);
            Assert.AreEqual(10, OwnMath.memLoad());
            OwnMath.memAdd(5);
            Assert.AreEqual(15, OwnMath.memLoad());

            //check memAdd(double a)
            OwnMath.memDel();
            OwnMath.memAdd(10.5);
            Assert.AreEqual(10.5, OwnMath.memLoad());
            OwnMath.memAdd(5.5);
            Assert.AreEqual(16, OwnMath.memLoad());

            OwnMath.memDel();
        }

        [TestMethod]
        public void MemSubTest()
        {
            OwnMath.memDel();

            //check memSub(int a)
            OwnMath.memSub(10);
            Assert.AreEqual(-10, OwnMath.memLoad());
            OwnMath.memAdd(-5);
            Assert.AreEqual(-15, OwnMath.memLoad());

            //check memSub(double a)
            OwnMath.memDel();
            OwnMath.memSub(10.5);
            Assert.AreEqual(-10.5, OwnMath.memLoad());
            OwnMath.memSub(5.5);
            Assert.AreEqual(-16, OwnMath.memLoad());

            OwnMath.memDel();
        }

        [TestMethod]
        public void MemDelTest()
        {
            OwnMath.memDel();

            //check memDel()
            OwnMath.memAdd(25);
            OwnMath.memDel();
            Assert.AreEqual(0, OwnMath.memLoad());

            OwnMath.memAdd(-25);
            OwnMath.memDel();
            Assert.AreEqual(0, OwnMath.memLoad());

            OwnMath.memDel();
        }

        [TestMethod]
        public void MemLoadTest()
        {
            OwnMath.memDel();

            //check memLoad()
            OwnMath.memAdd(25);
            Assert.AreEqual(25, OwnMath.memLoad());

            OwnMath.memAdd(-25);
            Assert.AreEqual(0, OwnMath.memLoad());

            OwnMath.memAdd(5.5);
            Assert.AreEqual(5.5, OwnMath.memLoad());

            OwnMath.memDel();
        }

        [TestMethod]
        public void MemLoadIntTest()
        {
            OwnMath.memDel();

            //check memLoadInt()
            OwnMath.memAdd(25.4);
            Assert.AreEqual(25, OwnMath.memLoadInt());

            OwnMath.memAdd(0.5);
            Assert.AreEqual(26, OwnMath.memLoadInt());

            OwnMath.memDel();
        }

        [TestMethod]
        public void FloorTest()
        {
            //check Floor(double a)
            Assert.AreEqual(5, OwnMath.floor(5.3));
            Assert.AreEqual(-5, OwnMath.floor(-4.4));
            Assert.AreEqual(0, OwnMath.floor(0.25));
            Assert.IsInstanceOfType(OwnMath.floor(0.25), typeof(double));

            //check FloorInt(double a)
            Assert.AreEqual(5, OwnMath.floorInt(5.3));
            Assert.AreEqual(-5, OwnMath.floorInt(-4.4));
            Assert.AreEqual(0, OwnMath.floorInt(0.25));
            Assert.IsInstanceOfType(OwnMath.floorInt(0.25), typeof(int));
        }

        [TestMethod]
        public void CeilTest()
        {
            //check Ceil(double a)
            Assert.AreEqual(6, OwnMath.ceil(5.3));
            Assert.AreEqual(-4, OwnMath.ceil(-4.4));
            Assert.AreEqual(1, OwnMath.ceil(0.25));

            //check CeilInt(double a)
            Assert.AreEqual(6, OwnMath.ceilInt(5.3));
            Assert.AreEqual(-4, OwnMath.ceilInt(-4.4));
            Assert.AreEqual(1, OwnMath.ceilInt(0.25));
        }

        [TestMethod]
        public void RoundTest()
        {
            //check Round(double a, int decimalPlace)
            Assert.AreEqual(6.4, OwnMath.round(6.42, 1));
            Assert.AreEqual(6.5, OwnMath.round(6.46, 1));
            Assert.AreEqual(-1.5, OwnMath.round(-1.53, 1));
            Assert.AreEqual(-1.6, OwnMath.round(-1.58, 1));

            //check Round(double a)
            Assert.AreEqual(6, OwnMath.round(6.4));
            Assert.AreEqual(7, OwnMath.round(6.6));
        }

        [TestMethod]
        public void PowTest()
        {
            //check Pow(int a, int power)
            Assert.AreEqual(9, OwnMath.pow(3, 2));
            Assert.AreEqual(9, OwnMath.pow(-3, 2));
            Assert.AreEqual(27, OwnMath.pow(3, 3));
            Assert.AreEqual(0, OwnMath.pow(0, 2));

            //check Pow(double a, double power)
            Assert.AreEqual(10.889999999999999, OwnMath.pow(3.3, 2));
            Assert.AreEqual(10.889999999999999, OwnMath.pow(-3.3, 2));
            Assert.AreEqual(0.0, OwnMath.pow(0.0, 2));
        }

        [TestMethod]
        public void SqrtTest()
        {
            //check Sqrt(int a)
            Assert.AreEqual(3, Math.Sqrt(9));
            Assert.AreEqual(0, Math.Sqrt(0));
            Assert.ThrowsException<InvalidOperationException>(() => Math.Sqrt(-9));
        }

        [TestMethod]
        public void RootTest()
        {
            //check Root()
            Assert.AreEqual(0, OwnMath.root());
        }
    }
}
