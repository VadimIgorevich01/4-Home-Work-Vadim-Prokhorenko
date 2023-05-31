int GetNumber (string info)
{
    Console.WriteLine (info);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

//Task1________________________________________
int numberA = GetNumber ("Введите первое целое число");
int numberB = GetNumber ("Введите второе целое число");
int result = numberA;

for (int i = 1; i < numberB; i++)
{
    result = result * numberA;
}

Console.WriteLine (result);