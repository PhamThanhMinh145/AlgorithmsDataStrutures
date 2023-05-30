namespace AlgorithmsDataStrutures.Array
{
    public class LinearSearch
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //Key means what value we are searching for
        public bool LinearSearchEx(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key) { return true; }
            }
            return false;
        }

        public void ShowValueSearch()
        {
            Console.WriteLine(LinearSearchEx(array, 5));
        }

    }
}
