using System;

public static class IsbnVerifier
{
    private static char[] cleanString(this string number)
    {
        return number.Trim().Replace("-", "").ToCharArray();
    }

    public static bool IsValid(string number)
    {
        var charArray = number.cleanString();
        if (charArray.Length != 10)
            return false;

        int accumulator = 0;
        for (int i = 10; i > 0; i--)
        {
            int isbnIterator;
            try
            {
                if (i == 1 && charArray[10 - i] == 'X')
                    isbnIterator = 10;
                else

                    isbnIterator = int.Parse(charArray[10 - i].ToString());
            }
            catch (Exception)
            {
                return false;
            }

            accumulator += isbnIterator * i;
        }

        return accumulator % 11 == 0;
    }
}