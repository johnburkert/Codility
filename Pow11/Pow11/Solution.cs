using System.Linq;
using System.Numerics;

class Solution
{
    private static BigInteger Pow(int i, int n)
    {
        if (n == 0)
            return 1;
        var result = new BigInteger(i);
        while (--n > 0)
            result *= i;
        return result;
    }

    public int solution(int N)
    {
        return Pow(11, N).ToString().Count(x => x == '1');
    }
}