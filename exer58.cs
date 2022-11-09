void MultiplyMatrix (int[,] firstArray, int[,] secondArray)
{
   for (int i = 0; i < firstArray.GetLength(0); i++)
     {
        for (int j = 0; j < secondArray.GetLength(1); j++)
	{
	  int sum = 0;
	  sum += firstArray[i,j] * secondArray[i,j];
	  Console.WriteLine($"\nMultyply of the arrays is: {sum}"); 
	}
     }
}
	
			
int[,] arrayOne = new int [,] {{1,4,7,2},{5,9,2,3}};
int[,] arrayTwo = new int [,] {{8,4,2,4},{5,2,6,7}};
MultiplyMatrix(arrayOne, arrayTwo);
