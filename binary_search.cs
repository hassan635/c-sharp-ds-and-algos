using System;

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 34, 65, 80, 100 };

        int numToSearch = 100;

        int min = 0;
        int max = arr.Length;
        int mid = arr.Length / 2;

        while (min <= max)
        {
            if (arr[mid] == numToSearch)
            {
                Console.WriteLine("Num found: " + arr[mid]);
                break;
            }
            else if (arr[mid] > numToSearch)
            {
                max = mid;
                mid = mid / 2;
            }
            else
            {
                min = mid;
                mid = (min + max) / 2;
            }
        }
    }
}