using Google.GData.Client;

namespace Google.GData.Extensions.AppControl
{
	public class AppDraft : SimpleElement
	{
		public override bool BooleanValue
		{
			get
			{
				if (!(Value == "yes"))
				{
					return false;
				}
				return true;
			}
			set
			{
				Value = (value ? "yes" : "no");
			}
		}

		public AppDraft()
			: base("draft", "app", BaseNameTable.AppPublishingNamespace(null))
		{
		}

		public AppDraft(bool isDraft)
			: base("draft", "app", BaseNameTable.AppPublishingNamespace(null), isDraft ? "yes" : "no")
		{
		}

		protected override void VersionInfoChanged()
		{
			base.VersionInfoChanged();
			SetXmlNamespace(BaseNameTable.AppPublishingNamespace(this));
		}
	}
}
