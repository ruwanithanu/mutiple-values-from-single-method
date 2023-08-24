class Program
{
    /// <summary>
    /// Utilizing multiple returns from a single method
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        var singleResult = GetValue();
        Console.WriteLine(singleResult);
        
        var itemResults = GetValues();
        Console.WriteLine(itemResults.Item1 + " " + itemResults.Item2);

        var (num, uniqueId) = GetValues();
        Console.WriteLine(num + " " + uniqueId);

        var paramResults = GetValuesWithParamName();
        Console.WriteLine(paramResults.num + " " + paramResults.uniqueId);
        
        Console.ReadKey();
    }
    
    private static long GetValue()
    {
        return new Random().Next();
    }

    private static (long, Guid) GetValues()
    {
        return (new Random().Next(), Guid.NewGuid());
    }

    private static (long num, Guid uniqueId) GetValuesWithParamName()
    {
        return (new Random().Next(), Guid.NewGuid());
    }
}