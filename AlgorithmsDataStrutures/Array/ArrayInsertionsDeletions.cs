namespace AlgorithmsDataStrutures.Array
{
    public class ArrayInsertionsDeletions
    {
        int[] intArray = new int[10];

        // Make a variable to keep the length because .Length is base off capocity and does track the actual index
        int length = 0;

        // this add data for us
        public void InsertData()
        {
            for (int i = 0; i < 8; i++)
            {
                intArray[length] = i + 1;
                length++;
            }
        }

        // this is show data for us
        public void showData()
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }

        public void InserAtTheEnd()
        {

            // Add the end 
            intArray[length] = 8;
            length++;
        }

        public void InserAtTheStart()
        {
            for (int i = 7; i >= 0; i--)
            {
                // this is moving over all the values
                intArray[i + 1] = intArray[i];
            }

            intArray[0] = 9;
            // add length to show data because data is shown which depends length
            length++;

        }

        public void InsertAnyWhere()
        {
            for (int i = 7; i >= 2; i--)
            {
                // Shift each element one position to the right
                intArray[i + 1] = intArray[i];

            }
            intArray[2] = 9;
            //add length to show data because data is shown which depends length
            length++;
        }

        public void DeleteFromTheEnd()
        {
            length--;
            intArray[length] = 0;

        }

        public void DeleteFromTheStart()
        {
            for (int i = 1; i < length; i++)
            {
                intArray[i - 1] = intArray[i];

            }
            length--;
            intArray[length] = 0;


        }

        public void DeleteFromAnywhere()
        {
            // delele value in index = 4
            for (int i = 5; i < length; i++)
            {
                intArray[i - 1] = intArray[i];
            }
            length--;
            intArray[length] = 0;
        }




    }
}
