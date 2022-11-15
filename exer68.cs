int AkkermanFunc(int a, int b)
{
  if(a == 0){
	return b + 1;
    }
    if(a > 0 && b == 0){
    	return AkkermanFunc(a - 1, 1);
    }
    return AkkermanFunc(a - 1, AkkermanFunc(a, b - 1));
}
		
Console.WriteLine(AkkermanFunc(3,2));
Console.WriteLine(AkkermanFunc(2,3));
