using System;

public class Frequency
{
    public static void Main()
    {
        String str = "Hello world";
        int[] freq = new int[str.Length];
        int i, j;
        char[] ch = str.ToCharArray();

        for (i = 0; i < str.Length; i++)
        {
            freq[i] = 1;
            for (j = i + 1; j < str.Length; j++)
            {
                if (ch[i] == ch[j])
                {
                    freq[i]++;
                    ch[j] = '0';
                }
            }
        }
        for (i = 0; i < freq.Length; i++)
        {
            if (ch[i] != ' ' && ch[i] != '0')
                Console.WriteLine(ch[i] + "-" + freq[i]);
        }
        
    }
}