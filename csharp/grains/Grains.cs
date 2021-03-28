using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
            throw new ArgumentOutOfRangeException();

        ulong result = 1;
        for (int i = 1; i < n; i++)
        {
            result *= 2;
        }

        return result;
    }

    public static ulong Total()
    {
        int chessboardSquares = 64;
        ulong result = 0;

        while (chessboardSquares > 0)
        {
            result += Square(chessboardSquares);
            chessboardSquares--;
        }
        return result;
    }
}