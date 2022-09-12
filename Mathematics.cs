//Created by Alexander Fields https://github.com/roku674

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Algorithms
{
    public static class Mathematics
    {
        public static List<Point> SortByDistancePoint(List<Point> lst)
        {
            List<Point> output = new List<Point>();
            output.Add(lst[NearestPoint(new Point(0, 0), lst)]);
            lst.Remove(output[0]);
            int x = 0;
            for (int i = 0; i < lst.Count + x; i++)
            {
                output.Add(lst[NearestPoint(output[output.Count - 1], lst)]);
                lst.Remove(output[output.Count - 1]);
                x++;
            }
            return output;
        }

        private static int NearestPoint(Point srcPt, List<Point> lookIn)
        {
            KeyValuePair<double, int> smallestDistance = new KeyValuePair<double, int>();
            for (int i = 0; i < lookIn.Count; i++)
            {
                double distance = Math.Sqrt(Math.Pow(srcPt.X - lookIn[i].X, 2) + Math.Pow(srcPt.Y - lookIn[i].Y, 2));
                if (i == 0)
                {
                    smallestDistance = new KeyValuePair<double, int>(distance, i);
                }
                else
                {
                    if (distance < smallestDistance.Key)
                    {
                        smallestDistance = new KeyValuePair<double, int>(distance, i);
                    }
                }
            }
            return smallestDistance.Value;
        }

        public static List<Vector2> SortByDistanceVector2(List<Vector2> lst)
        {
            List<Vector2> output = new List<Vector2>();
            output.Add(lst[NearestVector(new Vector2(0, 0), lst)]);
            lst.Remove(output[0]);
            int x = 0;
            for (int i = 0; i < lst.Count + x; i++)
            {
                output.Add(lst[NearestVector(output[output.Count - 1], lst)]);
                lst.Remove(output[output.Count - 1]);
                x++;
            }
            return output;
        }

        private static int NearestVector(Vector2 srcVec, List<Vector2> lookIn)
        {
            KeyValuePair<double, int> smallestDistance = new KeyValuePair<double, int>();
            for (int i = 0; i < lookIn.Count; i++)
            {
                double distance = Math.Sqrt(Math.Pow(srcVec.X - lookIn[i].X, 2) + Math.Pow(srcVec.Y - lookIn[i].Y, 2));
                if (i == 0)
                {
                    smallestDistance = new KeyValuePair<double, int>(distance, i);
                }
                else
                {
                    if (distance < smallestDistance.Key)
                    {
                        smallestDistance = new KeyValuePair<double, int>(distance, i);
                    }
                }
            }
            return smallestDistance.Value;
        }
    }
}