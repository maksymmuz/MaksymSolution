namespace ReflectorNew
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
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			BrowseOpenButton = new ToolStripMenuItem();
			BrowseCloseButton = new ToolStripMenuItem();
			ShowAssemblyInfoButton = new Button();
			InfoTextBox = new TextBox();
			MethodsCheckBox = new CheckBox();
			PropertiesCheckBox = new CheckBox();
			AttributesCheckBox = new CheckBox();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(5, 2, 0, 2);
			menuStrip1.Size = new Size(1269, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BrowseOpenButton, BrowseCloseButton });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// BrowseOpenButton
			// 
			BrowseOpenButton.Name = "BrowseOpenButton";
			BrowseOpenButton.Size = new Size(103, 22);
			BrowseOpenButton.Text = "Open";
			BrowseOpenButton.Click += BrowseOpenButton_Click;
			// 
			// BrowseCloseButton
			// 
			BrowseCloseButton.Name = "BrowseCloseButton";
			BrowseCloseButton.Size = new Size(103, 22);
			BrowseCloseButton.Text = "Close";
			BrowseCloseButton.Click += BrowseCloseButton_Click;
			// 
			// ShowAssemblyInfoButton
			// 
			ShowAssemblyInfoButton.Location = new Point(10, 35);
			ShowAssemblyInfoButton.Margin = new Padding(3, 2, 3, 2);
			ShowAssemblyInfoButton.Name = "ShowAssemblyInfoButton";
			ShowAssemblyInfoButton.Size = new Size(134, 30);
			ShowAssemblyInfoButton.TabIndex = 1;
			ShowAssemblyInfoButton.Text = "ShowAssemblyInfo";
			ShowAssemblyInfoButton.UseVisualStyleBackColor = true;
			ShowAssemblyInfoButton.Click += ShowAssemblyInfoButton_Click;
			// 
			// InfoTextBox
			// 
			InfoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			InfoTextBox.BackColor = SystemColors.Control;
			InfoTextBox.ForeColor = SystemColors.ControlText;
			InfoTextBox.Location = new Point(167, 35);
			InfoTextBox.Margin = new Padding(3, 2, 3, 2);
			InfoTextBox.Multiline = true;
			InfoTextBox.Name = "InfoTextBox";
			InfoTextBox.ScrollBars = ScrollBars.Vertical;
			InfoTextBox.Size = new Size(1090, 700);
			InfoTextBox.TabIndex = 2;
			// 
			// MethodsCheckBox
			// 
			MethodsCheckBox.AutoSize = true;
			MethodsCheckBox.Location = new Point(10, 78);
			MethodsCheckBox.Margin = new Padding(3, 2, 3, 2);
			MethodsCheckBox.Name = "MethodsCheckBox";
			MethodsCheckBox.Size = new Size(73, 19);
			MethodsCheckBox.TabIndex = 5;
			MethodsCheckBox.Text = "Methods";
			MethodsCheckBox.UseVisualStyleBackColor = true;
			MethodsCheckBox.CheckedChanged += MethodsCheckBox_CheckedChanged;
			// 
			// PropertiesCheckBox
			// 
			PropertiesCheckBox.AutoSize = true;
			PropertiesCheckBox.Location = new Point(10, 100);
			PropertiesCheckBox.Margin = new Padding(3, 2, 3, 2);
			PropertiesCheckBox.Name = "PropertiesCheckBox";
			PropertiesCheckBox.Size = new Size(79, 19);
			PropertiesCheckBox.TabIndex = 6;
			PropertiesCheckBox.Text = "Properties";
			PropertiesCheckBox.UseVisualStyleBackColor = true;
			PropertiesCheckBox.CheckedChanged += PropertiesCheckBox_CheckedChanged;
			// 
			// AttributesCheckBox
			// 
			AttributesCheckBox.AutoSize = true;
			AttributesCheckBox.Location = new Point(10, 123);
			AttributesCheckBox.Margin = new Padding(3, 2, 3, 2);
			AttributesCheckBox.Name = "AttributesCheckBox";
			AttributesCheckBox.Size = new Size(78, 19);
			AttributesCheckBox.TabIndex = 7;
			AttributesCheckBox.Text = "Attributes";
			AttributesCheckBox.UseVisualStyleBackColor = true;
			AttributesCheckBox.CheckedChanged += AttributesCheckBox_CheckedChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveBorder;
			ClientSize = new Size(1269, 746);
			Controls.Add(AttributesCheckBox);
			Controls.Add(PropertiesCheckBox);
			Controls.Add(MethodsCheckBox);
			Controls.Add(InfoTextBox);
			Controls.Add(ShowAssemblyInfoButton);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Margin = new Padding(3, 2, 3, 2);
			Name = "Form1";
			Text = "Assembly Info";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem BrowseOpenButton;
		private ToolStripMenuItem BrowseCloseButton;
		private Button ShowAssemblyInfoButton;
		private TextBox InfoTextBox;
		private CheckBox MethodsCheckBox;
		private CheckBox PropertiesCheckBox;
		private CheckBox AttributesCheckBox;
	}
}