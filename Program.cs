namespace Csharp_Basic_Oppgave_1_Programflyt;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 0)
        {
            foreach (string arg in args)
            {
                string message = $"{arg}: ";

                if (double.TryParse(arg, out double temp))
                {
                    if (temp < -273.15)
                    {
                        message += "That's impossible!";
                    }
                    else if (temp <= 0)
                    {
                        message += "That's freezing!";
                    }
                    else if (temp >= 100)
                    {
                        message += "That's boiling!";
                    }
                    else
                    {
                        message += "That's neither freezing nor boiling.";
                    }
                }
                else
                {
                    message += "That's not a valid temperature.";
                }

                Console.WriteLine(message);
            }
        }
        else
        {
            Console.WriteLine("Please provide one or more temperatures.");
        }
    }
}
