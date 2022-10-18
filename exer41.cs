void larger (string args) {
			
    args = args.Replace(" ", "");
    string [] splited = args.Split(",");
    foreach (var item in splited) {
        int compare = int.Parse(item);
	if (compare >0) {
	Console.WriteLine($" {compare}");
	}
    }
}
		
string nums = "0, 7, 8, -2, -2";
larger (nums);
Console.WriteLine("nextLine");
string nums1 = "1, -7, 567, 89, 223";
larger (nums1);
