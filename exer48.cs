//Выполнил Рекурсией

void decod (int args){
    int rem = (args%2);
    Console.WriteLine(rem);
    if(args>0){
        decod(args/2);}
    }
            
int numFirst = 8; 
decod(numFirst);
