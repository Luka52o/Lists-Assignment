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

        public static int removeInt, addInt, countOccInt, occurrances = 1;
        public static void IntList()
        {
            List<int> randInts = new List<int>();
            Random generator = new Random();
            string optionSelect;
            bool validRemoveInt = false, validAddInt = false, validFindInt = false;
            int randIndex;
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
            Console.WriteLine("5. Count Occurrences");
            Console.WriteLine("6. Find Greatest");
            Console.WriteLine("7. Find Least");
            Console.WriteLine("8. Calculate Sum and Average");
            Console.WriteLine("9. Find Most Frequently Occurring");
            Console.WriteLine("10. Exit");

            Console.WriteLine();
            optionSelect = Console.ReadLine();
            if (optionSelect.ToUpper() == "SORT" || optionSelect == "1")
            {
                randInts.Sort();
                for (int i = 0; i < 25; i++)
                {
                    Console.Write(randInts[i] + ", ");
                }
            }
            else if (optionSelect.ToUpper() == "GENERATE NEW LIST" || optionSelect == "2")
            {
                randInts.Clear();
                Console.WriteLine("New List Generated:");
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
            }
            else if (optionSelect.ToUpper() == "REMOVE VALUE" || optionSelect == "3")
            {
                Console.WriteLine("Please specify the value you wish to remove:");
                while (!validRemoveInt)
                {
                    while (!Int32.TryParse(Console.ReadLine(), out removeInt))
                    {
                        Console.WriteLine("Please enter a valid integer value:");
                    }
                    if (!randInts.Contains(removeInt))
                    {
                        Console.WriteLine("Please enter a number within the list:");
                    }
                    else
                    {
                        validRemoveInt = true;
                    }
                }
                while (randInts.Remove(removeInt));
                Console.WriteLine($"List with {removeInt} removed:");
                for (int i = 0; i < randInts.Count; i++)
                {
                    Console.Write(randInts[i] + ", ");
                }
            }
            else if (optionSelect.ToUpper() == "ADD VALUE" || optionSelect == "4")
            {
                Console.WriteLine("Please enter the value you wish to enter:");

                while (!validAddInt)
                {
                    while (!Int32.TryParse(Console.ReadLine(), out addInt))
                    {
                        Console.WriteLine("Please enter a valid integer value:");
                    }
                    if (addInt > 20 || addInt < 10)
                    {
                        Console.WriteLine("Please enter a integer within the range of 10 - 20 inclusive:");
                    }
                    else
                    {
                        validAddInt = true;
                    }
                }
                randIndex = generator.Next(1, 26);
                randInts.Insert(addInt, randIndex);
            }
            else if (optionSelect.ToUpper() == "COUNT OCCURRENCES" || optionSelect == "5")
            {
                Console.WriteLine("Please enter the value you wish to count:");
                while (!validFindInt)
                {
                    while (!Int32.TryParse(Console.ReadLine(), out countOccInt))
                    {
                        Console.WriteLine("Please enter a valid integer value:");
                    }
                    if (!randInts.Contains(countOccInt))
                    {
                        Console.WriteLine("Value not in list. Please enter another value:");
                    }
                    else
                    {
                        validFindInt = true;
                    }
                }
                while (randInts.Contains(countOccInt))
                {
                    occurrances++;
                }
                Console.WriteLine($"List contains {countOccInt} {occurrances} time(s)");
            }
            else if (optionSelect.ToUpper() == "FIND GREATEST" || optionSelect == "6")
            {

            }
            else if (optionSelect.ToUpper() == "FIND LEAST" || optionSelect == "7")
            {

            }
            else if (optionSelect.ToUpper() == "CALCULATE SUM AND AVERAGE" || optionSelect == "8")
            {

            }
            else if (optionSelect.ToUpper() == "FIND MOST FREQUENTLY OCCURRING" || optionSelect == "9")
            {

            }
            else if (optionSelect.ToUpper() == "EXIT" || optionSelect == "10")
            {

            }
        }
        public static void StrList()
        {

        }
    }
}