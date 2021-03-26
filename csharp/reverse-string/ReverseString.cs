using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var sb = new StringBuilder("");
        for (int i = input.Length; i > 0; i--)
        {
            sb.Append(input[i - 1]);
        }

        return sb.ToString();
    }
}