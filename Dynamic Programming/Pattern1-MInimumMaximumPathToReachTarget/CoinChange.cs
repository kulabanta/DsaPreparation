public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] res = new int[amount+1];
        Array.Fill(res,Int32.MaxValue);
        res[0]=0;
        for(int amt=1;amt<=amount;amt++)
        {
            foreach(int coin in coins)
            {
                if(amt-coin >=0 && res[amt-coin]!=Int32.MaxValue)
                    res[amt]=Math.Min(res[amt],res[amt-coin]+1);
            }
        }
        return res[amount]==Int32.MaxValue?-1:res[amount];
    }
}