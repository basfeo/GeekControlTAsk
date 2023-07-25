// Array from task.
string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};

int LengthArr(string[] arr)
{
    // This function is for calculating the dimensionality of an array
    int index = 0;
    
    for (int i = 0; i < arr.Length; ++i)
    {
        if (arr[i].Length <=3)
        {
            index++;
        }
    }
    return index;
}

string[] CrtStrArr(string[] arr)
{
    // This function is for obtaining a new array after processing
    string[] NewStrArr = new string[LengthArr(arr)];
    int j = LengthArr(arr)-1;
    
    for (int i = 0; i < arr.Length; ++i)
    {
        if (arr[i].Length <= 3)
        {
            NewStrArr[j--] = arr[i];
            continue;
        }
    }
    return NewStrArr;
}

void PrintArray(string[] arrayForPrint)
{
    // This function is for printing array
    Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}


PrintArray(CrtStrArr(array2));
