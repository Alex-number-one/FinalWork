int FindSum(int M, int N)
{
if (M == N) return N;
return M + FindSum(M + 1, N);
}
Console.WriteLine(FindSum(1, 150));