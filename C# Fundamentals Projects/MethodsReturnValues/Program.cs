/* 
using System.Runtime.CompilerServices;

double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total > minimumSpend;
}

string FormatDecimal(double input)
{
    //return Math.Round(input, 2).ToString();
    input -= (input % 0.01);
    return input.ToString();
}
 */

///////////////////

/* 
double usd = 23.73;
int rate = 23500;
int vnd = UsdToVnd(usd);


Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    return (int)(usd * rate);
}

double VndToUsd(int vnd)
{
    return vnd / (double)rate;
}
 */

///////////////////

/* 
string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input)
{
    string[] words = input.Trim().Split(' ');
    for (int i = 0; i < words.Length; i++)
    {
        words[i] = ReverseWord(words[i]);
    }
    return string.Join(' ', words);
}

string ReverseWord(string word)
{
    char[] charArray = word.ToCharArray();
    Array.Reverse(charArray);
    return string.Join("", charArray);
}
 */

///////////////////

/* 
string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    return string.Equals(word, ReverseWord(word));
}

string ReverseWord(string word)
{
    char[] charArray = word.ToCharArray();
    Array.Reverse(charArray);
    return string.Join("", charArray);
}
 */

///////////////////


int target = 30;
int[] coins = [5, 5, 50, 25, 25, 10, 5];
int[,] result = TwoCoins(coins, target);

if (result.GetLength(0) == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine($"Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (result[i, 0] == -1)
        {
            break;
        }
        else
        {
            Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
        }
    }
}

int[,] TwoCoins(int[] coins, int target)
{
    int[,] matches = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int matchIndex = 0;

    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                matches[matchIndex, 0] = curr;
                matches[matchIndex, 1] = next;

                if (matchIndex >= 4)
                {
                    return matches;
                }
                matchIndex++;
            }
        }
    }
    return matchIndex == 0 ? new int[0, 0] : matches;
}