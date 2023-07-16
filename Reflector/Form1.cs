using System.Reflection;

namespace Reflector
{
	public partial class Form1 : Form
	{
		Assembly assembly = null;

		private OpenFileDialog openFileDialog;

		public Form1()
		{
			InitializeComponent();
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string path = openFileDialog.FileName;

				try
				{
					assembly = Assembly.LoadFile(path);

					textBox.Text += "Assembly: " + Environment.NewLine + path + Environment.NewLine
						+ "loaded successfully." + Environment.NewLine + Environment.NewLine;
				}
				catch (FileNotFoundException ex)
				{
					Console.WriteLine(ex.Message);
				}

				textBox.Text += "List of Types in the assembly:" + Environment.NewLine
					+ assembly.FullName + Environment.NewLine + Environment.NewLine;

				Type[] types = assembly.GetTypes();

				foreach (Type type in types)
				{
					textBox.Text += "Type:  " + type + Environment.NewLine;

					var methods = type.GetMethods();
					if (methods != null)
					{
						foreach (var method in methods)
						{
							string methStr = "Method: " + method.Name + Environment.NewLine;
							textBox.Text += methStr + Environment.NewLine;
						}
					}

					var properties = type.GetProperties();
					if (properties != null)
					{
						foreach (var property in properties)
						{
							string propStr = "Property: " + property.Name + Environment.NewLine;
							textBox.Text += propStr + Environment.NewLine;
						}
					}
				}
			}
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}