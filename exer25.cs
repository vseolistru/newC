void powInts (int args, int kwargs)
  {
    int a = args;
    int b = kwargs;
    int s = 1; 
    for (int i = 1; i<=b; i++){
      s = s * a;
      if(i == b){	
        Console.WriteLine(s);	
      }
    }
  }
 
powInts(3,5);
powInts(2,4);
