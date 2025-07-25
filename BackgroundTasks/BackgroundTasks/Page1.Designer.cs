namespace BackgroundTasks
{
    partial class Page1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.button1 = new Wisej.Web.Button();
			this.progressBar1 = new Wisej.Web.ProgressBar();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(74, 155);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(167, 61);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(277, 170);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(500, 46);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 1;
			this.progressBar1.Text = "progressBar1";
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1035, 438);
			this.ResumeLayout(false);

        }

		#endregion

		private Wisej.Web.Button button1;
		private Wisej.Web.ProgressBar progressBar1;
	}
}

