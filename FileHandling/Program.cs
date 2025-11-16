
Console.WriteLine("Tell us about yourself: ");

string userInput = Console.ReadLine() ?? "";


File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Personal)+@"\myDoc.txt", userInput);
