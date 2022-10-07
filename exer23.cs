void cubeFunc (int args)
{	
  if (args >=1)
{	
  List<int> crude = new List<int>(); 	   
  int item = args*args*args;	
  crude.Add(item);
  cubeFunc(args-1);
  Console.WriteLine(crude[0]);    
} 		
                
int [] someArr = {3,5};
foreach (int i in someArr )
{
   cubeFunc(i);
}
