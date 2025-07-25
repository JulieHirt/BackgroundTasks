using Wisej.Web;

namespace BackgroundTasks3
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

		private bool _subscribed;
		private void button1_Click(object sender, System.EventArgs e)
		{
			if (_subscribed)
				BackgroundService.Message -= BackgroundService_Message;
			else
				BackgroundService.Message += BackgroundService_Message;


			_subscribed = !_subscribed;
			this.button1.Text = _subscribed ? "Unsubscribe" : "Subscribe";
		}

		private void BackgroundService_Message(object sender, BackgroundServiceEventArgs e)
		{
			Application.Update(this, () =>
			{
				this.label1.Text = e.Message;

			});
		}

	}
}
