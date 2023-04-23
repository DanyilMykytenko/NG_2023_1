namespace ThreadExamples;

public class LockExample
{
    private int _number = 0;
    private object _locker = new();

    private void ThreadAction()
    {
        lock (_locker)
        {
            _number = 0;

            for (int i = 1; i <= 10; i++)
            {
                _number++;
                Console.WriteLine($"{Thread.CurrentThread.Name}: {_number}");
            }
        }
        Console.WriteLine("------------");
    }

    public void ThreadWorker()
    {
        // create threads
        
        for (int i = 1; i <= 10; i++)
        {
            Thread thread = new(ThreadAction);
            thread.Name = $"Thread {i}";
            thread.Start();
        }
    }
}