/*Вернуть количество  гласных в заданной строке.
 * Мы будем рассматривать a, e, i, o, u как гласные  (но не y).
 * Входная строка будет состоять только из строчных букв и/или пробелов.
 */


public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        foreach (char vowel in str)
        {
            if (vowels.Contains(vowel))
            {
                vowelCount++;
            }
        }
        return vowelCount;
    }
}
