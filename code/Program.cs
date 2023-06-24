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
Console.Write("Введите количество строк в массиве: ");
int size = Number();
System.Console.WriteLine();
string[] mass = new string[size];
Console.WriteLine("Введите строки массива: ");
System.Console.WriteLine();
CreateArray(mass, size);
int count = 0;

for (int i = 0; i < size; i++)
{
    if (mass[i].Length <= 3)
    { count++; }
}

