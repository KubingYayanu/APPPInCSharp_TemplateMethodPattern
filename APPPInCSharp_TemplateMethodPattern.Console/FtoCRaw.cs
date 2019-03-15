namespace APPPInCSharp_TemplateMethodPattern.Console
{
    public class FtoCRaw
    {
        public void Run()
        {
            bool done = false;
            while (!done)
            {
                string fahrString = System.Console.In.ReadLine();
                if (fahrString == null || fahrString.Length == 0)
                {
                    done = true;
                }
                else
                {
                    double fahr = double.Parse(fahrString);
                    double celcius = 5.0 / 9.0 * (fahr - 32);
                    System.Console.Out.WriteLine($"F={fahr}, C={celcius}");
                }
            }
            System.Console.WriteLine("ftoc exit");
        }
    }
}