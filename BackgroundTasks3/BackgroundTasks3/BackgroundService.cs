using System.Threading;

namespace BackgroundTasks3
{
	public static class BackgroundService
	{
		private static Thread _thread;
		private static bool _stop = false;

		public static event BackgroundServiceEventHandler Message;

		public static void Start()
		{
			if (_thread == null)
				_thread = new Thread(ThreadStart);

			_stop = false;
			_thread.Start();
		}

		private static void ThreadStart()
		{
			var i = 0;
			while (!_stop)
			{
				Thread.Sleep(1000);

				i++;
				if (Message != null)
					Message(null, new BackgroundServiceEventArgs("Hello #" + i));
			}
		}

		public static void Stop()
		{
			_stop = true;
		}
	}
}
