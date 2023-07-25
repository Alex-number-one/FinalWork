Console.WriteLine("Write a number");
 int N = Convert.ToInt32(Console.ReadLine());
int function(int N)
{

    if (N == 1) return 1;
    Console.Write(N + ", ");
    return function(N - 1);
    
}
Console.WriteLine(function(N));