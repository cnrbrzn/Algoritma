string str = Console.ReadLine();
string[] arr = str.Split(",");
int x = Convert.ToInt32(arr[1]);
Console.WriteLine(arr[0].Remove(x, 1));