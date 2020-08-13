using System;

public class Program
{
    public static void Main()
    {
        string str = "hassan";
        char[] str_chr = str.ToCharArray();
        char[] palindrome = new char[str_chr.Length];
        for(int i = 0; i < palindrome.Length; i++)
        {
            palindrome[i] = str_chr[(str_chr.Length-1)-i];
        }


        string palinstr = new String(palindrome);
        Console.WriteLine(palinstr);
    }
}