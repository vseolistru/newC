int SumElems(int[,] array, int i)
{
  int sumStr = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
     sumStr = sumStr + array[i,j];
  }
  return sumStr;
}
			
int minSumStr = 0;		
int[,] array = new int [,] {{1,4,7,2},{5,9,2,3},{8,4,2,4},{5,2,6,7}};
int sumStr = SumElems(array, 0);
  for (int i = 1; i < array.GetLength(0); i++)
  {
    int temp = SumElems(array, i);
    if (sumStr > temp)
    {
	sumStr = temp;
	minSumStr = i;
    }
}

Console.WriteLine($"{minSumStr+1}st - row with lower sum is - {sumStr} elems ")
