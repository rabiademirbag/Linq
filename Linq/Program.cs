public class Program
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        List<int>numbers= new List<int>();
        for(int i=0; i<10; i++)
        {
            numbers.Add(rnd.Next(-100,100));
        }
        Console.WriteLine("Sayılar");
        foreach(int number in numbers)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();
        Console.WriteLine("Çift sayılar");
        var evenNumbers = numbers.Where(num=>num % 2 == 0);
        foreach(int number in evenNumbers)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();
        Console.WriteLine("Tek sayılar");
        var oddNumbers = numbers.Where(num => num % 2 != 0);
        foreach (var number in oddNumbers)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();
        Console.WriteLine("Negatif Sayılar");
        var negativeNumbers=numbers.Where(num=>num <0);
        foreach(var number in negativeNumbers)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();
        Console.WriteLine("Pozitif Sayılar");
        var positiveNumbers = numbers.Where(num => num > 0);
        foreach(var number in positiveNumbers)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();
        Console.WriteLine("15'ten büyük ve 22'den küçük sayılar");
        var biggerThanFifteen = numbers.Where(num => num > 15 && num < 22);
        foreach(var number in biggerThanFifteen)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();
        Console.WriteLine("Listedeki her bir sayının karesi ");
        var squaredNumbers = numbers.Select(num => num * num);
        foreach(var number in squaredNumbers)
        {
            Console.Write(number+" ");
        }
    }
}