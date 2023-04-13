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
            int randIndex;

            for (int i = 0; i <= 10; i++)
                instances.Add(0);

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
                    for (int i = 0; i < randInts.Count; i++)
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
                    for (int i = 0; i < randInts.Count; i++)
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
                    // stores each instance of each element in a list (instances), where the index
                    // for each element value is element - 10; (i.e. 10s: instances[0], 11s: instances[1])
                    for (int i = 0; i < randInts.Count; i++)
                    {
                        instances[randInts[i] - 10]++; 
                    }
                    Console.WriteLine("List of occurrences per number:");

                    for (int i = 0; i < instances.Count; i++)
                    {
                        if (instances[i] != instances.Max())
                        {
                            Console.WriteLine($"{i + 10}: {instances[i]}");
                        }
                        else  if (instances[i] == instances.Max())
                        {
                            Console.Write($"{i + 10}: {instances[i]} APPEARED THE MOST");
                            Console.WriteLine();
                        }
                    }
                }

                else if (optionSelect.ToUpper() == "EXIT" || optionSelect == "10")
                {
                    Main();
                }
            }
        }

        // ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int indexFound, removeIndex, addIndex, removeValIndex;
        public static string vegRemove, vegAdd;
        public static void StrList()
        {
            List<string> vegetables = new List<string>();
            bool done = false, validRemoveVal = false, validRemoveInd = false, vegFound = false, validAddInd = false, validAddVeg = false;
            string optionSelect, vegSearch;
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
                    while (!validRemoveInd)
                    {
                        while (!Int32.TryParse(Console.ReadLine(), out removeIndex))
                        {
                            Console.WriteLine("Please enter a valid integer value");
                        }
                        if (removeIndex < 1 || removeIndex > vegetables.Count)
                        {
                            Console.WriteLine($"Please enter an integer within the range of indexes (1 - {vegetables.Count})");
                        }
                        else if (removeIndex > 1 && removeIndex <= vegetables.Count)
                        {
                            validRemoveInd = true;
                        }
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
                    validRemoveVal = false;
                    Console.WriteLine("Please enter the vegetable you wish to remove:");

                    while (!validRemoveVal)
                    {
                        int j = 1;
                        vegRemove = Console.ReadLine();
                        for (int i = 0; i < vegetables.Count; i++)
                        {
                            if (vegRemove.ToUpper() == vegetables[i])
                            {
                                validRemoveVal = true;
                            }
                            else if (j == 1 && vegRemove.ToUpper() != vegetables[i])
                            {
                                Console.WriteLine("Vegetable not in list. Please try again.");
                                j++;
                            }
                        }
                    }
                    while (vegetables.Remove(vegRemove.ToUpper())) ;
                    Console.WriteLine("List with element removed:");
                    for (int i = 0; i < vegetables.Count; i++)
                    {
                        Console.Write($"{i + 1}: {vegetables[i]}  ");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }

                else if (optionSelect.ToUpper() == "SEARCH LIST" || optionSelect == "3")
                {
                    vegSearch = null;
                    vegFound = false;
                    Console.WriteLine("Please enter the element you wish to find:");
                    vegSearch = Console.ReadLine();
                    for (int i = 0; i < vegetables.Count; i++)
                    {
                        if (vegSearch.ToUpper() == (vegetables[i]))
                        {
                            indexFound = i;
                            vegFound = true;
                        }
                    }
                    if (!vegetables.Contains(vegSearch.ToUpper()))
                    {
                        Console.WriteLine($"Not found! Vegetables does not contain {vegSearch.ToUpper()}");
                    }
                    if (vegFound)
                    {
                        Console.Write($"Found! {vegSearch.ToUpper()} is located in slot {indexFound + 1}"); 
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }

                else if (optionSelect.ToUpper() == "ADD ELEMENT" || optionSelect == "4")
                {
                    Console.WriteLine("Please enter the name of the vegetable you wish to add:");
                    while (!validAddVeg)
                    {
                        int j = 0;
                        vegAdd = Console.ReadLine();
                        for (int i = 0; i < vegetables.Count; i++)
                        {
                            if (vegAdd.ToUpper() == vegetables[i])
                            {
                                Console.WriteLine($"Vegetable entered already in list: Slot {i + 1}");
                            }
                            else if (vegAdd.ToUpper() != vegetables[i])
                            {
                                j++;
                            }
                            if (j == vegetables.Count)
                            {
                                validAddVeg = true;
                            }
                        }
                    }
                    Console.WriteLine($"Now Please enter the slot number you wish to place {vegAdd.ToLower()} in:");
                    while (!validAddInd)
                    {
                        while (!Int32.TryParse(Console.ReadLine(), out addIndex))
                        {
                            Console.WriteLine("Please enter a valid integer to be used as a list slot.");
                        }
                        if (addIndex > vegetables.Count + 1)
                        {
                            Console.WriteLine("Please enter a number that is no greater than the current max slot + 1");
                        }
                        else if (addIndex < 1)
                        {
                            Console.WriteLine("Please enter an integer that is greater than or equal to 1");
                        }
                        else
                        {
                            validAddInd = true;
                            vegAdd = vegAdd.ToUpper();
                        }
                    }
                    if (addIndex == vegetables.Count + 1)
                    {
                        vegetables.Add(vegAdd);
                    }
                    else
                    {
                        vegetables.Insert(addIndex - 1, vegAdd);
                    }
                    Console.WriteLine("New list with added value at specified index:");
                    for (int i = 0; i < vegetables.Count; i++)
                    {
                        Console.Write($"{i + 1}: {vegetables[i]}  ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }

                else if (optionSelect.ToUpper() == "SORT LIST" || optionSelect == "5")
                {
                    vegetables.Sort();

                    Console.WriteLine("Sorted List:");
                    for (int i = 0; i < vegetables.Count; i++)
                    {
                        Console.Write($"{i + 1}: {vegetables[i]}  ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (optionSelect.ToUpper() == "CLEAR LIST" || optionSelect == "6")
                {
                    vegetables.Clear();
                    Console.WriteLine("List Cleared. Press ENTER to exit.");
                    Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Main();
                }
            }
        }
    }
}