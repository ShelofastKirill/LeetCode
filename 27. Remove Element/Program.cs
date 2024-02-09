public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        int l = 0;
        for (int r = 0; r < nums.Length; r++)
        {
            if (nums[l] == val)
            {
                if (nums[r] != val)
                { 
                    nums[l] = nums[r];
                    nums[r] = val;
                    l++;
                    k++;
                }
            }
         else
        {
            l++;
            k++;
        }
        }
        return k;
    }
}
