namespace lab6
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            //Application.Run(new Form2());
            //Application.Run(new Form3());
            //Application.Run(new Form4());
            Application.Run(new Form5());
        }
    }
}