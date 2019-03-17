namespace APPPInCSharp_TemplateMethodPattern.Console.BubbleSort
{
    public class IntBubbleSorter : Sorter
    {
        private int[] array = null;

        public int Sort(int[] theArray)
        {
            array = theArray;
            length = array.Length;
            return DoSort();
        }

        protected override bool OutOfOrder(int index) => array[index] > array[index + 1];

        protected override void Swap(int index)
        {
            int temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }
    }
}