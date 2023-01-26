using Internal;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("whats your fave school subject?");

            var subjcet = Console.ReadLine();

            switch (subject)
            {
                case "Concepts in Rehabalitiatino":
                    Console.WriteLine("concepts is not that bad");
                    break;
                case "Clinical Conditions and Applications"
                    Console.WriteLine("Condition and apps is a little bad");
                    break;
                case "Neuro for OT"
                    Console.WriteLine("pretty bad");
                default:
                    Console.WriteLine("i have never heard of that subject in my life what is that. {subject} sounds ok though");
                case "Professional Practice"
                    Console.WriteLine("free class yes");
                    break;
            }
        }
    }
}