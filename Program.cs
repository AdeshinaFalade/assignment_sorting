namespace assignment_sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2,3,1,6,4,7,5,9,8};
            int x;
            for (int i = 0; i < numbers.Length - 1 ; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        x = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = x; 
                    }
                }

            }
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            

            
        }
    }
}