using System;
using System.Text;
using System.Collections.Generic;


class Solution
{
    static void Main(string[] args)
    {
        string sample = "hassan";
        char[] sample_chr = sample.ToCharArray();
        List<char> unique_chr = new List<char>();
        List<char> dup_chr = new List<char>();

        foreach (char letter in sample_chr)
        {
            if (unique_chr.Contains(letter))
            {
                unique_chr.Remove(letter);
                dup_chr.Add(letter);
            }
            else
            {
                unique_chr.Add(letter);
            }
        }

        foreach (char dup_letter in dup_chr)
        {
            Console.WriteLine(dup_letter);
        }
    }
}