Random dice = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = dice.Next(1, 6);
        var roll = dice.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? input = Console.ReadLine();
    if (input != null)
    {
        return string.Equals("y", input.Trim().ToLower());
    }
    return false;

}

string WinOrLose(int target, int roll)
{
    return roll > target ? "You win!" : "You lose!";
}