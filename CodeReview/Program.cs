namespace CodeReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool notUsed = true;
            bool notModified = true;
            if (notModified){string message = "alma körte banán"; Console.WriteLine($"{message.Split(" ")[0]}\n{message.Split(" ")[1]}\n{message.Split(" ")[2]}");
                message = "piros zöld"; Console.WriteLine($"{message.Split(" ")[0]}\n{message.Split(" ")[1]}");
                message = "GPU CPU NPU FPU"; Console.WriteLine($"{message.Split(" ")[0]}\n{message.Split(" ")[1]}\n{message.Split(" ")[2]}\n{message.Split(" ")[3]}");}
            else splitmethod("alma körte banán");
        }

        static void splitmethod(string message)
        {var parts = message.Split(" ");foreach (var part in parts) { Console.WriteLine(part); }}

        static void unusedmethod() { Console.WriteLine("This method is never called."); }
    }
}
