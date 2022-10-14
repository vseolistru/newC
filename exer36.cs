var crude = new List<int>();
for(int i = 0; i<4; i++){ 
	Random rnd = new Random(); 
        int value = rnd.Next(-10, 100);
        crude.Add(value); 
        Console.WriteLine($"{value}");
        }
var evenList = new List<int>();
	foreach (int i in crude){
        	if (i % 2 == 1){
        		evenList.Add(i);
               	Console.WriteLine($"{i}");    
               }
       }
int sum = evenList.ToArray().Sum();
Console.WriteLine("List - Sum");
Console.WriteLine($"{sum}");
