namespace Google.GData.Client
{
	public interface IExtensionContainer
	{
		ExtensionList ExtensionElements { get; }

		ExtensionList ExtensionFactories { get; }

		IExtensionElementFactory FindExtension(string localName, string ns);

		void ReplaceExtension(string localName, string ns, IExtensionElementFactory obj);

		ExtensionList FindExtensions(string localName, string ns);

		int DeleteExtensions(string localName, string ns);
	}
}
