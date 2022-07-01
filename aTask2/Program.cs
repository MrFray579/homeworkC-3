int[] calculad (int a)
{
    int[] num = new int[a];
    int i = 1;

    while (i <= a)
    {
        num[i-1] = i * i * i;
        Console.Write(num[i-1] + ",");
        i++;
    }
    return num;
}

int[] result = calculad(5);


/*Console.WriteLine("Введите число:");
int a  = Convert.ToInt32(Console.ReadLine());
int [] array = new int[a];
int i = 1;

while (i <= a)
{
    array[i - 1] = i * i * i;
    Console.Write(array[i -1] + ",");
    i++;
}*/
