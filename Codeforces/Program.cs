class Program 
{
    public static void Main(string[] args) 
    {
        int t = int.Parse(Console.ReadLine());
        int [] sumArray = new int[t];
        for (int i = 0; i < t; i++)
        {
            string s = Console.ReadLine();
            string [] numberArray = s.Split();
            int a = int.Parse(numberArray[0]);
            int b = int.Parse(numberArray[1]);
            sumArray[i] = a + b;
        }
        for (int i = 0; i < sumArray.Length; i++)
        {
            Console.WriteLine(sumArray[i]);
        }
        Console.WriteLine();
    }
}