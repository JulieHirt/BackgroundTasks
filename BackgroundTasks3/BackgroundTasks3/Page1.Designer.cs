namespace BackgroundTasks3
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
			this.label1 = new Wisej.Web.Label();
			this.button1 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(174, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(131, 159);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(260, 44);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1035, 438);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Wisej.Web.Label label1;
		private Wisej.Web.Button button1;
	}
}

