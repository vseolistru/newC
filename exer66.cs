void CalculateSumm(int n, int m)
{
  int start = n;
  int end = m;
  
  while (n>=end){
    int result = (end + start)*(start - end + 1)/2; // по формуле суммы членов арифметической прогрессии			
    Console.WriteLine($"{result}");
    CalculateSumm(n-1, m);
    break;	
  }
}
		
CalculateSumm(15,1);
Console.WriteLine("Next Line");
CalculateSumm(8,4);
