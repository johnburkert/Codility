
class Solution
{
    public int solution(int[] A)
    {
        var total = 0;
        var prev = 0;
        
        foreach (var i in A)
        {
            var curr = i * 17 + prev;
            total += curr % 10;
            prev = curr / 10;
        }

        while (prev > 0)
        {
            total += prev % 10;
            prev /= 10;
        }

        return total;
    }
}
