Console.WriteLine("Введите кол-во строк массив m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов массив n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] NewArr (int m, int n)
{
    int[,] arr = new int[m,n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = rand.Next(0, 10);
            System.Console.Write(arr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    return arr;
}

void Avrg (int [,] arr)
{
    for (int j = 0; j < n; j++)
    {
        double avrg = 0;
        for (int i = 0; i < m; i++)
        {
            avrg = avrg + arr[i,j];
        }
        avrg = avrg / n;
        System.Console.WriteLine(avrg + "; ");
    }
}

int[,] arr = NewArr(m,n);
Avrg(arr);