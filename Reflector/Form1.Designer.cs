namespace Reflector
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			openFileDialog = new OpenFileDialog();
			contextMenuStrip1 = new ContextMenuStrip(components);
			filrToolStripMenuItem = new ToolStripMenuItem();
			dfgToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem1 = new ToolStripMenuItem();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem3 = new ToolStripMenuItem();
			textBox = new TextBox();
			contextMenuStrip1.SuspendLayout();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(20, 20);
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { filrToolStripMenuItem, dfgToolStripMenuItem, toolStripMenuItem1 });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(102, 76);
			// 
			// filrToolStripMenuItem
			// 
			filrToolStripMenuItem.Name = "filrToolStripMenuItem";
			filrToolStripMenuItem.Size = new Size(101, 24);
			filrToolStripMenuItem.Text = "filr";
			// 
			// dfgToolStripMenuItem
			// 
			dfgToolStripMenuItem.Name = "dfgToolStripMenuItem";
			dfgToolStripMenuItem.Size = new Size(101, 24);
			dfgToolStripMenuItem.Text = "dfg";
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(101, 24);
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(866, 28);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripMenuItem3 });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(46, 24);
			fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.Size = new Size(128, 26);
			openToolStripMenuItem.Text = "Open";
			openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
			// 
			// toolStripMenuItem3
			// 
			toolStripMenuItem3.Name = "toolStripMenuItem3";
			toolStripMenuItem3.Size = new Size(128, 26);
			toolStripMenuItem3.Text = "Close";
			toolStripMenuItem3.Click += toolStripMenuItem3_Click;
			// 
			// textBox
			// 
			textBox.Location = new Point(12, 31);
			textBox.Multiline = true;
			textBox.Name = "textBox";
			textBox.Size = new Size(803, 589);
			textBox.TabIndex = 2;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(866, 654);
			Controls.Add(textBox);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Form1";
			contextMenuStrip1.ResumeLayout(false);
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem filrToolStripMenuItem;
		private ToolStripMenuItem dfgToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItem1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItem3;
		private TextBox textBox;
	}
}