
namespace Exercism.leap
{
    public static class Leap
    {
        public static bool IsLeap(int p)
        {
            return (p % 4 == 0 && (!(p % 100 == 0) || p % 400 == 0));
        } 
    }
}