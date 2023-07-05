namespace Deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number between 5 and 15");
            string userInput = Console.ReadLine();
            int user = 0;

            try
            {
                user = int.Parse(userInput);
                if (user > 15 || user < 5)
                {
                    Console.WriteLine("PLease enter a number between 5 and 15");
                    
                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
            }
            method1(user);
        }

        // method to take user input and create array of n size and generate random numbers
        public static void method1(int user)
        {
            Random random = new Random(); // initalize new rand obj
            int[] myArray = new int[user]; // new array size of user input
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(10, 51);
            }
            Console.WriteLine("The elements of the array are: ");
            foreach (var i in myArray)
            {
                Console.Write(i.ToString() + ' ');
            }
            method2(myArray);
        }

        public static void method2(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("\nThe sum is: " + sum);
        }

    }
}