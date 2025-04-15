namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            string personName = "John Doe";
            int personAge = 11;
            char firstCharacter = 'J';
            bool isPerson = true;
            double personHeight = 1.75;
            decimal personWeight = 70.5m;
            Console.WriteLine($"My name is: {personName} and I am {personAge} years old. The first character in my name is: {firstCharacter}. Am I a person? {isPerson}, why yes I am. I am {personHeight} tall and I weigh {personWeight}.");
        }
    }
}
