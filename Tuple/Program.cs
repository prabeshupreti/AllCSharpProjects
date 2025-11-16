
int A = 4;
int B = 7;

Console.WriteLine($"Before Swap: A = {A}, B = {B}");

(A, B) = (B, A); //Tuple representation for swapping

Console.WriteLine($"After Swap: A = {A}, B = {B}");