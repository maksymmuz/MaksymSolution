namespace TemplateMethod
{
	internal abstract class TemplateClass
	{
		public void LoadWebPageTemplateMethod()
		{
			LoadHeader();
			LoadBody();
			LoadFooter();
		}

		protected abstract void LoadHeader();

		protected abstract void LoadBody();

		protected abstract void LoadFooter();
	}
}
