void FindValue (int args)
{
    int[,] nums = new int[,] {{1,4,7,2},{5,9,2,3},{8,4,2,4}}; 			
    int rows = nums.GetUpperBound(0) + 1;   
    int columns = nums.Length / rows;  
            
    for (int i = 0; i < rows; i++) 
      {            
        for (int t = 0; t < columns; t++)
          {					 
            if (args == nums[i,t])
	      {
	        Console.WriteLine($" value - {nums[i,t]}");
		Console.WriteLine($" positions at:  {i},{t}");
	      }
	    else 
	      {
		 Console.WriteLine($" value is not in array");
	      }	
          }
          Console.WriteLine($"Next Colums");                 
     }		
}
int a = 4;
FindValue(a);
int b = 12;
FindValue(b);
