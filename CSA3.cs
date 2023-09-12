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

        
    }
}