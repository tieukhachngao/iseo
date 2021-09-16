using Google.GData.Client;

namespace Google.GData.Extensions.AppControl
{
	public class AppControl : SimpleContainer
	{
		public AppDraft Draft
		{
			get
			{
				return FindExtension("draft", BaseNameTable.AppPublishingNamespace(this)) as AppDraft;
			}
			set
			{
				ReplaceExtension("draft", BaseNameTable.AppPublishingNamespace(this), value);
			}
		}

		public AppControl()
			: this(BaseNameTable.AppPublishingNamespace(null))
		{
		}

		public AppControl(string ns)
			: base("control", "app", ns)
		{
			base.ExtensionFactories.Add(new AppDraft());
		}

		protected override void VersionInfoChanged()
		{
			base.VersionInfoChanged();
			SetXmlNamespace(BaseNameTable.AppPublishingNamespace(this));
		}
	}
}
