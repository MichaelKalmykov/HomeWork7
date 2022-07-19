int rowValueUser = InputUserValuesSettings("Введите строку в которой есть искомый элемент ");
int columValueUser = InputUserValuesSettings("Введите столбец в которой есть искомый элемент ");
int [ , ] randArray = new int [4 , 3];
FillingArrayRandomValues(randArray);
PrintArray(randArray);
FindingValue(randArray);

int InputUserValuesSettings ( string  input)
{
    Console.Write(input);
    return Convert.ToInt16(Console.ReadLine());
}
void FillingArrayRandomValues(int [ , ] randArray)
{
    Random rand = new Random();
    for (int i = 0; i < randArray.GetLength(0); i++)
    {
        for (int j = 0; j < randArray.GetLength(1); j++)
        {
         randArray [ i, j] = Convert.ToInt16(new Random().Next(0, 10));
        }
    }
}
void PrintArray (int [,] randArray)
{
    for (int i = 0; i < randArray.GetLength(0); i++)
    {
        Console.Write("(");
        for (int j = 0; j < randArray.GetLength(1); j++)
        {
            Console.Write(" " + randArray[i, j] + " ");
        }
        Console.Write(")");
        Console.WriteLine("");
    }
}
void FindingValue (int [,] randArray)
{
    if (rowValueUser-- <= randArray.GetLength(0) && columValueUser-- <= randArray.GetLength(1))
    { 
        Console.WriteLine("Искомое значение равно: " + randArray[rowValueUser,columValueUser]); 
    }
    else
    {
        Console.WriteLine("Искомого значения нет в массиве");
    }
}