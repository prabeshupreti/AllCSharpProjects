
Console.WriteLine(Reverse("Prabesh")); // "hsebarp"

string Reverse(string s)
{
    if (s.Length <= 1)
        return s;

    return Reverse(s.Substring(1)) + s[0];
}
