namespace AlgorithmsDataStrutures.Array
{
    public class BinarySearch
    {
        int[] intArray = { -22, -15, 2, 7, 20, 30, 54 };

        private int BinarySearchEx(int[] intArray, int value)
        {
            int start = 0;
            int end = intArray.Length;

            // start end + while less than is going criss crossing
            while (start < end)
            {
                // put in parenthensis because add them incorrect
                int midpoint = (start + end) / 2;
                // Search the middle the of the book 
                if (intArray[midpoint] == value)
                {
                    return intArray[midpoint];
                }
                else if (value > intArray[midpoint])
                {
                    start = midpoint + 1;
                }
                else
                {
                    end = midpoint;
                }
            }

            return -1;
        }

        public void ShowBinarySearch()
        {
            Console.WriteLine(BinarySearchEx(intArray, -15));
        }

    }
}
