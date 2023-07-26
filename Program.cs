int A(int i, int j)
{
 if (i == 0) return j + 1;
 else if (j == 0) return A(i - 1, 1);
 else
 {
return A(i - 1, A(i, j - 1));
 }
        
    
}
Console.WriteLine(A(3, 2));