public static int Add(int a, int b)
{
    return a + b;
}

public static decimal Add(decimal a, decimal b)
{
    return a + b;
}

public static string Add(int a, int b, bool includeCurrency)
{
    int sum = a + b;
    if (includeCurrency)
    {
        return sum + " dollars";
    }
    else
    {
        return sum.ToString();
    }
}
