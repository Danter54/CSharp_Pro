Console.WriteLine("Test:");

int a = 3.4.Round();
Console.WriteLine(a);
int b = 3.6.Round();
Console.WriteLine(b);

public static partial class Extention
{
    public static int Round(this double d)
    {
        return Convert.ToInt32(Math.Round(d));
    }
}