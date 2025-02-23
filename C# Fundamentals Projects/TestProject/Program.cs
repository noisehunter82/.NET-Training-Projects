// Code challenge 1

/*
bool integerValid = false;
string? input;

Console.WriteLine("Enter a number with a value between 5 and 10.");
do
{
    input = Console.ReadLine();
    if (input == null) continue;

    bool isInteger = int.TryParse(input, out int parsedInteger);
    if (!isInteger)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
        continue;
    }
    integerValid = 5 < parsedInteger && parsedInteger < 10;
    if (!integerValid)
        Console.WriteLine($"You entered {input}. Please enter a number between 5 and 10.");
}
while (!integerValid);

Console.Write($"Your input value ({input}) has been accepted.");
*/




// Code challenge 2

/*
bool roleValid = false;
string? input;
string[] validRoles = { "administrator", "manager", "user" };

Console.WriteLine("Enter your role name (Administrator, Manager, or User).");
do
{
    input = Console.ReadLine();
    if (input == null) continue;

    input = input.Trim();
    foreach (string role in validRoles)
    {
        roleValid = role.Equals(input.ToLower());
        if (roleValid) break;
    };

    if (!roleValid)
        Console.WriteLine($"The role name that you entered, \"{input}\" is not valid. Enter your role name (Administrator, Manager, or User).");
}
while (!roleValid);

Console.Write($"Your input value ({input}) has been accepted.");
*/




// Code challenge 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
//int periodLocation;

foreach (string myString in myStrings)
{
    string[] sentences = myString.Split('.');

    if (sentences.Length > 0)
    {
        foreach (string sentence in sentences)
        {
            Console.WriteLine(sentence.Trim());
        }
    }
}