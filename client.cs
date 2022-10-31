using System;
public class client 
{
    public static void Main(String[] Args)
    {
        MathService ws1 = new MathService();
        Console.WriteLine(ws1.AddNumbers(10,20));
    }
}