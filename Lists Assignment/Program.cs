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
                    // for each element value is element - 10; (i.e. 10s: instances[0], 11s: instances[1]
                    for (int i = 0; i < randInts.Count; i++)
                    {
                        instances[randInts[i] - 10]++; // exception: index out of range? index of what? instances?
                    }
                    for (int i = 0; i < randInts.Count; i++)
                    {
                        Console.WriteLine($"{i + 10}: {instances[i]}"); // displays the instance count for each possible randInt element
                    }



                    //// i goes through potential element values
                    //for (int i = 10; i < 21; i++)
                    //{
                    //    // j goes through index numbers
                    //    for (int j = 0; j < randInts.Count; j++)
                    //    {
                    //        //check to see if each element matches i, then goes through a series of if statements to determine what that value is
                    //        if (randInts[j] == i)
                    //        {
                    //            if (i == 10)
                    //            {
                    //                // adds to a counter for each element value, these are then compared later
                    //                occ10++;
                    //                Console.WriteLine($"i10: {i}");
                    //                Console.WriteLine($"j10: {j}");
                    //                // crashes before an element that == i?
                    //            }
                    //            else if (i == 11)
                    //            {
                    //                occ11++;
                    //                Console.WriteLine($"i11: {i}");
                    //                Console.WriteLine($"j11: {j}");
                    //            }
                    //            else if (i == 12)
                    //            {
                    //                occ12++;
                    //                Console.WriteLine($"i12: {i}");
                    //                Console.WriteLine($"j12: {j}");
                    //            }
                    //            else if (i == 13)
                    //            {
                    //                occ13++;
                    //                Console.WriteLine($"i13: {i}");
                    //                Console.WriteLine($"j13: {j}");
                    //            }
                    //            else if (i == 14)
                    //            {
                    //                occ14++;
                    //                Console.WriteLine($"i14: {i}");
                    //                Console.WriteLine($"j14: {j}");
                    //            }
                    //            else if (i == 15)
                    //            {
                    //                occ15++;
                    //                Console.WriteLine($"i15: {i}");
                    //                Console.WriteLine($"j15: {j}");
                    //            }
                    //            else if (i == 16)
                    //            {
                    //                occ16++;
                    //                Console.WriteLine($"i16: {i}");
                    //                Console.WriteLine($"j16: {j}");
                    //            }
                    //            else if (i == 17)
                    //            {
                    //                occ17++;
                    //                Console.WriteLine($"i17: {i}");
                    //                Console.WriteLine($"j17: {j}");
                    //            }
                    //            else if (i == 18)
                    //            {
                    //                occ18++;
                    //                Console.WriteLine($"i18: {i}");
                    //                Console.WriteLine($"j18: {j}");
                    //            }   
                    //            else if (i == 19)
                    //            {
                    //                occ19++;
                    //                Console.WriteLine($"i19: {i}");
                    //                Console.WriteLine($"j19: {j}");
                    //            }
                    //            else if (i == 20)
                    //            {
                    //                occ20++;
                    //                Console.WriteLine($"i20: {i}");
                    //                Console.WriteLine($"j20: {j}");
                    //            }
                    //        }
                    //    }
                    //}
                    //king = 10;
                    //if (occ11 > occ10)
                    //{
                    //    king = 11;
                    //}
                    //if (occ12 > occ10)
                    //{
                    //    king = 12;
                    //}
                    //if (occ13 > occ10)
                    //{
                    //    king = 13;
                    //}
                    //if (occ14 > occ10)
                    //{
                    //    king = 14;
                    //}
                    //if (occ15 > occ10)
                    //{
                    //    king = 15;
                    //}
                    //if (occ16 > occ10)
                    //{
                    //    king = 16;
                    //}
                    //if (occ17 > occ10)
                    //{
                    //    king = 17;
                    //}
                    //if (occ18 > occ10)
                    //{
                    //    king = 18;
                    //}
                    //if (occ19 > occ10)
                    //{
                    //    king = 19;
                    //}
                    //if (occ20 > occ10)
                    //{
                    //    king = 20;
                    //}
                    //Console.WriteLine($"{king} appeared the most in the list");
                }

                else if (optionSelect.ToUpper() == "EXIT" || optionSelect == "10")
                {
                    Main();
                }
            }
        }

        // ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int indexFound;
        public static void StrList()
        {
            List<string> vegetables = new List<string>();
            bool done = false, validRemove = false, vegFound = false;
            string optionSelect, vegRemove, vegSearch;
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
                    Console.WriteLine("Please enter the vegetable you wish to remove:");

                    while (!validRemove)
                    {
                        vegRemove = Console.ReadLine();
                        if (vegRemove.ToUpper() != vegetables[0] || vegRemove.ToUpper() != vegetables[1] || vegRemove.ToUpper() != vegetables[2] || vegRemove.ToUpper() != vegetables[3])
                        {
                            Console.WriteLine("Please enter a valid element within the list");
                        }
                        else if (vegRemove.ToUpper() != vegetables[0])
                        {
                            vegetables[0].Remove(0);
                            validRemove = true;
                        }
                        else if (vegRemove.ToUpper() != vegetables[1])
                        {
                            vegetables[0].Remove(1);
                            validRemove = true;
                        }
                        else if (vegRemove.ToUpper() != vegetables[2])
                        {
                            vegetables[0].Remove(2);
                            validRemove = true;
                        }
                        else if (vegRemove.ToUpper() != vegetables[3])
                        {
                            vegetables[0].Remove(3);
                            validRemove = true;
                        }
                    }
                    Console.WriteLine("List with element removed:");
                    for (int i = 0; i < vegetables.Count; i++)
                    {
                        Console.WriteLine($"{vegetables[i]}, ");
                    }
                }

                else if (optionSelect.ToUpper() == "SEARCH LIST" || optionSelect == "3")
                {
                    Console.WriteLine("Please enter the element you wish to find:");
                    vegSearch = Console.ReadLine();
                    for (int i = 0; i < vegetables.Count; i++)
                    {
                        if (vegSearch.Equals(vegetables[i].ToUpper())) 
                        {
                            indexFound = i;
                        }
                        Console.Write($"Found! {vegSearch.ToUpper()} is located at index {indexFound}");
                    }
                    if (!vegetables.Contains(vegSearch))
                    {
                        Console.WriteLine($"Not found! Vegetables does not contain {vegSearch.ToUpper()}");
                    }
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