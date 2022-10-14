int[] nums = {3,7,22,2,78};
int min = nums[0], minIndex = 0;
int max = nums[0], maxIndex =0;
int num = nums.Length;
for (int i = 0; i < num; i++){
	if (min > nums[i]){
		min = nums[i];
		minIndex = i;			  
	}
	if (max < nums[i]){
		max = nums[i];
		maxIndex = i;			  
        }
}
int dif = max-min; 
Console.WriteLine(dif); 
