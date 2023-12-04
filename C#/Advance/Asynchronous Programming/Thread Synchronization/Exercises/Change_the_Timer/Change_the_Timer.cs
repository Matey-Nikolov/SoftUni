namespace Change_the_Timer
{
    public class Program
    {
        static void Main()
        {
            Timer timer = new Timer();

            Thread threadTime = new Thread(timer.IncreaseTimer);

            threadTime.Start();

            timer.CurrentTime();
        }
    }
}