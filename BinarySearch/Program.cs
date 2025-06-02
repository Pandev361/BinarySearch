namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] food = { "Käse", "Ananas", "Döner", "Reis", "Sahne", "Paprika", "Salami", "Schinken" };

            var sortetArr = SortingArr(food);


            Console.WriteLine("Put in your Word u are searching: \n");
            var input = Console.ReadLine();

            var isFound = input != null && BinarySearching(input, sortetArr);
            Console.WriteLine("Your Word " + (isFound ? "was found" : "wasnt found!"));
        }

        private static bool BinarySearching(string searchString, string[] sortetArr)
        {
            var foundItems = new List<string>();

            var left = 0;
            var right = sortetArr.Length - 1;


            while (left <= right)
            {
                var mid = (left + right) / 2;

                var cmp = string.CompareOrdinal(searchString, sortetArr[mid]);

                switch (cmp)
                {
                    case 0:
                        return true;
                    case < 0:
                        right = mid - 1;
                        break;
                    default:
                        left = mid + 1;
                        break;
                }
            }

            return false;
        }

        private static string[] SortingArr(string[] sortingArr)
        {
            var sortedArr = new string[sortingArr.Length];

            for (var i = 0; i < sortingArr.Length; i++)
            {
                for (var j = i + 1; j < sortingArr.Length; j++)
                {
                    if (string.CompareOrdinal(sortingArr[i], sortingArr[j]) <= 0) continue;
                    var temp = sortingArr[i];
                    sortingArr[i] = sortingArr[j];
                    sortingArr[j] = temp;
                }

                sortedArr[i] = sortingArr[i];
            }


            return sortedArr;
        }
    }
}