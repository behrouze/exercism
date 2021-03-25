
namespace Exercism.leap
{
    public static class Leap
    {
        private static bool IsMultipleOf(this int toBeDetermined, int multiple){
            return toBeDetermined % multiple == 0;
        }
        public static bool IsLeapYear(int p)
        {
            return (p.IsMultipleOf(4) && !p.IsMultipleOf(100) || p.IsMultipleOf(400));
        } 
    }
}