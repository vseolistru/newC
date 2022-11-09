int [,] ConvertArray(int[,] array)
{
		
  int[,]someArray = array;
  for (int i = 0; i < someArray.GetLength(0); i++)
    {
       for (int j = 0; j < someArray.GetLength(1); j++)
         {					
	    for (int k = 0; k < someArray.GetLength(1)-1 ; k++)
	      {	
		                						
		  if (someArray[i, k+1] > someArray[i, k])
		    {					
		       int temp = someArray[i, k + 1];
		       someArray[i, k + 1] = someArray[i, k];
		       someArray[i, k] = temp;
		    }
	      }
	      Console.Write($"{someArray[i, j]}");
	 }
	 Console.WriteLine();
    }				
    return someArray;
}
				
		  

   int[,] array = new int [,] {{1,7,4,2},{5,9,2,3},{8,4,2,4}};
   int row = array.GetUpperBound(0) + 1;   
   int col = array.Length / row;  
     for (int i = 0; i < row; i++)
    {
       for (int j = 0; j < col; j++)
       {
	  Console.Write($"{array[i, j]}");
       }
       Console.WriteLine();
    }
ConvertArray(array);				
			

