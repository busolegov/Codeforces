class Program
{
    public static void Main(string[] args)
    {

        int [] array1 = new int [] {1, 2, 5 };
        int [] array2 = new int[] { 1, 2, 5 };
        int [] array3 = new int[] { 1, 2, 5 };

        int click1 = 2;


        int t = int.Parse(Console.ReadLine());
        int[] sumArray = new int[t];
        for (int i = 0; i < t; i++)
        {
            string s = Console.ReadLine();
            string[] numberArray = s.Split();
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