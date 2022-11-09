void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}		
		
int n = 4;
int[,] sqArray = new int[n,n];

int flag = 1;
int i = 0;
int j = 0;


do{
  sqArray[i, j] = flag;
  flag++;
  if (i <= j + 1 && i + j < sqArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqArray.GetLength(1) - 1)
    j--;
  else
    i--;
}
while (flag <= sqArray.GetLength(0) * sqArray.GetLength(1));
	


PrintArray(sqArray);
