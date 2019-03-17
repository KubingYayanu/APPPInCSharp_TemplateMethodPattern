using System.IO;

namespace APPPInCSharp_TemplateMethodPattern.Console.FtoC
{
    public class FtocTemplateMethod : Application
    {
        private TextReader input;
        private TextWriter output;

        protected override void Init()
        {
            input = System.Console.In;
            output = System.Console.Out;
        }

        protected override void Idel()
        {
            string fahrString = input.ReadLine();
            if (fahrString == null || fahrString.Length == 0)
            {
                SetDone();
            }
            else
            {
                double fahr = double.Parse(fahrString);
                double celcius = 5.0 / 9.0 * (fahr - 32);
                output.WriteLine($"F={fahr}, C={celcius}");
            }
        }

        protected override void Cleanup()
        {
            output.WriteLine("ftoc exit");
        }
    }
}