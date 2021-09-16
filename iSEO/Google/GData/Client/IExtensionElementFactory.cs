using System.Xml;

namespace Google.GData.Client
{
	public interface IExtensionElementFactory
	{
		string XmlName { get; }

		string XmlNameSpace { get; }

		string XmlPrefix { get; }

		IExtensionElementFactory CreateInstance(XmlNode node, AtomFeedParser parser);

		void Save(XmlWriter writer);
	}
}
