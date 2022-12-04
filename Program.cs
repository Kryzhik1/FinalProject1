// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина котрорых меньше
// либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения
// алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
/*void FillArray(string[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
collection[index] = string Random().Next("123", "hello", "go", "yes", "555", "$");
index++;
    }
}*/
/*string []array = {"cool", "go", "нyes", "hello", "12345", "$" };

void PrintArray(string[] array)
{
int count = array.Length;
int position = 0;
while (position < count)
{
    Console.WriteLine(array[position]);
    position++;
}
}

for (string i = 0; i <= 3; i++)



PrintArray(array);*/

/*string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);*/

/* ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/



void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Количество элементов в массиве ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент: ");
    string symbol = Console.ReadLine()!;
    arrayStrings[i] = symbol;
}
int length = 3;
int size2 = 0;
for (int i = 0; i < size; i++)
{
 if (arrayStrings[i].Length <= length)
    {
      size2++;
    }
}
string[] arrayFinal =  new string [size2];
int count = 0;
for (int i = 0; i <size; i++)
{
    if (arrayStrings[i].Length <= length)
    {
        arrayFinal[count] = arrayStrings[i];
        count++;
    }
} 
Console.WriteLine();
PrintArray(arrayFinal);
