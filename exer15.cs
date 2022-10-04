void someDays (int args)
{			
  switch (args)
  {
    case 1: if(args == 1) Console.WriteLine("false");        
    break;					
    case 2: if(args == 2) Console.WriteLine("false");
    break;     
    case 3: if(args == 3) Console.WriteLine("false");
    break;					
    case 4: if(args == 4) Console.WriteLine("false");
    break;					
    case 5: if(args == 5) Console.WriteLine("false");		
    break;					
    case 6: if(args == 6) Console.WriteLine("Sat - true");		
    break;
    case 7: if(args == 7) Console.WriteLine("Sun - true");		
    break;					
    default: if(args <=0 || args >7) Console.WriteLine("out of dayweek");
    break;		
  }
}		
		
for (int a = 1; a<8; a++)
{
  someDays(a);
}
