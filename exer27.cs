void sumInts (int args)
 {
    string decoded = args.ToString();
    char[] flag = decoded.ToCharArray();
    int sum = 0;
    for (int i = 0; i< flag.Length; i++){				
      int a = flag[i]- '0';
      sum = sum + a;  
      if ( i==flag.Length-1){
        Console.WriteLine(sum);
      }	
    }
  } 
		
int[] someArr = {452, 82, 9012}; 
foreach(int i in someArr){
  sumInts(i);
}
