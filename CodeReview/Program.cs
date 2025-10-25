namespace CodeReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SplitMethod("alma körte banán");
            
            SplitMethod("piros zöld");
            
            SplitMethod("GPU CPU NPU FPU");
        }

        static void SplitMethod(string message)
        {
            foreach (var part in message.Split(" "))
            {
                Console.WriteLine(part);
            }
        }
    }
}
