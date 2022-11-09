namespace Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        private string[] numbers;
        private string[] websites;

        public Smartphone(string[] numbers, string[] websites)
        {
            this.websites = websites;
            this.numbers = numbers;
        }

        public void Browse()
        {
            foreach (var website in websites)
            {
                bool IsValid = true;
                foreach (var ch in website)
                {
                    if (char.IsDigit(ch))
                    {
                        IsValid = false;
                        break;
                    }
                }
                if (IsValid)
                {
                    System.Console.WriteLine($"Browsing: {website}!");
                }
                else
                {
                    System.Console.WriteLine("Invalid URL!");
                }
            }
        }

        public void Call()
        {
            foreach (var number in numbers)
            {
                bool IsValid = true;

                foreach (var ch in number)
                {
                    if (!char.IsDigit(ch))
                    {
                        IsValid = false;
                        break;
                    }
                }
                if (IsValid && number.Length == 10)
                {
                    System.Console.WriteLine($"Calling... {number}");
                }
                else if (IsValid && number.Length == 7)
                {
                    System.Console.WriteLine($"Dialing... {number}");
                }
                else
                {
                    System.Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}