int rows = InputUserArraySettings("Введите количество строк: ");
int columns = InputUserArraySettings("Введите количество столбцов: ");
double [ , ] userArray = new double [rows , columns];
FillingArrayRandomValues(userArray);
PrintArray(userArray);

int InputUserArraySettings ( string  input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}
void FillingArrayRandomValues(double [ , ] userArray)
{
    Random rand = new Random();
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
         userArray [ i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArray (double[,] userArray)
{
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        Console.Write("(");
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            Console.Write(" " + userArray[i, j] + " ");
        }
        Console.Write(")");
        Console.WriteLine("");
    }
}