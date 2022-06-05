// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
void PrintMatrix(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} ");
    Console.WriteLine();
    }
}
int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows,columns];
    var random = new Random();
    for(int i=0;i<rows;i++)
        for(int j=0;j<columns;j++)
            matrix[i,j] = random.Next(minValue,maxValue);
    return matrix;
}

// void AverageOfColumns(int[,] matrix)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         double number=0;
//         for(int i=0; i<matrix.GetLength(0); i++)
//             number += matrix[i,j];
//         Console.WriteLine($"The average of {j+1} columns: {Math.Round(number/matrix.GetLength(0),2)}");
//     }
// }

double AverageOfColumns(int[,] matrix, int columns)
{
    double number=0;
    for(int i=0; i<matrix.GetLength(0); i++)
        number += matrix[i,columns];
    return Math.Round(number/matrix.GetLength(0),2);
}


Console.Write("Enter amount of matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter left side of matrix columns: ");
int start = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter right side of matrix columns: ");
int finish = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = CreateMatrix(rows,columns,start,finish);
Console.WriteLine("Your matrix: ");
PrintMatrix(matrix);
// AverageOfColumns(matrix);
for(int j=0; j<matrix.GetLength(1); j++)
    Console.WriteLine($"The average of {j+1} columns: {AverageOfColumns(matrix,j)}");