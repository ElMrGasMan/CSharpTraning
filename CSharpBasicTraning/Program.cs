using CSharpBasicTraning.EasyProblems;

namespace CSharpBasicTraning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = TwoSum.MakeTheSumLinear([5, 5, 12, 43, 29, 35], 55);

            Console.WriteLine(result.Length != 0 ? $"The result is: [{result[0]}, {result[1]}]." : "The target was not reached.");
        }
    }
}
