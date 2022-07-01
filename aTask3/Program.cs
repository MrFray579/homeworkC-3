bool palindrom (int x)   // Можем ли мы использовать другие операторы?
{
    int div =1;
    while (x / div >= 10) //Проверка длины числа
    {
        div *= 10;       // если х = 525, то div = 100, если х = 5225, то div = 1000
    }

    Console.WriteLine(x);
    while (x != 0)
    {
        int a = x / div; //Первое число
        int r = x % 10; // Последнее число
        if (a != r) // Проверка первого и последнего числа
        {
            Console.WriteLine("Not Palindrom");
            return false;  //Возвращаем ложь "Not Palindrom"
        }

        x = (x % div) / 10;
        div /= 100;         // Проверка всех средних чисел
    }
    Console.WriteLine("Palindrom");
    return true; //Возвращаем правду "Palindrom"
}

palindrom(123321);
palindrom(12341);
palindrom(5225);
palindrom(525);

