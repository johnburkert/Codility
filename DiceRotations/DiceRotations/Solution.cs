using System.Linq;

class Solution
{
    private static int Moves(int a, int b)
    {
        // if equal then zero, if sum 7 then 2 else 1
        return (a == b) ? 0 : (a + b == 7) ? 2 : 1;
    }
    
    public int solution(int[] A)
    {
        return Enumerable.Range(1, 6).Select(x => A.Select(y => Moves(x, y)).Sum()).Min();
    }
}