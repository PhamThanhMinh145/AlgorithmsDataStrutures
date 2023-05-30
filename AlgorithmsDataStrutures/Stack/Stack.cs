namespace AlgorithmsDataStrutures.Stack
{
    public class Stack
    {
        public int MaxSize { get; set; } //array stacks you need a maxsize to init away 

        // this holds our array
        public string[] StackArray { get; set; }
        // this keeps track of the top 

        public int Top { get; set; }

        public Stack(int size)
        {

            //this holds contructor value
            this.MaxSize = size;
            //creares array with size
            this.StackArray = new string[MaxSize];
            // We give the top -1 because array is zero index, If we don't it will skip first element
            this.Top = -1;

        }

        public void Push(string item)
        {
            //
            Top++;
            StackArray[Top] = item;
        }

        public string Pop()
        {
            //Think placeholder
            int old_top = Top;
            //Decrement for the new top 
            Top--;
            return StackArray[old_top];
        }

        public string Peek()
        {
            return StackArray[Top];
        }
        public bool isEmpty()
        {
            return Top == -1;
        }

        public bool isFull()
        {
            return (MaxSize - 1 == Top);
        }


    }
}
