using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackgroundTasks3
{
	public class BackgroundServiceEventArgs : EventArgs
	{

		public BackgroundServiceEventArgs(string message)
		{
			this.Message = message;
		}

		public string Message
		{
			get;
			private set;
		}

	}
}