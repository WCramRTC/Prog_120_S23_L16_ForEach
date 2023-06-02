namespace Prog_120_S23_L16_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 2, 5,1, 5,6, 4, 23 };
            // ForEach
            // Loop are a different kind of loop
            // They MUST work with arrays ( collection )
            // They go through one element after another

            //// While
            //int index = 0;

            //while (index < numbers.Length)
            //{
            //    Console.WriteLine(numbers[index]);
            //    index++;
            //}

            //// For
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // ForEach
            // foreach ( type name IN list ) {}
            // ForEach variables CANNOT be changed.

            // 1, 2, 3, 4, 5, 6 = 21
            // 11, 12, 13, 14, 15, 16
            //Console.WriteLine("Original Array");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            //Console.WriteLine("\nAfter Adding");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] += 10;
            //    Console.Write(numbers[i] + " ");
            //}

            //// ReadOnly
            //int sum = 0;

            //foreach (int number in numbers)
            //{
            //    sum += number;
            //    sum = sum + number;
            //}
            //Console.WriteLine();
            //Console.WriteLine(sum);

            //double average = sum / (double)numbers.Length;

            //Console.WriteLine(average);

            //foreach (string name in names)
            //{
            //    // allNames = allNames + name;
            //    allNames += name + " ";
            //}
            // index

            string[] firstNames = new string[]
            {
                "Benel", // 0
                "David", // 1
                "Nancy", // 2
                "Will", // 3
                "Josh" // 4
            };

            string[] lastNames = new string[]
            {
                "Alcine", // 0 
                "Abarca", // 1
                "Le", // 2
                "Cram", // 3
                "Emery" // 4
            };

            int[] grades = new int[]
            {
                105, // 0 
                110, // 1
                120, // 2
                47, // 3
                130 // 4
            };

            // Select FirstName, LastName, Grade
            // From Students

            // if
            /*
                SELECT host_name, store_number                FROM ECC.STORE, SERVER_TIME_ZONE                WHERE condition;
             */


            // id | First Name | Last Name
            // 0  | 
            // 1  |
            // 2  |
            // 3  |
            // 4  |
            // 5  |
            do
            {
                Console.Write("Please enter a last name to search for : ");
                string nameToSearchFor = Console.ReadLine();
                bool isNameFound = false;

                for (int i = 0; i < firstNames.Length; i++)
                {
                    if (nameToSearchFor == lastNames[i])
                    {
                        Console.WriteLine(firstNames[i] + " " + lastNames[i] + " - " + grades[i]);
                        isNameFound = true;
                    }
                }

                if (!isNameFound)
                {
                    Console.WriteLine("That name doesn't exist in our records.");
                }

            } while (true);

        } // Main

        public static void Example()
        {
            //string 

            string firstName = "Will";
            string lastName = "Cram";
            string fullName = firstName + " " + lastName;

            string allNames = "";

            // Allnames = "Benel "


            // type fore tab + tab for the shortcut
            //foreach (string name in names)
            //{
            //    // allNames = allNames + name;
            //    allNames += name + " ";
            //}
            // Benel David Nancy Ivan Will
            Console.WriteLine(allNames);
            //  5, 2, 5,1, 5,6, 4, 23 = 51
            // 51 / 8 = 6.375
            //Console.WriteLine(average);


            // numbers[i] += 7;

            // 0  1  2 3  4 5  6  7

            // 5, 2, 5,1, 5,6, 4, 23

            // number = 5
            // number = 2
            // number = 5

            // number

        }

    } // class

} // namespace