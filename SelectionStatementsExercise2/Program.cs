using Internal;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("whats your fave school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Concepts in Rehabalitation":
                    Console.WriteLine("concepts is not that bad");
                    break;

                case "Clinical Conditions and Applications":
                    Console.WriteLine("Condition and apps is a little bad");
                    break;

                case "Neuro for OT":
                    Console.WriteLine("pretty bad");
                    break;

                case "Professional Practice":
                    Console.WriteLine("free class oh yes");
                    break;

                default:
                    Console.WriteLine($"i have never heard of that subject in my life what is that. {subject} sounds ok though");
                    break;
            }
        }
    }
}