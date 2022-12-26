Console.WriteLine("Введите кол-во строк массив m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов массив n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер элемента (исчисление номера начинается с 0): ");
int k = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите номер столбеца элемента: ");
//int p = Convert.ToInt32(Console.ReadLine());

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

void GetNumber (int [,] arr)
{
    int number = m*n;
    if ( k > number )
    {
        System.Console.WriteLine("Элемента не существует");
    }
    if ((k+1)%n != 0)
    {
        int num = arr[(k+1)/n,k%n];
        System.Console.WriteLine(num);
    }
    else
    {
        int num = arr[k/n,n-1];
        System.Console.WriteLine(num);
    }
}

int[,] arr = NewArr(m,n);
GetNumber(arr);