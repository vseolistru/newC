void polydrom (int args)
{			
  string decoded = args.ToString();
  char[] flag = decoded.ToCharArray();
  Array.Reverse(flag);
  flag.ToString();
  
  int compare = int.Parse(flag);
  if (args == compare) {Console.WriteLine("true");}
  else {Console.WriteLine("no");}			
}			
		
int [] someArr = {14212, 12821, 23432};
foreach (int i in someArr )
  {
    polydrom(i);
  }
