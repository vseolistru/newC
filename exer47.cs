double[,] a = new double[4, 3];
 
Random random = new Random();
for (int i = 0; i < 4; i++)
  {
      for (int j = 0; j < 3; j++)
          {
	       Random rnd = new Random();   
               a[i, j] = Math.Round( rnd.NextDouble() * 10,1);
               Console.Write("{0,4}", a[i, j]);
          }
      Console.WriteLine();
  }
