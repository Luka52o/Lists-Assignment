namespace Lists_Assignment
{
    internal class Program
    {
        static void Main()
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

        public static int removeInt, addInt, countOccInt, occurrances = 0;
        public static void IntList()
        {
            List<int> randInts = new List<int>();
            List<int> instances = new List<int>();
            Random generator = new Random();
            string optionSelect;
            bool validRemoveInt = false, validAddInt = false, validFindInt = false, done = false;
            int randIndex, occ10 = 0, occ11 = 0, occ12 = 0, occ13 = 0, occ14 = 0, occ15 = 0, occ16 = 0, occ17 = 0, occ18 = 0, occ19 = 0, occ20 = 0, king;
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
            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine("Please select an option from the following:");
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
                    while (randInts.Remove(removeInt)) ;
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
                    randInts.Insert(randIndex, addInt);
                    for (int i = 0; i < 25; i++)
                    {
                        Console.Write($"{randInts[i]}, ");
                    }
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
                        else if (randInts.Contains(countOccInt))
                        {
                            validFindInt = true;
                        }
                    }
                    for (int i = 1; i < randInts.Count; i++)
                    {
                        if (randInts[i] == countOccInt)
                        {
                            occurrances++;
                        }
                    }
                    Console.WriteLine($"List contains {countOccInt} {occurrances} time(s)");
                }
                else if (optionSelect.ToUpper() == "FIND GREATEST" || optionSelect == "6")
                {
                    Console.WriteLine($"The maximum value in the list is {randInts.Max()}");
                }
                else if (optionSelect.ToUpper() == "FIND LEAST" || optionSelect == "7")
                {
                    Console.WriteLine($"The maximum value in the list is {randInts.Min()}");
                }
                else if (optionSelect.ToUpper() == "CALCULATE SUM AND AVERAGE" || optionSelect == "8")
                {
                    Console.WriteLine($"The sum of all list index values is {randInts.Sum()}");
                    Console.WriteLine($"The average index value is {randInts.Average()}");
                }
                else if (optionSelect.ToUpper() == "FIND MOST FREQUENTLY OCCURRING" || optionSelect == "9")
                {
                    for (int i = 10; i <= 20; i++)
                    {
                        for (int j = 0; j <= 25; j++)
                        {
                            if (randInts[j] == i)
                            {
                                if (i == 10)
                                {
                                    occ10++;
                                }
                                else if (i == 11)
                                {
                                    occ11++;
                                }
                                else if (i == 12)
                                {
                                    occ12++;
                                }
                                else if (i == 13)
                                {
                                    occ13++;
                                }
                                else if (i == 14)
                                {
                                    occ14++;
                                }
                                else if (i == 15)
                                {
                                    occ15++;
                                }
                                else if (i == 16)
                                {
                                    occ16++;
                                }
                                else if (i == 17)
                                {
                                    occ17++;
                                }
                                else if (i == 18)
                                {
                                    occ18++;
                                }
                                else if (i == 19)
                                {
                                    occ19++;
                                }
                                else if (i == 20)
                                {
                                    occ20++;
                                }
                            }
                        }
                    }
                    king = 10;
                    if (occ11 > occ10)
                    {
                        king = 11;
                    }
                    if (occ12 > occ10)
                    {
                        king = 12;
                    }
                    if (occ13 > occ10)
                    {
                        king = 13;
                    }
                    if (occ14 > occ10)
                    {
                        king = 14;
                    }
                    if (occ15 > occ10)
                    {
                        king = 15;
                    }
                    if (occ16 > occ10)
                    {
                        king = 16;
                    }
                    if (occ17 > occ10)
                    {
                        king = 17;
                    }
                    if (occ18 > occ10)
                    {
                        king = 18;
                    }
                    if (occ19 > occ10)
                    {
                        king = 19;
                    }
                    if (occ20 > occ10)
                    {
                        king = 20;
                    }
                    instances.Add(occ10);
                    instances.Add(occ11);
                    instances.Add(occ12);
                    instances.Add(occ13);
                    instances.Add(occ14);
                    instances.Add(occ15);
                    instances.Add(occ16);
                    instances.Add(occ17);
                    instances.Add(occ18);
                    instances.Add(occ19);
                    instances.Add(occ20);

                    Console.WriteLine($"{king} appeared the most in the list");
                    for (int i = 0; i < instances.Count; i++)
                    {
                        Console.Write($"{instances[i]}, ");
                    }
                }
                else if (optionSelect.ToUpper() == "EXIT" || optionSelect == "10")
                {
                    Main();
                }
            }
        }
        public static void StrList()
        {
            List<string> vegetables = new List<string>();
            bool done = false;
            string optionSelect;
            int removeIndex;
            vegetables.Add("CARROT");
            vegetables.Add("BEET");
            vegetables.Add("CELERY");
            vegetables.Add("RADISH");
            vegetables.Add("CABBAGE");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}: {vegetables[i]} ");
            }
            while (!done)
            {
                Console.WriteLine("Please select one of the following options:");
                Console.WriteLine("1. Remove by Index");
                Console.WriteLine("2. Remove by Value");
                Console.WriteLine("3. Search List");
                Console.WriteLine("4. Add Element");
                Console.WriteLine("5. Sort List");
                Console.WriteLine("6. Clear List");
                optionSelect = Console.ReadLine();

                if (optionSelect.ToUpper() == "REMOVE BY INDEX" || optionSelect == "1")
                {
                    Console.WriteLine("Please enter the INDEX of the item you wish to remove:");
                    while (!Int32.TryParse(Console.ReadLine(), out removeIndex))
                    {
                        Console.WriteLine("Please enter a valid integer value");
                    }
                    if (removeIndex < 1 || removeIndex > 5)
                    {
                        Console.WriteLine("Please enter an integer within the range of indexes (1 - 5)");
                    }
                    vegetables.Remove(vegetables[removeIndex - 1]);
                    Console.WriteLine();
                    Console.WriteLine("List with element removed:");
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{i + 1}: {vegetables[i]} ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (optionSelect.ToUpper() == "REMOVE BY VALUE" || optionSelect == "2")
                {

                }
                else if (optionSelect.ToUpper() == "SEARCH LIST" || optionSelect == "3")
                {

                }
                else if (optionSelect.ToUpper() == "ADD ELEMENT" || optionSelect == "4")
                {

                }
                else if (optionSelect.ToUpper() == "SORT LIST" || optionSelect == "5")
                {

                }
                else if (optionSelect.ToUpper() == "CLEAR LIST" || optionSelect == "6")
                {

                }
            }
        }
    }
}