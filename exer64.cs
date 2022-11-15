void PrintInterval(int m)
{
			
  int start = m;
  while (m>0){			
    Console.Write($"{start} ");	
    PrintInterval(m-1);
    break;
  }

}
			
PrintInterval(5);
Console.WriteLine("New LIne");
PrintInterval(8);

