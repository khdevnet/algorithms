// See https://aka.ms/new-console-template for more information

var cost = new int[] { 10, 15, 20 };
var r = MinCostClimbingStairs(cost);
Console.ReadLine();

// state it the current stair number
static int MinCostClimbingStairs(int[] cost)
{
    return MinCostClimbingStairsTD(cost, cost.Length);
}

static int MinCostClimbingStairsTD(int[] cost, int i)
{
    if (i <= 1)
    {
        return 0;
    }

    var i1 = cost[i - 1] + MinCostClimbingStairsTD(cost, i - 1);
    var i2 = cost[i - 2] + MinCostClimbingStairsTD(cost, i - 2);
    return Math.Min(i1, i2);
}
// [10,15,20, out, out]
// i+1
// 10 -> 20 -> 30(out) 
// j+2
// 15 -> 30 -> 40(out) 
// min(cost[i-1]+cost[i], cost[i-2]+cost[i] )

// Example 1:
// Input: cost = [10,15,20]
// Output: 15
// Explanation: You will start at index 1.
// - Pay 15 and climb two steps to reach the top.
// The total cost is 15.

// Example 2:
// Input: cost = [1,100,1,1,1,100,1,1,100,1]
// Output: 6
// Explanation: You will start at index 0.
// - Pay 1 and climb two steps to reach index 2.
// - Pay 1 and climb two steps to reach index 4.
// - Pay 1 and climb two steps to reach index 6.
// - Pay 1 and climb one step to reach index 7.
// - Pay 1 and climb two steps to reach index 9.
// - Pay 1 and climb one step to reach the top.
// The total cost is 6.

// 746. Min Cost Climbing Stairs

// Click here to show hint regarding state variables and dp
// Let dp(i) be the minimum cost necessary to reach step i.

// Click here to show hint regarding the recurrence relation
// We can arrive at step i from either step 
// i - 1 or step i - 2. 
// Choose whichever one is cheaper.

// Click here to show hint regarding base cases
// Since we can start from either step 0 or step 1, the cost to reach these steps is 0.

//   !   !  ?
//  [10,15,20]
// ind = if(cost[i]< cost[i+1]) ?i :i+1
// cost[ind] + dp(i+1)

//   !   !  ?
//  [10,15,20]

//  !   !   ?      
// [1, 100, 1, 1, 1, 100, 1, 1, 100, 1] stair=2
// stairs[i]
// if I not step on the stairs[i] then I steped on the previous stair with value stairs[i-1]
// If we decide to step on the stair, then we paid 
// nums[i] cost. However, this is only possible if we did step from the previous min(step-1, step-2).
//  This means the money we had when arriving at this house is the money we had from the previous step we paid it,
// which would be however much money we had 2 houses ago, 
// dp(i - 2). After robbing the current house, we will have 
// dp(i - 2) + nums[i] money.
// what is the next step?
// min(cost[i-2]+cost[i], cost[i-1]+cost[i])

//          !  !  ?  
// [1, 100, 1, 1, 1, 100, 1, 1, 100, 1] n=4
//      !   !  ?
// [1, 100, 1, 1, 1, 100, 1, 1, 100, 1] n=3
//
//   !  !  ?
// [1, 100, 1, 1, 1, 100, 1, 1, 100, 1] n=3
//
//             !  !  ?
// [1, 100, 1, 1, 1, 100, 1, 1, 100, 1] n=3
//
// var dp = min(dp(stair-1), dp(stair-2)+dp(stair))
//                               
// dp(n)= min(dp(n-1), dp(n-2))+ dp(n);
