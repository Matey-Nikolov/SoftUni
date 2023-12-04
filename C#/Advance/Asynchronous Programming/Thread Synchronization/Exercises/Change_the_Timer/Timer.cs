namespace Change_the_Timer
{
    public class Timer
    {
        static readonly object tLock = new object();

        private int hours;
		private int minutes;
		private int seconds;

		public int Seconds
		{
			get { return seconds; }
			set { seconds = value; }
		}

		public int Minutes
		{
			get { return minutes; }
			set { minutes = value; }
		}

		public int Hours
        {
			get { return hours; }
			set { hours = value; }
		}

		public Timer()
		{
			hours = 4;
			minutes = 59;
            seconds = 59;
		}

        public void IncreaseTimer()
		{
			Monitor.Enter(tLock);

			try
			{
                seconds++;

                if (seconds == 60)
                {
                    seconds = 0;
                    minutes++;
                }

                if (minutes == 60)
                {
                    minutes = 0;
                    Thread.Sleep(1000);
                    hours++;
                }
            }
			catch (SynchronizationLockException SyncEx)
			{
            }

			finally
			{
				Monitor.Exit(tLock);
			}
		}

        public void CurrentTime()
        {
            Monitor.Enter(tLock);

            Console.WriteLine($"Current Time = hours: {hours} minutes: {minutes} seconds: {seconds}");
        
            Monitor.Exit(tLock);
        }
    }
}