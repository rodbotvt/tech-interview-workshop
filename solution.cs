public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double largestAverage = float.MinValue;
        for(int i = 0; i <= nums.Length - k; i++) {
            double currentAverage = 0;
            for(int j = i; j < i + k; j++) {
                currentAverage += nums[j];
            }
            currentAverage /= k;
            Console.WriteLine(currentAverage);
            largestAverage = Math.Max(largestAverage, currentAverage);
        }

        return largestAverage;
    }
}
