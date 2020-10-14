using System;
using System.Collections.Generic;
using System.Linq;

namespace Programming.Tasks
{
    public static class MindStromTasks
    {
        public static void PrintFactorial(int number)
        {
            for (int i = number - 1; i > 0; i--)
            {
                number *= i;
            }
            Console.WriteLine(number);
        }

        public static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
        public static void PrintStar(int number)
        {
            var temp = number;
            for (int j = 1; j <= number; j++)
            {
                for (int k = 0; k < 2 * temp - 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                for (int i = 0; i < j; i++)
                {

                    Console.Write("  ");
                }

                temp--;
            }
        }

        public static void FindLowestDecimal(int number)
        {

            char[] chars = number.ToString().ToCharArray();

            // TODO: Need to further dig in
            var result = Convert.ToInt32(chars.Min());
            Console.WriteLine(result);
        }
        public static int DistinctArrayCount(int[] A)
        {

            return A.Distinct().Count();
        }

        public static int MaximalTripletCount(int[] A)
        {

            Array.Sort(A);
            return A.Length > 0 ? A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3] : 0;
        }

        public static int Concatination(int[] A)
        {
            Pet[] cats = { new Pet { Name="Barley", Age=8 },
                new Pet { Name="Boots", Age=4 },
                new Pet { Name="Whiskers", Age=1 } };
            Pet[] dogs = { new Pet { Name="Bounder", Age=3 },
                new Pet { Name="Snoopy", Age=14 },
                new Pet { Name="Fido", Age=9 } };

            IEnumerable<string> printName =
                new[] { cats.Select(x => x.Name), dogs.Select(x => x.Name) }.SelectMany(x => x);

            Array.Sort(A);
            return A.Length > 0 ? A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3] : 0;
        }

        public static void FindLowestDecimal(long number)
        {
            if (long.MaxValue > number)
            {
                var list = new List<long>();
                while (number > 0)
                {
                    list.Add(number % 10);
                    number /= 10;
                }

                // Sort the array 
                list.Sort();

                //Find the lowest number
                var lowestNumber = list.FirstOrDefault();
                //Find the highest number
                var highestNumber = list.LastOrDefault();
                // alternative way to find the min or max digit from given number but it is not the best approach
                char[] chars = number.ToString().ToCharArray();
                var result = chars.Min();
                Console.WriteLine(lowestNumber);
            }
            else
            {
                Console.WriteLine("Too big number is not allowed.");
            }
        }

        public static void FibonacciSeries(long number)
        {
            int a = 0, b = 1;
            Console.Write("{0} {1} ", a, b);
            for (int i = 2; i < number; i++)
            {
                var temp = a + b;
                Console.Write(temp + " ");
                a = b;
                b = temp;
            }

            RecurrsiveMethod(0, 1, 1, number);
        }

        private static void RecurrsiveMethod(int a, int b, int counter, long number)
        {
            if (counter <= number)
            {
                Console.Write(a + " ");
                RecurrsiveMethod(b, a + b, counter + 1, number);
            }
        }

        public static void PrintStrings()
        {
            // Define the dictionary and add value in the dictionary
            Dictionary<string, string> weekdays = new Dictionary<string, string> { { "M", "Monday" }, { "T", "Tue" } };
            foreach (var weekday in weekdays)
            {
                Console.Write("{0} stand for {1} ", weekday.Key, weekday.Value);
            }
        }
        // This method is use to find the gap of 
        public static int FindBinaryGap(int number)
        {
            //Convert number into binary format
            var result = Convert.ToString(number, 2);
            char[] charArray = result.ToCharArray();
            int gapCount = 0;
            List<int> gapList = new List<int>();
            foreach (var t in charArray)
            {
                if (char.GetNumericValue(t) == 1)
                {
                    if (gapCount != 0)
                    {
                        gapList.Add(gapCount);
                    }
                    gapCount = 0;
                    continue;
                }

                gapCount += 1;
            }

            return gapList.Any() ? gapList.Max() : 0;
        }

        public static int[] RotateArray(int[] array, int times)
        {
            // TODO: still need to optimize the solution
            if (array.Length == times)
            {
                return array;
            }
            int first = array[0];
            int last = array[^1];
            for (int i = 1; i < times; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[^1] = first;
                array[^2] = last;

                first = array[0];
                last = array[^1];
            }

            return array;
        }

        public static int OddOccuranceNumberInArray(int[] A)
        {
            Dictionary<int, int> numberWithOccurrance = new Dictionary<int, int>();
            int occur = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] == A[j])
                    {
                        occur++;
                    }

                }

                if (!numberWithOccurrance.ContainsKey(A[i]))
                {
                    numberWithOccurrance.Add(A[i], occur);
                }

                occur = 0;
            }

            var num = numberWithOccurrance.FirstOrDefault(x => x.Value % 2 != 0).Key;

            return num;
        }

        public static int CodeComplexity(int start, int destination, int steps)
        {
            int count = 0;
            for (int i = start; i <= destination; i += steps)
            {
                count++;
            }
            return count;
        }

        public static int MissingElementInArray(int[] array)
        {
            Array.Sort(array);
            int temp = 0;
            foreach (var i in array)
            {
                if (temp != i - 1)
                {
                    return i - 1;
                }

                temp = i;
            }

            return 0;
        }

        public static int FindMinimalDifferenceInArray(int[] array)
        {
            //Array.Sort(array);
            var distinctArray = array.Distinct();
            List<int> count = new List<int>();
            int Pcount = 0, outerArrayCount = 0;
            for (int i = 1; i <= distinctArray.Count(); i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    Pcount += array[j];
                }

                outerArrayCount += array[i - 1];

                count.Add(Math.Abs(Pcount - outerArrayCount));
                Pcount = 0;
                //outerArrayCount = 0;
            }
            return count.Any() ? count.Min() : 0;
        }

        public static int FindMinimumTimeForJump(int X, int[] A)
        {
            return Array.IndexOf(A, X);
        }
        public static int[] Lesson4Task2CounterValues(int N, int[] A)
        {
            int[] counter = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < counter.Length)
                {
                    counter[A[i] - 1] += 1;
                }
                else
                {
                    //counter.Select(c => counter.Max()).ToArray();
                    //Array.Fill(counter,counter.Max()); Fill function not in C#
                    counter.Fill(counter.Max());

                }
            }

            return counter;
        }

        public static int ReturnSmallNumberFromArray(int[] A)
        {
            Array.Sort(A);
            List<int> missingNumbers = new List<int>();
            ////var result = A.AsEnumerable().Where(x => (A[x] - A[x - 1] != 1 && A[x] - A[x - 1] != 0)).Select(x => A[x - 1] + 1);
            //var result = A.AsEnumerable().Where(x => x> 1).Select(x => x + 1);
            //int result1=result.Max();
            var enumerable = Enumerable.Range(0, A[^1]).Except(A); // Find the missing elements.
            for (int i = 1; i < A.Length; i++)
            {

                if (A[i] - A[i - 1] != 1 && A[i] - A[i - 1] != 0)
                {
                    missingNumbers.Add(A[i - 1] + 1);
                }
            }
            missingNumbers.Sort();
            return missingNumbers.Count > 0 ? missingNumbers.Min() <= 0 ? 1 : missingNumbers.Min() : A[A.Length - 1] + 1;
            //return missingNumbers.Count > 0 ? missingNumbers[0] <= 0 ? 1 : missingNumbers[0] : A[A.Length - 1] + 1;
        }

        public static int CheckArrayIsPermutation(int[] A)
        {
            Array.Sort(A);
            for (int i = 1; i < A.Length; i++)
            {

                if (A[i] - A[i - 1] != 1 && A[i] - A[i - 1] != 0)
                {
                    return 0;
                }
            }

            return 1;
        }
        public static int FindCountOfDivisibleNumbers(int A, int B, int K)
        {
            int count = 0;
            for (int i = A; i <= B; i++)
            {
                if (i % K == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int[] ImpactFactor(string S, int[] P, int[] Q)
        {
            Dictionary<char, int> charDictionary = new Dictionary<char, int> { { 'A', 1 }, { 'C', 2 }, { 'G', 3 }, { 'T', 4 } };
            var stringToArray = S.ToCharArray();
            List<int> result = new List<int>();
            int tempResult = 0;
            for (int j = 0; j <= P.Length - 1; j++)
            {

                for (int i = P[j]; i <= Q[j]; i++)
                {
                    var value = charDictionary.FirstOrDefault(x => x.Key == stringToArray[i]).Value;
                    if (tempResult != 0)
                    {
                        if (tempResult < value)
                        {

                        }
                        else
                        {
                            tempResult = value;
                        }

                    }
                    else
                    {
                        tempResult = value;
                    }
                }

                result.Add(tempResult);
                tempResult = 0;

            }
            return result.ToArray();
        }

        public static int FindAverageOfArray(int[] A)
        {
            Array.Sort(A);
            if (A.Length > 0)
            {
                var avg = (A[0] + A[1]) / 2;

                return Convert.ToInt32(avg);
            }

            return 0;
        }

        public static int ArrayIntersection(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int[] temp = { A[i - 1], A[i] };
            }
            return -1;
        }
        public static int UseAggregateFunction(string[] A)
        {
            string longestName = A.Aggregate("test", (longest, next) => next.Length > longest.Length ? next : longest,
                fruit => fruit.ToLower());

            int[] ints = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };

            // Count the even numbers in the array, using a seed value of 0.
            int numEven = ints.Aggregate(0, (next, total) => next % 2 == 0 ? total + 1 : total);

            Console.WriteLine("The number of even integers is: {0}", numEven);

            // This code produces the following output:
            //
            // The number of even integers is: 6

            return -1;
        }

        public static string ReverseSentenceUsingAggregate(string A)
        {
            string[] chars = A.Split(" ");

            string reversedString = chars.Aggregate((workingSentence, next) => next + " " + workingSentence); // Aggregate function will return the single value.
            return reversedString;
        }

        public static bool IsAllElementStartsSame(string[] A)
        {
            return A.All(x => x.StartsWith("b"));
        }

        public static string AppendNumberAndJoin(string[] A)
        {
            return string.Join(",", A.Append("value")); ;
        }

        public static string AsEnumerableUsage(string[] A)
        {
            var result = A.AsEnumerable().Select(x => x.Contains("Ahsan"));
            return result.FirstOrDefault().ToString();
        }



        public static void LinqMethods(string[] A)
        {
            System.Collections.ArrayList fruits = new System.Collections.ArrayList();
            fruits.Add("mango");
            fruits.Add("apple");
            fruits.Add("lemon");
            IEnumerable<string> query = fruits.Cast<string>().OrderBy(x => x.StartsWith("a")).Select(x => x.ToLower());

        }

        public static void UseEmptyLinqMethod()
        {
            string[] names1 = { "Hartono, Tommy" };
            string[] names2 = { "Adams, Terry", "Andersen, Henriette Thaulow",
                "Hedlund, Magnus", "Ito, Shu" };
            string[] names3 = { "Solanki, Ajay", "Hoeing, Helge",
                "Andersen, Henriette Thaulow",
                "Potra, Cristina", "Iallo, Lucio" };

            List<string[]> nameslist = new List<string[]> { names1, names2, names3 };
            nameslist.Aggregate(Enumerable.Empty<string>(),
                (current, next) => next.Length > 3 ? current.Union(next) : current);
            var value = names1.DefaultIfEmpty("NoName");
        }

        public static void UseGroupByLinqMethod()
        {
            // Create a list of pets.
            List<Pet> petsList =
                new List<Pet>{ new Pet { Name="Barley", Age=8.3 },
                    new Pet { Name="Boots", Age=4.9 },
                    new Pet { Name="Whiskers", Age=1.5 },
                    new Pet { Name="Daisy", Age=4.3 } };
            var list = petsList.GroupBy(x => Math.Floor(x.Age), pet => pet.Age, (baseAge, ages) => new
            {
                Key = baseAge,
                Count = ages.Count(),
                Min = ages.Min(),
                Max = ages.Max(),

            });
        }

        public static void UseGroupJoinLinqMethod()
        {
            Person magnus = new Person { Name = "Hedlund, Magnus" };
            Person terry = new Person { Name = "Adams, Terry" };
            Person charlotte = new Person { Name = "Weiss, Charlotte" };

            Pet barley = new Pet { Name = "Barley", Owner = terry };
            Pet boots = new Pet { Name = "Boots", Owner = terry };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

            List<Person> people = new List<Person> { magnus, terry, charlotte };
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, daisy };

            // Find the person with name that having the collection of pets.
            var query = people.GroupJoin(pets, person => person, pet => pet.Owner,

                (person, petCollection) =>
                    new
                    {
                        OwnerName = person.Name,
                        Pets = petCollection.Select(x => x.Name)
                    });
            var quary2 = pets.Select(x => x.Owner.Name == people.Select(x => x.Name).FirstOrDefault());
        }
        public static void UseIntersectMethod()
        {
            Pet[] store1 = { new Pet { Name = "apple"},
                new Pet { Name = "orange" } };

            Pet[] store2 = { new Pet { Name = "apple"},
                new Pet { Name = "lemon"} };
            // Intersection basically use to give the common data between to collections
            var commonData = store1.Intersect(store2);
        }
        public static void UseJoinMethod()
        {
            Person magnus = new Person { Name = "Hedlund, Magnus" };
            Person terry = new Person { Name = "Adams, Terry" };
            Person charlotte = new Person { Name = "Weiss, Charlotte" };

            Pet barley = new Pet { Name = "Barley", Owner = terry };
            Pet boots = new Pet { Name = "Boots", Owner = terry };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

            List<Person> people = new List<Person> { magnus, terry, charlotte };
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, daisy };

            var result = people.Join(pets, person => person, pet => pet.Owner, (person, pet) =>
                  new
                  {
                      OwnerName = person.Name,
                      Pet = pet.Name
                  });
        }

        public static void UseSelectManyMethod()
        {
            PetOwner[] petOwners =
            { new PetOwner { Name="Higa",
                    Pets = new List<string>{ "Scruffy", "Sam" } },
                new PetOwner { Name="Ashkenazi",
                    Pets = new List<string>{ "Walker", "Sugar" } },
                new PetOwner { Name="Price",
                    Pets = new List<string>{ "Scratches", "Diesel" } },
                new PetOwner { Name="Hines",
                    Pets = new List<string>{ "Dusty" } } };

            // Project the pet owner's name and the pet's name.
            var result = petOwners.SelectMany(owner => owner.Name, (ownername, petname) => new
            {
                ownername,
                petname
            })
                .Select(x => new
                {
                    Owner = x.ownername.Name,
                    Pet = x.petname
                });
        }

        /// <summary>
        /// codility lesson 5 task 5
        /// </summary>
        /// <param name="A"></param>
        public static int FindCountPassingCars(int[] A)
        {
            Dictionary<int, int> valueDictionary = new Dictionary<int, int>();
            var count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i != 0 && A[i - 1] < A[i])
                {
                    for (int j = i; j < A.Length; j++)
                    {
                        if (A[i - 1] < A[j])
                        {
                            count++;
                        }
                    }
                }

            }

            return count;
        }

        public static int FindTripletInArray(int[] A)
        {

            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    for (int k = j + 1; k < A.Length - 1; k++)
                    {
                        if (A[i] + A[j] > A[k] && A[j] + A[k] > A[i] && A[k] + A[i] > A[j])
                        {
                            return 1;
                        }
                    }
                }

            }

            return 0;
        }

        public static int FindBalancedString(string S)
        {
            Dictionary<char, char> definedParanthasess = new Dictionary<char, char> { { '{', '}' }, { '[', ']' }, { '(', ')' } };
            Stack<char> stack = new Stack<char>();
            foreach (var c in S.ToCharArray())
            {
                if (definedParanthasess.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (definedParanthasess.FirstOrDefault(x => x.Value == c).Key == stack.FirstOrDefault())
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
        public static int Lesson6FindLivingFishCount(int[] A, int[] B)
        {
            // TODO: Need to check again
            Dictionary<int, int> fishValueAndDirection = new Dictionary<int, int>();
            for (int i = 0; i < A.Length - 1; i++)
            {
                fishValueAndDirection.Add(A[i], B[i]);
            }
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < A.Length; i++)
            {
                stack.Push(B[i]);
                if (i != 0 && B[i] == 0 && stack.Count > 0)
                {
                    if (fishValueAndDirection.FirstOrDefault(x => x.Key == A[i]).Key < fishValueAndDirection.FirstOrDefault(x => x.Key == A[i - 1]).Key)
                    {
                        stack.Pop();
                    }
                }
            }

            return stack.Count;
        }
        public static int ProperlyNestedString(string S)
        {
            Dictionary<char, char> keyWithValues = new Dictionary<char, char> { { '(', ')' } };
            Stack<char> stack = new Stack<char>();

            if (string.IsNullOrEmpty(S))
            {
                return 1;
            }
            foreach (var c in S.ToCharArray())
            {
                if (keyWithValues.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.FirstOrDefault() == keyWithValues.FirstOrDefault(x => x.Value == c).Key)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }

        public static int[,] SumOfTwoMatrix(int[,] A, int[,] B, int matrixRows, int matrixColumns)
        {
            int i, j;
            int[,] C = new int[10, 10];
            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColumns; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            Console.Write("\nSum Matrix :");
            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColumns; j++)
                {
                    Console.Write(C[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.Read();
            return C;
        }

        public static int[,] TransposeOfMatrix(int[,] A, int matrixRows, int matrixColumns)
        {
            int i, j;
            Console.Write("\nTranspose of Matrix :");
            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColumns; j++)
                {
                    Console.Write(A[j, i] + "\t");

                }
                Console.WriteLine();
            }
            Console.Read();
            return A;
        }

        public static int[,] UpperTriangularOfMatrix(int[,] A, int matrixRows, int matrixColumns)
        {
            int i, j;
            Console.Write("\nTranspose of Matrix :");
            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColumns; j++)
                {
                    if (i <= j)
                    {
                        Console.Write(A[j, i] + "\t");
                    }
                    else
                    {
                        Console.Write("0\t");
                    }

                }
                Console.WriteLine();
            }
            Console.Read();
            return A;
        }

        public static int[,] LowerTriangularOfMatrix(int[,] A, int matrixRows, int matrixColumns)
        {
            int i, j;
            Console.Write("\nTranspose of Matrix :");
            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColumns; j++)
                {
                    if (i >= j)
                    {
                        Console.Write(A[j, i] + "\t");
                    }
                    else
                    {
                        Console.Write("0\t");
                    }

                }
                Console.WriteLine();
            }
            Console.Read();
            return A;
        }

        public static int[,] IdentityMatrix(int[,] A, int matrixRows, int matrixColumns)
        {
            int i, j;
            Console.Write("\t Identity of Matrix :");
            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColumns; j++)
                {
                    if (i == j && A[i, j] != 1 || i != j && A[i, j] != 0)
                    {
                        goto label;
                    }
                }
            }
            Console.WriteLine("Identity matrix");
        label: Console.WriteLine("Not identity Matrix");
            return A;
        }


        public static int FindDuplicateAdjecentCharInArray()
        {
            var array = new[] { 11, 2, 3, 4, 5 };

            var s = "ababa";

            char temp = new char();// = 'a';
            var dic = new Dictionary<char, List<int>>();
            for (var index = 0; index < s.Length; index++)
            {
                var ch = s[index];
                if (ch == temp)
                {
                    if (!dic.ContainsKey(ch))
                        dic.Add(ch, new List<int>() { array[index - 1] });
                    else
                    {
                        var list = dic[ch];
                        list.Add(array[index]);
                    }
                }
                else
                {
                    if (!dic.ContainsKey(ch))
                        dic.Add(ch, new List<int>() { array[index] });
                    temp = ch;
                }
            }

            var sum = 0;
            foreach (var d in dic)
            {
                var grouped = d.Value.GroupBy(x => x).ToList();
                var maxKey = grouped.Max(x => x.Key);
                sum += grouped.Select(x => x.Key).Except(new[] { maxKey }).Sum();
            }

            var total = sum;
            return total;
        }

    }
    class PetOwner
    {
        public string Name { get; set; }
        public List<string> Pets { get; set; }
    }


    class Person
    {
        public string Name { get; set; }
    }
    class Pet
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public Person Owner { get; set; }

    }
    public static class ArrayExtensions
    {
        public static void Fill<T>(this T[] originalArray, T with)
        {
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = with;
            }
        }
    }
}
