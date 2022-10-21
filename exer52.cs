int[,] mas = new int[,] {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
for (int i = 0; i < 4; i++) 
{
   int avgSumm = 0;
   for (int t = 0; t < 3; t++)
   {
       avgSumm += mas[t, i];                    
   }
   Console.WriteLine($"Avarange Colums -{(float)avgSumm/3}");                 
}	
