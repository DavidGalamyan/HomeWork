using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class BechmarkClass
    {
        public float PointDistanceClass(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public float PointDistanceStruct(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public double PointDistanceStructDouble(PointStructDouble pointOne, PointStructDouble pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
        public float PointDistanceStructNotSqrt(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return ((x * x) + (y * y));
        }
        [Benchmark]
        public void DifferenceTwoPointClass()
        {
            PointClass pointClassOne = new PointClass { X = (float)10.5, Y = (float)15.53 };
            PointClass pointClassTwo = new PointClass { X = (float)1.3, Y = (float)14.14 };
            PointDistanceClass(pointClassOne, pointClassTwo);
        }
        [Benchmark]
        public void DifferenceTwoPointStruct()
        {
            PointStruct pointOne = new PointStruct { X = (float)12.4, Y = (float)41.65 };
            PointStruct pointTwo = new PointStruct { X = (float)22.13, Y = (float)13.34 };
            PointDistanceStruct(pointOne, pointTwo);
        }
        [Benchmark]
        public void DifferenceTwoPointStructDouble()
        {
            PointStructDouble pointOne = new PointStructDouble { X = (double)31.2, Y = (double)22.5 };
            PointStructDouble pointTwo = new PointStructDouble { X = (double)14.8, Y = (double)13.3 };
            PointDistanceStructDouble(pointOne, pointTwo);
        }
        [Benchmark]
        public void DifferenceTwoPointStructNotSqrt()
        {
            PointStruct pointOne = new PointStruct { X = (float)17.3, Y = (float)41.8 };
            PointStruct pointTwo = new PointStruct { X = (float)22.6, Y = (float)13.2 };
            PointDistanceStructNotSqrt(pointOne, pointTwo);
        }
    }
}

public class PointClass
{
    public float X;
    public float Y;
}

public struct PointStruct
{
    public float X;
    public float Y;
}
public struct PointStructDouble
{
    public double X;
    public double Y;
}
