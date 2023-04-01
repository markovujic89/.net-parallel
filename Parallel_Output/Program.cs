
internal class Program
{
    
    private static void Main(string[] args)
    {
        var cts = new CancellationTokenSource();

        var token = cts.Token;

        var task = new Task(() =>
        {
            int i = 0;

            while (true) 
            {
                Console.WriteLine($"taks {i++}");
            }
        }, token);

        task.Start();

        Console.ReadKey();
        cts.Cancel();

        Console.ReadKey();
    }
}