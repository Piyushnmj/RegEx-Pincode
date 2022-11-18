namespace RegExPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expressions Problems");

            Patterns objPattern = new Patterns();
            objPattern.ValidatePinCode("400088B");
        }
    }
}