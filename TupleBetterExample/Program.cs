#region Tuple Definition

using Tuple = (int Programming, int Networking);

#endregion

#region Input
Tuple t1;

Console.WriteLine("Enter the marks: ");
t1 = (int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

#endregion

#region Boxing

Tuple t2;
t2 = (t1.Programming, t1.Networking);

#endregion

#region Unboxing

Tuple t3;
(t3.Programming, t3.Networking) = t2;

#endregion

#region Output

Console.WriteLine($"Programming:{t3.Programming}, Networking:{t3.Programming}");

#endregion

