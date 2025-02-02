function twoSum(nums: number[], target: number): number[] {
    
    for(let i=0;i<nums.length;i++)
    {
        const numToFind:number=target-nums[i];
        
        for(let j=i+1;j<=nums.length;j++)
        {
            if(numToFind===nums[j])
            {
                return [i,j];
            }
        }
    }
};