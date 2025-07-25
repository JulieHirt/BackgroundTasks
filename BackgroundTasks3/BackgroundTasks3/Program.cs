using System;
using Wisej.Web;

namespace BackgroundTasks3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.MainPage = new Page1();
        }

		static Program()
		{
			// Start the service.
			BackgroundService.Start();
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}