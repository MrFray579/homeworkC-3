double coordinate (double x1, double y1, double z1, double x2, double y2, double z2 )
{
    double AB = 0;
    if (x1 == x2 && y1 == y2)
    {
        return AB;
    }
    AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return AB;
}

double a = coordinate(3, 6, 8, 2, 1, -7);
Console.WriteLine(a);
