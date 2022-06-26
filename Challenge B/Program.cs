class Program
{
    public static int GetSum(int [] array)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (map.ContainsKey(array[i]))
            {
                map[array[i]]++;
            }
            else
            {
                map.Add(array[i], 1);
            }
        }

        List<int> sum = new List<int>();

        foreach (var item in map)
        {
            int couple = item.Value / 3;
            sum.Add((item.Value-couple) * item.Key);
        }
        var totalSum = sum.Sum();
        return totalSum;
    }

    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        int [] answer = new int[t];
        string[] products = new string[t];
        for (int i = 0; i < t; i++)
        {
            string productCount = Console.ReadLine();
            string productSet = Console.ReadLine();

            string[] productArray = productSet.Split();
            int[] productPrices = new int[productArray.Length];
            for (int k = 0; k < productArray.Length; k++)
            {
                productPrices[k] = int.Parse(productArray[k]);
            }

            answer[i] = GetSum(productPrices);
        }

        for (int m = 0; m < answer.Length; m++)
        {
            Console.WriteLine(answer[m]);
        }

        Console.WriteLine();
    }
}