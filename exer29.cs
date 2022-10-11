void arraySplit (string args){
			
    string nums = args;
    string [] subArray = (nums.Split(','));		
    foreach (var i in subArray){
	        Console.WriteLine($"{i}");		
	    }
    }

string nums = "1,2,5,7,19";	
arraySplit(nums);
string nums1 = "6,1,33";	
arraySplit(nums1);
