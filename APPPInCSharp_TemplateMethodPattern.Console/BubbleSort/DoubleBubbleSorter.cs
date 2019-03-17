namespace APPPInCSharp_TemplateMethodPattern.Console.BubbleSort
{
    public class DoubleBubbleSorter : Sorter
    {
        private double[] array = null;

        public int Sort(double[] theArray)
        {
            array = theArray;
            length = theArray.Length;
            return DoSort();
        }

        protected override bool OutOfOrder(int index) => array[index] > array[index + 1];

        protected override void Swap(int index)
        {
            double temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }
    }
}