int Number()
{
    int num = int.Parse(Console.ReadLine());
    return num;
    Console.WriteLine();
}

string InputMass()
{
    string mass = Console.ReadLine();
    return mass;
    Console.WriteLine();
}
void CreateArray(string[] mass, int size)
{
    for (int i = 0; i < size; i++)
    {
        mass[i] = InputMass();
    }
    Console.WriteLine();
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write($"{arr[i]} ");

        Console.WriteLine();
    }
}
