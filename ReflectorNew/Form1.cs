using System.Reflection;

namespace ReflectorNew
{
	public partial class Form1 : Form
	{
		string _assemblyPath;
		string _assemblyInfo;
		bool _includeMethods;
		bool _includeProperties;
		bool _includeAttributes;

		public Form1()
		{
			InitializeComponent();
		}

		private void BrowseOpenButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Assembly Files (*.dll)|*.dll|All Files (*.*)|*.*";
				openFileDialog.FilterIndex = 1;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					_assemblyPath = openFileDialog.FileName;
				}
			}
		}

		private void ShowAssemblyInfo()
		{
			try
			{
				Assembly assembly = Assembly.LoadFrom(_assemblyPath);
				_assemblyInfo = $"Assembly Name: {assembly.FullName} {Environment.NewLine}";

				Type[] types = assembly.GetTypes();
				foreach (Type type in types)
				{
					_assemblyInfo += Environment.NewLine;
					_assemblyInfo += $"Type: {type.FullName} {Environment.NewLine}";

					if (_includeMethods)
					{
						var methods = type.GetMethods();
						if (methods.Length > 0)
						{
							int m = 1;
							_assemblyInfo += $"Methods: {Environment.NewLine}";
							foreach (var method in methods)
							{
								_assemblyInfo += $"\t{m++}) {method.Name} {Environment.NewLine}";

								if (_includeAttributes)
								{
									GetCustomAttributes(method);
								}
							}
						}
					}

					if (_includeProperties)
					{
						var properties = type.GetProperties();
						if (properties.Length > 0)
						{
							int p = 1;
							_assemblyInfo += $"Properties: {Environment.NewLine}";
							foreach (var property in properties)
							{
								object[] attributes = property.GetCustomAttributes(true);
								_assemblyInfo += $"\t{p++}) {property.Name} {Environment.NewLine}";

								if (_includeAttributes)
								{
									GetCustomAttributes(property);
								}
							}
						}
					}
				}

				InfoTextBox.Text = _assemblyInfo;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading assembly: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BrowseCloseButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ShowAssemblyInfoButton_Click(object sender, EventArgs e)
		{
			ShowAssemblyInfo();
		}

		private void MethodsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			_includeMethods = MethodsCheckBox.Checked;
		}

		private void PropertiesCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			_includeProperties = PropertiesCheckBox.Checked;
		}

		private void AttributesCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			_includeAttributes = AttributesCheckBox.Checked;
		}

		void GetCustomAttributes(object obj)
		{
			var memberInfo = obj as MemberInfo;
			object[] attributes = memberInfo.GetCustomAttributes(true);

			if (attributes.Length > 0)
			{
				int o = 1;
				_assemblyInfo += $"\t\tThe '{memberInfo.Name}' class member decorated or can be decorated with the following attributes: {Environment.NewLine}";
				foreach (object attribute in attributes)
				{
					_assemblyInfo += $"\t\t{o++}. {attribute.GetType().Name} {Environment.NewLine}";
				}
			}
		}
	}
}