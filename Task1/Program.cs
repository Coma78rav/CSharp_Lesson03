double CalculateFormula(int a, int b, int c, int d)
{
    int numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 3);
Console.WriteLine(result);

