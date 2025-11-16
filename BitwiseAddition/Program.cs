
int a = 10;
int b = 5;

while (b != 0)
{
    int carry = (a & b) << 1; // find carry bits
    a = a ^ b;                // add without carry
    b = carry;                // move carry to b
}

Console.WriteLine(a);
