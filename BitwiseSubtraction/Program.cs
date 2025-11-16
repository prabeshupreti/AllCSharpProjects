
int a = 20;
int b = 7;

// Convert subtraction into: a + (~b + 1)
b = ~b + 1; // two's complement (negation)

// Perform addition using bitwise logic
while (b != 0)
{
    int carry = (a & b) << 1;
    a = a ^ b;
    b = carry;
}

Console.WriteLine(a); // 13
