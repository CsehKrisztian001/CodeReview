namespace CodeReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "alma körte banán";
            Console.WriteLine($"{message.Split(" ")[0]}\n{message.Split(" ")[1]}\n{message.Split(" ")[2]}");
            message = "piros zöld";
            Console.WriteLine($"{message.Split(" ")[0]}\n{message.Split(" ")[1]}");
            message = "GPU CPU NPU FPU";
            Console.WriteLine($"{message.Split(" ")[0]}\n{message.Split(" ")[1]}\n{message.Split(" ")[2]}\n{message.Split(" ")[3]}");
        }

        static void SplitMethod(string message)
        {
            var parts = message.Split(" ");
            foreach (var part in parts)
            { Console.WriteLine(part); }
        }
    }
}
