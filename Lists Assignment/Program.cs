namespace Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string listTypeSelect;
            Console.WriteLine("Please select one of the following two options:");
            Console.WriteLine("1. Integer List");
            Console.WriteLine("2. String List");
            listTypeSelect = Console.ReadLine();
            if (listTypeSelect.ToUpper() == "INTEGER LIST" || listTypeSelect == "1")
            {
                IntList();
            }
            else if (listTypeSelect.ToUpper() == "STRING LIST" || listTypeSelect == "2")
            {
                StrList();
            }
        }
        public static void IntList()
        {
            List<int> randInts = new List<int>();
            Random generator = new Random();
            for (int i = 0; i < 25; i++)
            {
                randInts.Add(generator.Next(10, 21));
                if (i != 24)
                {
                    Console.Write(randInts[i] + ", ");
                }
                else if (i == 24)
                {
                    Console.Write(randInts[i]);
                }
            }
            Console.WriteLine("Now please select an option from the following:");
            Console.WriteLine("1. Sort");
            Console.WriteLine("2. Generate New List");
            Console.WriteLine("3. Remove Value");
            Console.WriteLine("4. Add Value");
            Console.WriteLine("5. Count Occurrences"); // *****
            Console.WriteLine("6. Find Greatest");
            Console.WriteLine("7. Find Least");
            Console.WriteLine("8. Calculate Sum and Average");
            Console.WriteLine("9. Find Most Frequently Occurring");
            Console.WriteLine("10. Count Occurrences"); // *****
            Console.WriteLine("11. Exit");


        }
        public static void StrList()
        {

        }
    }
}