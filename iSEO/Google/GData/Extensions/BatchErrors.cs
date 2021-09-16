namespace Google.GData.Extensions
{
	public class BatchErrors : SimpleContainer
	{
		private ExtensionCollection<BatchError> extensionCollection_0;

		public ExtensionCollection<BatchError> Errors
		{
			get
			{
				if (extensionCollection_0 == null)
				{
					extensionCollection_0 = new ExtensionCollection<BatchError>(this);
				}
				return extensionCollection_0;
			}
		}

		public BatchErrors()
			: base("errors", "gd", "http://schemas.google.com/g/2005")
		{
			base.ExtensionFactories.Add(new BatchError());
		}
	}
}
