public class Solution
{
    public bool CanJump(params int[] nums)
    {
        if (nums.Length == 1) return true;
        if (nums[0] >= nums.Length - 1) return true;
        {
            int index = 0;
            int value = nums[index];

            int tempIndex = 0;
            int tempValue = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (value + index >= nums.Length - 1) return true;
                for (int i = index + 1; i < index + value + 1; i++)
                {
                    if (i + nums[i]>value + index)
                    {
                        tempIndex = i; 
                       tempValue= nums[i];
                        break;
                    }

                    if (value == 1) continue;
                }
                value = tempValue;
                index = tempIndex;
            }
        }
        return false;
    }

static void Main()
{ 
Solution s = new Solution();
Console.WriteLine(s.CanJump(3, 0, 8, 2, 0, 0, 1));         
}


}