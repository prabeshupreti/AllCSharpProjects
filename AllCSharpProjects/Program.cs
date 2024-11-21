#region String Declaration

string Name = "Prabesh Upreti";

#endregion

#region String Concatenation

//String Concatenation

string FirstName = "Prabesh";
string LastName = "Upreti";
string FullName = FirstName + " " + LastName;

//Console.WriteLine(FullName);

#endregion

#region String Interpolation

string Prabesh = "Prabesh";
string Upreti = "Upreti";

string Intro = $"My name is {Prabesh} {Upreti}.";

//Console.WriteLine(Intro);

#endregion

#region Formatting

//Console.WriteLine("My name is {1} {0}.", FirstName, LastName);

#endregion

#region Escape Sequence
//Console.WriteLine(@"D:\Microsoft\AndroidNDK");

//My name is "Prabesh" "Upreti".

#endregion

#region Raw String Literal

string Paragraph = $"""
                    My name is "{Prabesh}" "{Upreti}".
                    I live in Kalanki.
                    I have visited Basantapur, 
                            Lumbini, and Chitwan.

                    D:\Microsoft\AndroidNDK
                    """;

Console.WriteLine(Paragraph);

#endregion