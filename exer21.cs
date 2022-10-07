double Coordinate (int[] arrA, int[] arrB)
{
  int x1 = arrA[0];
  int x2 = arrB[0];
  int y1 = arrA[1];
  int y2 = arrB[1];
  int z1 = arrA[2];
  int z2 = arrB[2];
 		
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

int [] arrA = {3, 6, 8};		
int [] arrB	= {2, 1, -7};
		
int [] arrC = {7,-5, 0}; 	
int [] arrD = {1, -1, 9};	

Console.WriteLine(Coordinate (arrA, arrB));
Console.WriteLine(Coordinate (arrC, arrD));	
		

