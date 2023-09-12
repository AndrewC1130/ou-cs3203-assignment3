namespace A3
{
    public class A3
    {

	//Our main method to print out to, and read from the console
        public static void Main(string[] args)
        {

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

        
    }
}