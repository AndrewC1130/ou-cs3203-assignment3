namespace A3
{
    public class A3
    {

	//Our main method to print out to, and read from the console
        public static void Main(string[] args)
        {
            Console.Write("How many numbers would you like to enter? ");
            string quantStr = Console.ReadLine();
            int quant = Convert.ToInt32(quantStr);

            int[] nums = new int[quant];

            for(int i = 0; i < quant; i++)
            {
                Console.Write($"Enter number {i+1}: ");
                nums[i] = Convert.ToInt32 (Console.ReadLine());
            }

            Console.Write("Array: [");
            for(int i = 0; i< quant-1; i++)
            {
                Console.Write(nums[i] + ",");
            }
            Console.WriteLine(nums[quant-1] + "]");

            A3 myClass = new A3();

            Console.WriteLine("Sum of numbers: " + myClass.SumOfList(nums));
            Console.WriteLine("Product of numbers: " + myClass.ProdOfList(nums));

	    Console.Write("Array in Reverse: [");
            for (int i = 0; i < quant - 1; i++)
            {
                Console.Write(myClass.ReverseOrder(nums)[i] + ",");
            }
            Console.WriteLine(myClass.ReverseOrder(nums)[quant - 1] + "]");
	}
        
        //This function takes an array of numbers and returns the sum of those numbers
        public int SumOfList(int[] numbers)
        {
            int sum = 0;

            foreach (int i in numbers)
            {
                sum += i;
            }

            return sum;
        }

	//This function takes an array of numbers and returns the product of those numbers
        public int ProdOfList(int[] numbers)
        {
            int prod = 1;

            foreach (int i in numbers)
            {
                prod *= i;
            }

            return prod;
        }

	//This function takes an array of numbers and returns an array in the reverse order
        public int[] ReverseOrder(int[] numbers)
        {
            int[] reverse = new int[numbers.Length];

            for(int i = 0; i<numbers.Length; i++)
            {
                reverse[numbers.Length-1-i] = numbers[i];
            }

            return reverse;
        }

        
    }
}