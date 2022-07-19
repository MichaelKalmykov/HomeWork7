double arithmeticMean = 0;
int [ , ] randArray = new int [3 , 4];
FillingArrayRandomValues(randArray);
PrintArray(randArray);
ArithmeticMean(arithmeticMean);

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
void ArithmeticMean (double arithmeticMean)
{
   for (int i = 0; i < randArray.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < randArray.GetLength(1); j++)
        {
            sum += randArray[i, j];
        }   
        Console.Write($" { sum / randArray.GetLength(1)} ");
    }
}