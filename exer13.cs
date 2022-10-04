void someFunc(int args)
{
  string some = args.ToString(); 
  if(some.Length >= 3){
  Console.WriteLine(some[2]);}
  else {Console.WriteLine("elem is not exist");}
}
	
int a = 645;
someFunc (a);
int b = 78;
someFunc (b);
int c = 32679;
someFunc (c);
