// Написать программу масштабирования фигуры
/*Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"*/

int CountSpace(string str)
{
    int count =0;
    for(int i=0;i<str.Length;i++)
        if(str[i]==' ')
            count++;
    return count;
}

// int CountSpace(string str)
// {
//     int count =0;
//     for(int i=0;i<str.Length,i++)
//         if(str[i]==' ')
//             count++;
//     return count;
// }

string[] Split(string str)
{
    string[] coordinates = new string[CountSpace(str)+1];
    int amount =0;
    for(int i=0;i<str.Length;i++)
    {
        while(i<str.Length && str[i]!=' ')
        {
            coordinates[amount]+=str[i];
            i++;
        }
        amount++;
    }
    return coordinates;
}
void PrintArray(string[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.WriteLine(array[i]);
}
Console.Write("Enter coordinates of figure: ");
string input = Console.ReadLine() ?? "";
if(input==null || input.Length==0)
{
    Console.WriteLine("Enter not empty string");
    return;
}
string[] coordinates = Split(input);
PrintArray(coordinates);