using System;
using System.Runtime.InteropServices.Marshalling;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groupCount = 6)
{
    RandomizeAnimals();
    string[,] groups = AssignGroup(groupCount);
    Console.WriteLine(schoolName);
    PrintGroup(groups);
}

void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
}

string[,] AssignGroup(int groupCount)
{
    int animalsPerGroup = pettingZoo.Length / groupCount;
    string[,] result = new string[groupCount, animalsPerGroup];
    int counter = 0;

    for (int groupIndex = 0; groupIndex < groupCount; groupIndex++)
    {
        for (int animalIndex = 0; animalIndex < animalsPerGroup; animalIndex++)
        {
            result[groupIndex, animalIndex] = pettingZoo[counter++];
        }
    }

    return result;
}

void PrintGroup(string[,] groups)
{
    int animalsPerGroup = pettingZoo.Length / groups.GetLength(0);

    for (int groupIndex = 0; groupIndex < groups.GetLength(0); groupIndex++)
    {
        string message = $"Group {groupIndex + 1}:";
        for (int animalIndex = 0; animalIndex < animalsPerGroup; animalIndex++)
        {
            message += $" {groups[groupIndex, animalIndex]}";
        }
        Console.WriteLine(message);
    }
    Console.WriteLine();
}