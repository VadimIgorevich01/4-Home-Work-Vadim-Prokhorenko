int GetCheckedNumber (string info)
{
    Console.WriteLine (info);
    string? numberToBeChecked = Console.ReadLine();
    while (isThereText(numberToBeChecked!) | TestForNullOrEmpty(numberToBeChecked!))
    {
        Console.WriteLine ("Условие не выполнено или строка пуста, попробуйте ввести иначе");
        Console.WriteLine (info);
        numberToBeChecked = Console.ReadLine ();
    }
    int numberOk = Convert.ToInt32(numberToBeChecked);
    return numberOk;
}

bool TestForNullOrEmpty(string s)
{
    bool result;
    result = s == null || s == string.Empty;
    return result;
}

bool isThereText (string typedNumber)
{
    string allowedCharacters = "1234567890";
    char characterToBeChecked = ' ';
    int checkedChars = 0;
    for (int i = 0; i < typedNumber.Length; i++)
    {
        characterToBeChecked = typedNumber [i];
        for (int j = 0; j < allowedCharacters.Length; j++)
        {
            if (characterToBeChecked == allowedCharacters [j])
            {
                checkedChars++;
                break;
            }           
        }
    }
    if (checkedChars == typedNumber.Length)
    {
        return false;
    }
    else
    {
        return true;
    }
}

void ShowArray (int [] arr)
{
    Console.Write("Наш массив: ");
    for (int w = 0; w < arr.Length; w++)
        {
            Console.Write(arr [w] + " ");
        }
}

// //Task1________________________________________
// int numberA = GetCheckedNumber ("Введите первое положительное целое число цифрами");
// int numberB = GetCheckedNumber ("Введите второе положительное целое число цифрами");

// int result = numberA;

// for (int i = 1; i < numberB; i++)
// {
//     result = result * numberA;
// }

// Console.WriteLine (result);
// //_____________________________________________

// //Task2________________________________________
int number = GetCheckedNumber ("Введите целое положительное число");
string numberTextType = Convert.ToString(number);

int [] numberArrayType = new int [numberTextType.Length];
int toPut = 0;
for (int index = 0; index < numberTextType.Length; index++)
{
    toPut = Convert.ToInt32(new string (numberTextType [index], 1));
    numberArrayType[index] = toPut;
}
int sum = 0;
for (int a = 0; a < numberArrayType.Length; a++)
{
    sum = sum + numberArrayType [a];
}
Console.WriteLine ("Сумма цифр: " + sum);



