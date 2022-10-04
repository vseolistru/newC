void someFunc(int args)
{
  string some = args.ToString(); 
  Console.WriteLine(some[1]);
}
	
int a = 456;
someFunc (a);
int b = 782;
someFunc (b);
int c = 918;
someFunc (c);
