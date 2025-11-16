
#region Simple String


string Name = "Prabesh Upreti";

#endregion

#region String Concatenation

string FirstName = "Prabesh";
string LastName = "Upreti";

string FullName = FirstName + " " + LastName;

#endregion

#region String Formatting
//Console.WriteLine("{0} {1}", FirstName, LastName);
#endregion

#region String Interpolation
//Console.WriteLine($"{FirstName} {LastName}");
#endregion

#region Escape Sequence
string Location = @"D:\ISMT Professional\IT\1st Semester";
#endregion

#region Raw String Literal
string RawString = """
                    My name is Prabesh Upreti.
                    I live in kalanki.
                        Home: Chitwan
                        Country: Nepal

                    The fancy word is "Ritual".
                    D:\ISMT Professional\IT\1st Semester
                    """;

#endregion
