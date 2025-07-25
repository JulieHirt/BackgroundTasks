using System.Threading;
using Wisej.Web;

namespace BackgroundTasks
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, System.EventArgs e)
		{
			button1.Enabled = false;
			progressBar1.Value = 0;
			Application.StartTask(() =>
			{
				for (int i = 0; i <= this.progressBar1.Maximum; i++)
				{

						progressBar1.Text = $"{i}%";
						progressBar1.PerformStep();


					Application.Update(this);
					Thread.Sleep(10); //replace with actual background task
				}

				this.button1.Enabled = true;
				AlertBox.Show("completed");
				Application.Update(this);
			});
		}
	}
}
