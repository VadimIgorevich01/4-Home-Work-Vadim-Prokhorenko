int GetCheckedNumber (string info)
{
    Console.WriteLine (info);
    string? numberToBeChecked = Console.ReadLine();
    while (isThereText(numberToBeChecked))
    {
        Console.WriteLine ("Условие не выполнено, попробуйте ввести иначе");
        Console.WriteLine (info);
        numberToBeChecked = Console.ReadLine ();
    }
    int numberOk = Convert.ToInt32(numberToBeChecked);
    return numberOk;
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


//Task1________________________________________
int numberA = GetCheckedNumber ("Введите первое положительное целое число цифрами");
int numberB = GetCheckedNumber ("Введите второе положительное целое число цифрами");

int result = numberA;

for (int i = 1; i < numberB; i++)
{
    result = result * numberA;
}

Console.WriteLine (result);
//_____________________________________________

// //Task2________________________________________
// int number = GetCheckedNumber ("Введите целое положительное число");

// while (number < 0 && number == 0)
// {
//     number = GetCheckedNumber ("Введите точно целое положительное число, сэр");
// }



