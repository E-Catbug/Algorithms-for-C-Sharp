//Created by Alexander Fields https://github.com/roku674

namespace Algorithms
{
    public static class BinarySearch
    {
        /// <summary>
        /// Call to this binary search an array of ints
        /// </summary>
        /// <param name="arr">Array</param>
        /// <param name="l">left (if unkown start at 0)</param>
        /// <param name="r">right (arr.Length -1)</param>
        /// <param name="x">Number attemping to find</param>
        /// <returns></returns>
        public static int BinarySearchInt(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the
                // middle itself
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > x)
                    return BinarySearchInt(arr, l, mid - 1, x);

                // Else the element can only be present
                // in right subarray
                return BinarySearchInt(arr, mid + 1, r, x);
            }

            // We reach here when element is not present
            // in array
            return -1;
        }

        /// <summary>
        /// Call thig to binary search a string for a specific string
        /// </summary>
        /// <param name="a">string array</param>
        /// <param name="x">string to find</param>
        /// <returns></returns>
        public static int BinarySearchString(string[] a, string x)
        {
            int low = 0;
            int high = a.Length - 1;
            int mid;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (a[mid].CompareTo(x) < 0)
                {
                    low = mid + 1;
                }
                else if (a[mid].CompareTo(x) > 0)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}