//121.Best Time to Buy and Sell Stock
//int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
//int earned = 0;

//for (int i = 0; i < prices.Length; i++)
//{
//    // 錯在時間複雜度過高
//    if (prices[i] < prices[i + 1])
//    {
//        for (int j = i + 1; j < prices.Length; j++)
//        {
//            if (earned < prices[j] - prices[i])
//            {
//                earned = prices[j] - prices[i];
//            }
//        }
//    }
//}
//return earned;
int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
int earned = 0;
int iBuy = 0; // index when buying
for (int i = 0; i < prices.Length; i++)
{
    if (prices[iBuy] > prices[i]) // 如果購買的 idx 值較後續的值大，改購買該idx的值 (簡單說買越小越好)
        iBuy = i;
    earned = Math.Max(earned, prices[i] - prices[iBuy]); // 紀錄最大利潤(比較當下的利潤和新紀錄的利潤誰高取誰)
}
return earned;