//*****************************************************************************
//** 1760. Minimum Limit of Balls in a Bag    leetcode                       **
//*****************************************************************************

int minimumSize(int* nums, int numsSize, int maxOperations)
{
    int left = 1, right = nums[0];
    for (int i = 1; i < numsSize; i++)
    {
        if (nums[i] > right)
        {
            right = nums[i];
        }
    }

    while (left < right)
    {
        int mid = (left + right) / 2;
        long long cnt = 0;

        for (int i = 0; i < numsSize; i++)
        {
            cnt += (nums[i] - 1) / mid;
            if (cnt > maxOperations)
            {
                left = mid + 1;
                goto NEXT_ITERATION;
            }
        }

        right = mid;

    NEXT_ITERATION:
        continue;
    }
    return left;
}