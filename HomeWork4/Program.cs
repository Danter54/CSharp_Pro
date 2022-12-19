var list =new List<int> {1,2,3,4,5,6};
var newlist = list.MyWhere(x=> x % 3 == 0).ToList();

foreach (var item in newlist)
{
    Console.Write($"{item} ");
}

static class Extention {
    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> filter)
    {
        foreach (var item in source)
        {
            if (filter(item))
                yield return item;
        }
    }
}