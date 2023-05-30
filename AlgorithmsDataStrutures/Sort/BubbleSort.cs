namespace AlgorithmsDataStrutures.Sort
{
    public class BubbleSort
    {
        int[] intArray = new int[] { 6, 5, 1, 7, 2, 4 };

        public int[] BubbleSortEx(int[] array)
        {
            // hold temporary swap variable.Think state
            int temp = 0;
            // Interates over entire loop MANY times

            for (int pointer = 0; pointer < array.Length; pointer++)
            {
                //Form the "box" that does the comparison
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    //this checks to see if left side is larger than the right
                    if (array[sort] > array[sort + 1])
                    {

                        // swap 
                        // we store variable as temp so we dont overwrite it when we swap 
                        temp = array[sort + 1];
                        // Put left variable in the right 
                        array[sort + 1] = array[sort];
                        // put the right variable in the left
                        array[sort] = temp;
                    }
                }
            }

            return array;
        }


        public void showBubbleSort()
        {
            int[] value = BubbleSortEx(intArray);
            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine(value[i]);

            }
        }
    }
}
