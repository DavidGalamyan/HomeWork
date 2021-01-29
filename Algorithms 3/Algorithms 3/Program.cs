using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text.RegularExpressions;

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
            return ((x * x) + (y * y));
        }
        public float PointDistanceStruct(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return ((x * x) + (y * y));
        }
        public double PointDistanceStructDouble(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return ((x * x) + (y * y));
        }
        [Benchmark]
        public void DifferenceTwoPointClass()
        {
            PointClass pointClassOne = new PointClass { X = 10, Y = 15 };
            PointClass pointClassTwo = new PointClass { X = 1, Y = 14 };
            PointDistanceClass(pointClassOne, pointClassTwo);
        }
        [Benchmark]
        public void DifferenceTwoPointStruct()
        {
            PointStruct pointOne = new PointStruct { X = 12, Y = 41 };
            PointStruct pointTwo = new PointStruct { X = 22, Y = 13 };
            PointDistanceStruct(pointOne, pointTwo);
        }
        [Benchmark]
        public void DifferenceTwoPointStructDouble()
        {
            PointStruct pointOne = new PointStruct { X = 31, Y = 22 };
            PointStruct pointTwo = new PointStruct { X = 14, Y = 13 };
            PointDistanceStructDouble(pointOne, pointTwo);
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





