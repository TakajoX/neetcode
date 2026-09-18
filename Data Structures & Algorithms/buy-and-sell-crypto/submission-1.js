class Solution {
    /**
     * @param {number[]} prices
     * @return {number}
     */
    maxProfit(prices) {
        let profit = 0;
        let todayPrice = 0;
        let minimumPast = prices[0];

        for(let i = 0; i < prices.length; i++ ) {
            let actualProfit = 0;
            minimumPast = Math.min(minimumPast, prices[i]);
            todayPrice = prices[i];

            actualProfit = todayPrice - minimumPast;

            profit = Math.max(profit, actualProfit);

        }

        return profit;
    }
}
