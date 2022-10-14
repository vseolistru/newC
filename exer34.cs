var crude = new List<int>();
for(int i = 0; i<4; i++){ 
    Random rnd = new Random(); 
    int value = rnd.Next(100, 990);
    crude.Add(value); 
    Console.WriteLine($"{value}");
    }

var evenList = new List<int>();
foreach (int i in crude){
    if (i % 2 == 0){
        evenList.Add(i);
        Console.WriteLine($"{i}");    
        }
    }
Console.WriteLine("List - Lens");
Console.WriteLine($"{evenList.Count}");
