namespace APPPInCSharp_TemplateMethodPattern.Console.FtoC
{
    public abstract class Application
    {
        private bool isDone = false;

        protected void SetDone()
        {
            isDone = true;
        }

        protected bool Done() => isDone;

        public void Run()
        {
            Init();
            while (!Done())
            {
                Idel();
            }
            Cleanup();
        }

        protected abstract void Init();

        protected abstract void Idel();

        protected abstract void Cleanup();
    }
}