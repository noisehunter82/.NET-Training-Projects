string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

DisplayEmails(corporate);
DisplayEmails(external, externalDomain);

void DisplayEmails(string[,] names, string domain = "contoso.com")
{
    for (int i = 0; i < names.GetLength(0); i++)
    {
        // [..2] Range operator  
        string username = string.Concat(names[i, 0][..2], names[i, 1]).ToLower();
        Console.WriteLine($"{username}@{domain}");
    }
}