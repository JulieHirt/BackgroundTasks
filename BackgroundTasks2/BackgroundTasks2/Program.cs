using System;
using System.IO;
using System.Threading;
using Wisej.Web;

namespace BackgroundTasks2
{
    internal static class Program
    {
        static void Main()
        {
            Application.MainPage = new Page1();
        }
		static Program()
		{

			Application.StartTask(() =>
			{
				string filePath = Path.Combine(Application.MapPath("Files"), "log.txt");
				Directory.CreateDirectory(Path.GetDirectoryName(filePath));

				using (StreamWriter writer = new StreamWriter(filePath, append: true))
				{
					for (int i = 0; i <= 100; i += 10)
					{
						string log = $"[Startup Task] Progress: {i}% - {DateTime.Now}";
						writer.WriteLine(log);
						writer.Flush();

						Thread.Sleep(200);
					}

					writer.WriteLine("Startup background task completed.");

				}
				//AlertBox.Show("completed");
				//Application.Update(this);


			});
		}












		
	}
}