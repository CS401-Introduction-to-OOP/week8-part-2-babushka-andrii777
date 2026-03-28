namespace Ass83;

public static class BoxingTester
{
    public static void Test()
    {
    int a = 10;
    object b = a; // boxing, goes into heap (value type -> reference type)
    int c = (int)b; // unboxing, takes value from the heap (reference type -> value type)
    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
    }
}